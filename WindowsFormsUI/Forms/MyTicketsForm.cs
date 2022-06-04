using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Forms
{
    public partial class MyTicketsForm : Form
    {
        public MyTicketsForm()
        {
            InitializeComponent();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
            _deletedTicketService = InstanceFactory.GetInstance<IDeletedTicketService>();
        }

        private ITicketService _ticketService;
        private ITransactionLogService _transactionLogService;
        private IDeletedTicketService _deletedTicketService;
        private void MyTicketsForm_Load(object sender, EventArgs e)
        {
            TicketControl();
            
            pnlTicketDetail.Hide();
        }

        private void TicketControl()
        {
            int ticketCount = _ticketService.GetAll().Data.Where(t => t.CustomerId == Login.loginCustomerId && t.DepartureDate > DateTime.Now).Count();
            if (ticketCount <= 0)
            {
                pnlTotalTicketCount.Hide();
                pnlNoTicket.Show();
                gcTickets.Hide();
            }
            else
            {
                GetCustomerTickets();
                pnlNoTicket.Hide();
                pnlTotalTicketCount.Show();
            }

            pnlTicketInfo.Hide();
        }
        private void GetCustomerTickets()
        {
            var ticktes = _ticketService.GetTicketDetails().Data.Where(t => t.CustomerId == Login.loginCustomerId && t.DepartureDate >= DateTime.Now).ToList();
            gcTickets.DataSource = ticktes;
            lblTicketCount.Text = "Sistemde " + ticktes.Count().ToString() + " adet biletiniz mevcut";
        }
        private void MyTicketsForm_Click(object sender, EventArgs e)
        {
            pnlTicketInfo.Hide();
        }
        private void btnTicketCancel_Click(object sender, EventArgs e)
        {
            string ticketCancelMessageText = lblDate.Text + " günü saat " + lblTime.Text + " daki, " + lblFrom.Text + " ile " + lblDestination.Text + " arasındaki olan bileti iptal etmek istiyor musunuz?";
            var ticketCancelMessage = MessageBox.Show(ticketCancelMessageText, "Bilet iptali", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (ticketCancelMessage == DialogResult.Yes)
                {
                    int ticketId = Convert.ToInt32(gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Id"));
                    var ticket = _ticketService.GetById(ticketId).Data;
                    //Added to archives
                    DeletedTicket deletedTicket = new DeletedTicket() { Id = ticket.Id, CustomerId = ticket.CustomerId, FromCityId = ticket.FromCityId, DestinationCityId = ticket.DestinationCityId, VehicleId = ticket.VehicleId, DepartureTimeId = ticket.DepartureTimeId, DepartureDate = ticket.DepartureDate, Seat = ticket.Seat, Price = ticket.Price };
                    _deletedTicketService.Add(deletedTicket);
                    _ticketService.Delete(_ticketService.GetById(ticketId).Data);
                    TransactionLog transactionLog = new TransactionLog() { CustomerId = Forms.Login.loginCustomerId, TransactionNameId = 2, DateOfTransaction = DateTime.Now };
                    _transactionLogService.Add(transactionLog);
                    TicketControl();
                    pnlTicketInfo.Hide();
                    MessageBox.Show("Biletiniz başarılı bir şekilde iptal edilmiştir. En geç 2 gün içerisinde paranız bankanıza iade edilecektir.", "Bilet iptali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTicketDetail_Click(object sender, EventArgs e)
        {
            int ticketId = Convert.ToInt32(gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Id"));
            var ticketDetail = _ticketService.GetTicketExtendetDetails().Data.Where(t => t.TicketId == ticketId).ToList();
            foreach (var ticket in ticketDetail)
            {
                lblTicketDetailTC.Text = ticket.TC;
                lblTicketDetailFirstName.Text = ticket.CustomerFisrtName;
                lblTicketDetailLastName.Text = ticket.CustomerLastName;
                lblTicketDetailPhone.Text = ticket.CustomerPhone;
                lblTicketDetailFrom.Text = ticket.From;
                lblTicketDetailDestination.Text = ticket.Destination;
                lblTicketDetailTime.Text = ticket.Time;
                lblTicketDetailDate.Text = ticket.Date.ToShortDateString();
                lblTicketDetailSeat.Text = ticket.Seat;
                lblTicketDetailPrice.Text = "₺" + ticket.Price.ToString();
                lblTicketDetailChauffeurFisrtName.Text = ticket.ChauffeurFisrtName;
                lblTicketDetailChauffeurLastName.Text = ticket.ChauffeurLastName;
                lblTicketDetailChauffeurPhone.Text = ticket.ChauffeurPhone;
                lblTicketDetailBusPlateNo.Text = ticket.BusPlateNo;
            }

            pnlTicketDetail.Show();
        }

        private void gvTickets_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pnlTicketInfo.Show();
            lblFirstName.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FirstName").ToString();
            lblLastName.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "LastName").ToString();
            lblFrom.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FromCity").ToString();
            lblDestination.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DestinationCity").ToString();
            lblTime.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DepartureTime").ToString();
            lblDate.Text = Convert.ToDateTime(gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DepartureDate")).ToLongDateString();
            lblSeat.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Seat").ToString();
            lblPrice.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Price").ToString();
        }
        private void gvTickets_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            pnlTicketInfo.Show();
            lblFirstName.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FirstName").ToString();
            lblLastName.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "LastName").ToString();
            lblFrom.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FromCity").ToString();
            lblDestination.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DestinationCity").ToString();
            lblTime.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DepartureTime").ToString();
            lblDate.Text = Convert.ToDateTime(gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DepartureDate")).ToLongDateString();
            lblSeat.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Seat").ToString();
            lblPrice.Text = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Price").ToString();
        }
    }
}
