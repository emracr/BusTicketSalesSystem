using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
    public partial class ChauffeurCustomerTicketsForm : Form
    {
        public ChauffeurCustomerTicketsForm()
        {
            InitializeComponent();
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
        }
        private IChauffeurService _chauffeurService;
        private ITicketService _ticketService;
        private void ChauffeurCustomerTicketsForm_Load(object sender, EventArgs e)
        {
            var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
            lblInfo.Text = "Sn. " + chauffeur.FirstName + " " + chauffeur.LastName + " sefere çıkmadan önce yanda bulunan takvimi kullanarak bir tarih seçiniz. Sorguladığınız tarihe ait müşterilerin biletleri aşağıda listelenecketir. Sefere çıkmadan önce rapor alıp biletleri teğit etmeyi unutmayınız.";

            mcTravelDate.MinValue = DateTime.Now;
            mcTravelDate.MaxValue = DateTime.Now.AddMonths(3);

            peDateSearch.Hide();
            lblDateSearch.Hide();
            pnlReportsType.Hide();
            pnlRecordNotFound.Hide();
            gcTickets.Hide();
        }
        private void mcTravelDate_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                int vehicleId = Forms.ChauffeurLoginForm.chauffeurId;
                DateTime dateTravel = mcTravelDate.SelectionStart;
                var tickets = _ticketService.GetTicketDetails().Data.Where(t => t.VehicleId == vehicleId && t.DepartureDate.ToShortDateString() == dateTravel.ToShortDateString());

                if (tickets.Count() > 0)
                {
                    gcTickets.Show();
                    gcTickets.DataSource = tickets;
                    peDateSearch.Show();
                    lblDateSearch.Show();
                    pnlReportsType.Show();
                    pnlRecordNotFound.Hide();
                    lblDateSearch.Text = dateTravel.ToLongDateString() + " tarihindeki müşterilerin biletleri aşağıda listelenmiştir.";
                    lblDateSearch.Show();
                }
                else
                {
                    lblRecordNotFound.Text = mcTravelDate.SelectionStart.ToShortDateString() + " tarihine ait hiç bir bilet bulunamadı";
                    pnlRecordNotFound.Show();
                    pnlReportsType.Hide();
                    peDateSearch.Hide();
                    lblDateSearch.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTicketReportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                gcTickets.ExportToPdf(@"C:\Users\ACAR\Desktop\" + mcTravelDate.SelectionStart.ToShortDateString() + " Tarihindeki Biletler.pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTicketReportWord_Click(object sender, EventArgs e)
        {
            try
            {
                gcTickets.ExportToDocx(@"C:\Users\ACAR\Desktop\" + mcTravelDate.SelectionStart.ToShortDateString() + " Tarihindeki Biletler.docx");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTicketReportExel_Click(object sender, EventArgs e)
        {
            try
            {
                gcTickets.ExportToXlsx(@"C:\Users\ACAR\Desktop\" + mcTravelDate.SelectionStart.ToShortDateString() + " Tarihindeki Biletler.xlsx");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
