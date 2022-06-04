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
    public partial class GetTicketForm : Form
    {
        public GetTicketForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _departureTimeService = InstanceFactory.GetInstance<IDepartureTimeService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _vehicleService = InstanceFactory.GetInstance<IVehicleService>();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
        }

        private ICityService _cityService;
        private IDepartureTimeService _departureTimeService;
        private ICustomerService _customerService;
        private IVehicleService _vehicleService;
        private ITicketService _ticketService;
        private ITransactionLogService _transactionLogService;
        private void GetTicketForm_Load(object sender, EventArgs e)
        {
            tmrLoad.Start();
            pnlDateLocationTime.Hide();
            mcTravelDate.MinValue = DateTime.Now.AddDays(1);
            mcTravelDate.MaxValue = DateTime.Now.AddDays(90);
            GetFromCity();
            GetDestinationCity();
            GetTravelTime();
            pnlBusBaseForSeat.Hide();
            pnlTicketConfirm.Hide();
            pnlGetTicketSuccess.Hide();
            pnlTicketPayment.Hide();
            pnlTicketDetails.Hide();
            pnlExpeditionLoading.Hide();
        }
        private void GetFromCity()
        {
            lueCityFrom.Properties.DataSource = _cityService.GetAll().Data;
            lueCityFrom.Properties.ValueMember = "Id";
            lueCityFrom.Properties.DisplayMember = "CityName";
            lueCityFrom.Properties.PopulateColumns();
            lueCityFrom.Properties.Columns[0].Visible = false;
            lueCityFrom.Properties.Columns[1].Caption = "Şehirler";

            lueCityFrom.EditValue = 34;
        }
        private void GetDestinationCity()
        {
            lueCityDestination.Properties.DataSource = _cityService.GetAll().Data;
            lueCityDestination.Properties.ValueMember = "Id";
            lueCityDestination.Properties.DisplayMember = "CityName";
            lueCityDestination.Properties.PopulateColumns();
            lueCityDestination.Properties.Columns[0].Visible = false;
            lueCityDestination.Properties.Columns[1].Caption = "Şehirler";

            lueCityDestination.EditValue = 6;
        }

        private void GetTravelTime()
        {
            lueTravelTime.Properties.DataSource = _departureTimeService.GetAll().Data;
            lueTravelTime.Properties.ValueMember = "Id";
            lueTravelTime.Properties.DisplayMember = "Time";
            lueTravelTime.Properties.PopulateColumns();
            lueTravelTime.Properties.Columns[0].Visible = false;
            lueTravelTime.Properties.Columns[1].Caption = "Seyahat Saatleri";

            lueTravelTime.EditValue = 4;
        }
        private void peSwap_Click(object sender, EventArgs e)
        {
            int selectedCityIndex = Convert.ToInt32(lueCityFrom.EditValue);
            lueCityFrom.EditValue = lueCityDestination.EditValue;
            lueCityDestination.EditValue = selectedCityIndex;
        }
        private void btnContinueSeatSelection_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lueTravelTime.EditValue) > 0 && Convert.ToInt32(lueCityDestination.EditValue) > 0 && Convert.ToInt32(lueTravelTime.EditValue) > 0)
                {
                    var tickets = _ticketService.GetAll().Data.Where(t => t.CustomerId == Login.loginCustomerId && t.DepartureDate.ToShortDateString() == mcTravelDate.SelectionStart.ToShortDateString() && t.DepartureTimeId == Convert.ToInt32(lueTravelTime.EditValue)).Count();
                    var vehicleQuery = _vehicleService.GetAll().Data.Where(v => v.FromCityId == Convert.ToInt32(lueCityFrom.EditValue) && v.DestinationCityId == Convert.ToInt32(lueCityDestination.EditValue) && v.VehicleDepartureTimeId == Convert.ToInt32(lueTravelTime.EditValue)).Count();

                    if (vehicleQuery > 0)
                    {
                        if (tickets <= 0)
                        {
                            ClearBeforeTravelDateSeat();
                            SeatControl();
                            pnlExpeditionLoading.Show();
                            tmrExpeditionLoad.Start();
                        }
                        else
                        {
                            MessageBox.Show(mcTravelDate.SelectionStart.ToShortDateString() + " tarihinde saat " + lueTravelTime.Properties.GetDisplayText(lueTravelTime.EditValue) + "'da seferiniz bulunmaktadır, bu sebeple bilet alamssınız", "Bilet çakışması", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Malesef bu güzergahlar arasında veya saat'te sefer bulunmamaktadır.", "Sefer bulunmamaktadır", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm seyahat bilgilerini eksiksiz doldurun", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlBusBaseForSeat.Hide();
        }
        private void ClearActiveSeat()
        {
            btnSeat1.Image = btnSeat2.Image = btnSeat3.Image = btnSeat4.Image = btnSeat5.Image = btnSeat6.Image = btnSeat7.Image = btnSeat8.Image = btnSeat9.Image = btnSeat10.Image = btnSeat11.Image = btnSeat12.Image = btnSeat13.Image = btnSeat14.Image = btnSeat15.Image = btnSeat16.Image = btnSeat17.Image = btnSeat18.Image = btnSeat19.Image = btnSeat20.Image = btnSeat21.Image = btnSeat22.Image = global::WindowsFormsUI.Properties.Resources.armchair__1_;
            btnSeat1.ForeColor = btnSeat2.ForeColor = btnSeat3.ForeColor = btnSeat4.ForeColor = btnSeat5.ForeColor = btnSeat6.ForeColor = btnSeat7.ForeColor = btnSeat8.ForeColor = btnSeat9.ForeColor = btnSeat10.ForeColor = btnSeat11.ForeColor = btnSeat12.ForeColor = btnSeat13.ForeColor = btnSeat14.ForeColor = btnSeat15.ForeColor = btnSeat16.ForeColor = btnSeat17.ForeColor = btnSeat18.ForeColor = btnSeat19.ForeColor = btnSeat20.ForeColor = btnSeat21.ForeColor = btnSeat22.ForeColor = Color.FromArgb(64, 64, 64);
        }
        private void ClearBeforeTravelDateSeat()
        {
            btnSeat1.Visible = btnSeat2.Visible = btnSeat3.Visible = btnSeat4.Visible = btnSeat5.Visible = btnSeat6.Visible = btnSeat7.Visible = btnSeat8.Visible = btnSeat9.Visible = btnSeat10.Visible = btnSeat11.Visible = btnSeat12.Visible = btnSeat13.Visible = btnSeat14.Visible = btnSeat15.Visible = btnSeat16.Visible = btnSeat17.Visible = btnSeat18.Visible = btnSeat19.Visible = btnSeat20.Visible = btnSeat21.Visible = btnSeat22.Visible = true;
            pbSeat1.Image = pbSeat2.Image = pbSeat3.Image = pbSeat4.Image = pbSeat5.Image = pbSeat6.Image = pbSeat7.Image = pbSeat8.Image = pbSeat9.Image = pbSeat10.Image = pbSeat11.Image = pbSeat12.Image = pbSeat13.Image = pbSeat14.Image = pbSeat15.Image = pbSeat16.Image = pbSeat17.Image = pbSeat18.Image = pbSeat19.Image = pbSeat20.Image = pbSeat21.Image = btnSeat22.Image = global::WindowsFormsUI.Properties.Resources.armchair__1_;
        }
        int counter = 0;
        private void tmrExpeditionLoad_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 5)
            {
                pnlBusBaseForSeat.Show();
                pnlExpeditionLoading.Hide();
                tmrExpeditionLoad.Dispose();
                counter = 0;
            }
        }

        private string seatNumber;
        private void ActiveSeat(Button btnSender)
        {
            ClearActiveSeat();
            var customer = _customerService.GetById(Login.loginCustomerId).Data;
            if (customer.GenderId == 1)
            {
                btnSender.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
            }
            else
            {
                btnSender.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
            }
            seatNumber = btnSender.Text;
            btnSender.ForeColor = Color.FromArgb(237, 237, 237);
        }

        private void btnSeat1_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat1);
        }

        private void btnSeat2_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat2);
        }

        private void btnSeat3_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat3);
        }

        private void btnSeat4_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat4);
        }

        private void btnSeat5_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat5);
        }

        private void btnSeat6_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat6);
        }

        private void btnSeat7_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat7);
        }

        private void btnSeat8_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat8);
        }

        private void btnSeat9_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat9);
        }

        private void btnSeat10_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat10);
        }

        private void btnSeat11_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat11);
        }

        private void btnSeat12_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat12);
        }

        private void btnSeat13_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat13);
        }

        private void btnSeat14_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat14);
        }

        private void btnSeat15_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat15);
        }

        private void btnSeat16_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat16);
        }

        private void btnSeat17_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat17);
        }

        private void btnSeat18_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat18);
        }

        private void btnSeat19_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat19);
        }

        private void btnSeat20_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat20);
        }

        private void btnSeat21_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat21);
        }

        private void btnSeat22_Click(object sender, EventArgs e)
        {
            ActiveSeat(btnSeat22);
        }
        private void btnNextTicketPayment_Click(object sender, EventArgs e)
        {
            if (seatNumber == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin", "Koltuk seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblTotalPricePaymentCredit.Text = "Ödenecek tutar : " + (120 + (Math.Abs(Convert.ToInt32(lueCityFrom.EditValue) - Convert.ToInt32(lueCityDestination.EditValue)))).ToString() + "₺";
                pnlTicketPayment.Show();
            }
        }
        private void btnTicketConfirmCancel_Click(object sender, EventArgs e)
        {
            pnlBusBaseForSeat.Hide();
            pnlTicketPayment.Hide();
            pnlTicketConfirm.Hide();
            pnlDateLocationTime.Show();
        }

        private int _ticketId;
        private void btnConfirmTicket_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerService.GetById(Login.loginCustomerId).Data;
                var vehicle = _vehicleService.GetAll().Data.SingleOrDefault(v => v.VehicleDepartureTimeId == Convert.ToInt32(lueTravelTime.EditValue) && v.FromCityId == Convert.ToInt32(lueCityFrom.EditValue) && v.DestinationCityId == Convert.ToInt32(lueCityDestination.EditValue));

                Ticket ticket = new Ticket();
                ticket.CustomerId = customer.Id;
                ticket.FromCityId = Convert.ToInt32(lueCityFrom.EditValue);
                ticket.DestinationCityId = Convert.ToInt32(lueCityDestination.EditValue);
                ticket.VehicleId = vehicle.Id;
                ticket.DepartureTimeId = Convert.ToInt32(lueTravelTime.EditValue);
                ticket.DepartureDate = mcTravelDate.SelectionStart;
                ticket.Seat = seatNumber.Trim();
                ticket.Price = 120 + (Math.Abs(Convert.ToInt32(lueCityFrom.EditValue) - Convert.ToInt32(lueCityDestination.EditValue)));
                ticket.DateTaken = DateTime.Now;

                _ticketService.Add(ticket);
                _ticketId = ticket.Id;
                TransactionLog transactionLog = new TransactionLog() { CustomerId = Forms.Login.loginCustomerId, TransactionNameId = 1, DateOfTransaction = DateTime.Now };
                _transactionLogService.Add(transactionLog);
                pnlGetTicketSuccess.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNextTicketConfirm_Click(object sender, EventArgs e)
        {
            if (tbCreditNumber1.Text.Length == 4 && tbCreditNumber2.Text.Length == 4 && tbCreditNumber3.Text.Length == 4 && tbCreditNumber4.Text.Length == 4 && tbCreditOwner.Text != null && cbCreditVaildMonth != null && cbCreditVaildYear != null && tbCreditCCV.Text.Length == 3)
            {
                var customer = _customerService.GetById(Login.loginCustomerId).Data;
                lblTC.Text = customer.TC;
                lblFirstName.Text = customer.FirstName;
                lblLastName.Text = customer.LastName;
                lblDate.Text = mcTravelDate.SelectionStart.ToShortDateString();
                lblTime.Text = lueTravelTime.Properties.GetDisplayText(lueTravelTime.EditValue);
                lblSeat.Text = seatNumber.Trim();
                lblFrom.Text = lueCityFrom.Properties.GetDisplayText(lueCityFrom.EditValue).ToString();
                lblDestination.Text = lueCityDestination.Properties.GetDisplayText(lueCityDestination.EditValue).ToString();
                lblPrice.Text = "₺ " + (120 + (Math.Abs(Convert.ToInt32(lueCityFrom.EditValue) - Convert.ToInt32(lueCityDestination.EditValue)))).ToString();
                pnlTicketConfirm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen kart bilgilerinizi eksiksiz doldurun", "Kart bilgileri eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPrevisuBusSeat_Click(object sender, EventArgs e)
        {
            pnlTicketPayment.Hide();
            pnlBusBaseForSeat.Show();
        }
        private void btnTicketDetails_Click(object sender, EventArgs e)
        {
            var ticketDetail = _ticketService.GetTicketExtendetDetails().Data.Where(t => t.TicketId == _ticketId).ToList();
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
            pnlAnimation.Hide();
            pnlTicketDetails.Show();
        }

        int second = 0;
        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            second++;

            if (second >= 4)
            {
                pnlDateLocationTime.Show();
                tmrLoad.Dispose();
            }
        }
        private void SeatControl()
        {
            var ticktes = _ticketService.GetAll().Data;
            foreach (var ticket in ticktes)
            {
                if (ticket.DepartureDate.ToShortDateString() == mcTravelDate.SelectionStart.ToShortDateString() && ticket.FromCityId == Convert.ToInt32(lueCityFrom.EditValue) && ticket.DestinationCityId == Convert.ToInt32(lueCityDestination.EditValue) && ticket.DepartureTimeId == Convert.ToInt32(lueTravelTime.EditValue))
                {
                    int genderId = _customerService.GetById(ticket.CustomerId).Data.GenderId;

                    if (ticket.Seat == Convert.ToString(1))
                    {
                        btnSeat1.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat1.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat1.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(2))
                    {
                        btnSeat2.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat2.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat2.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(3))
                    {
                        btnSeat3.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat3.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat3.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(4))
                    {
                        btnSeat4.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat4.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat4.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(5))
                    {
                        btnSeat5.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat5.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat5.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(6))
                    {
                        btnSeat6.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat6.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat6.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(7))
                    {
                        btnSeat7.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat7.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat7.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(8))
                    {
                        btnSeat8.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat8.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat8.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(9))
                    {
                        btnSeat9.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat9.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat9.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(10))
                    {
                        btnSeat10.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat10.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat10.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(11))
                    {
                        btnSeat11.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat11.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat11.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(12))
                    {
                        btnSeat12.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat12.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat12.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(13))
                    {
                        btnSeat13.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat13.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat13.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(14))
                    {
                        btnSeat14.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat14.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat14.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(15))
                    {
                        btnSeat15.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat15.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat15.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(16))
                    {
                        btnSeat16.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat16.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat16.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(17))
                    {
                        btnSeat17.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat17.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat17.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(18))
                    {
                        btnSeat18.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat18.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat18.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(19))
                    {
                        btnSeat19.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat19.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat19.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(20))
                    {
                        btnSeat20.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat20.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat20.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(21))
                    {
                        btnSeat21.Visible = false;
                        if (genderId == 1)
                        {
                            pbSeat21.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            pbSeat21.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                    else if (ticket.Seat == Convert.ToString(22))
                    {
                        btnSeat22.Visible = false;
                        if (genderId == 1)
                        {
                            btnSeat22.Image = global::WindowsFormsUI.Properties.Resources.armchairMan;
                        }
                        else
                        {
                            btnSeat22.Image = global::WindowsFormsUI.Properties.Resources.armchairWoman;
                        }
                    }
                }
            }
        }

        private void tbCreditOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
