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
    public partial class AdminHomePageForm : Form
    {
        public AdminHomePageForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
            _vehicleService = InstanceFactory.GetInstance<IVehicleService>();
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
            _departureTimeService = InstanceFactory.GetInstance<IDepartureTimeService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            _loginLogService = InstanceFactory.GetInstance<ILoginLogService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
            _genderService = InstanceFactory.GetInstance<IGenderService>();
            _deletedCustomerService = InstanceFactory.GetInstance<IDeletedCustomerService>();
            _deletedTicketService = InstanceFactory.GetInstance<IDeletedTicketService>();

        }

        private ICustomerService _customerService;
        private ITicketService _ticketService;
        private IVehicleService _vehicleService;
        private IChauffeurService _chauffeurService;
        private IDepartureTimeService _departureTimeService;
        private ICityService _cityService;
        private ILoginLogService _loginLogService;
        private ITransactionLogService _transactionLogService;
        private IGenderService _genderService;
        private IDeletedCustomerService _deletedCustomerService;
        private IDeletedTicketService _deletedTicketService;
        private void AdminHomePageForm_Load(object sender, EventArgs e)
        {
            var customers = _customerService.GetAll().Data;
            var tickets = _ticketService.GetAll().Data;
            var vehicles = _vehicleService.GetAll().Data;
            var chauffeurs = _chauffeurService.GetAll().Data;

            lblUsersCount.Text = customers.Count().ToString();
            lblTicketCount.Text = tickets.Count().ToString();
            lblVehicleCount.Text = vehicles.Count().ToString();
            lblChauffeurCount.Text = chauffeurs.Count().ToString();
            lblLogCount.Text = (_loginLogService.GetAll().Data.Count() + _transactionLogService.GetAll().Data.Count).ToString();

            pnlUsers.Hide();
            pnlTickets.Hide();
            pnlVehicles.Hide();
            pnlChauffeurs.Hide();
            pnlLogs.Hide();
            pnlLoginLogsShow.Hide();
            pnlTransactionLogsShow.Hide();
            pnlStatistics.Hide();
        }

        private void pnlUsersDiv_Click(object sender, EventArgs e)
        {
            GetUsers();
            pnlUsers.Show();
        }

        private void GetUsers()
        {
            gdUsers.DataSource = _customerService.GetCustomerDetails().Data;
        }
        private void repositoryItemUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = Convert.ToInt32(gvUsers.GetRowCellValue(gvUsers.FocusedRowHandle, "Id"));
                var getUser = _customerService.GetById(userId).Data;
                string getUserName = getUser.FirstName + " " + getUser.LastName;
                var result = MessageBox.Show(getUserName + " adlı kullanıcıyı silmek istiyor musunuz?", "Kullanıcı silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Added to archives
                    DeletedCustomer deletedCustomer = new DeletedCustomer() { Id = getUser.Id, GenderId = getUser.GenderId, TC = getUser.TC, FirstName = getUser.FirstName, LastName = getUser.LastName, Phone = getUser.Phone, Email = getUser.Email, DateOfBirth = getUser.DateOfBrith };
                    _deletedCustomerService.Add(deletedCustomer);

                    DeleteCustomerRelations(userId);
                    _customerService.Delete(getUser);
                    GetUsers();
                    MessageBox.Show("Kullanıcı başarılı bir şekilde silindi", "Kullanıcı silindi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeleteCustomerRelations(int userId)
        {
            var tickets = _ticketService.GetAll().Data.Where(t => t.CustomerId == userId);
            var loginLogs = _loginLogService.GetAll().Data.Where(l => l.CustomerId == userId);
            var transactionLogs = _transactionLogService.GetAll().Data.Where(t => t.CustomerId == userId);

            foreach (var ticket in tickets)
            {
                //Added to archives
                DeletedTicket deletedTicket = new DeletedTicket() { Id = ticket.Id, CustomerId = ticket.CustomerId, FromCityId = ticket.FromCityId, DestinationCityId = ticket.DestinationCityId, VehicleId = ticket.VehicleId, DepartureTimeId = ticket.DepartureTimeId, DepartureDate = ticket.DepartureDate, Seat = ticket.Seat, Price = ticket.Price };
                _deletedTicketService.Add(deletedTicket);
                _ticketService.Delete(ticket);
            }

            foreach (var log in loginLogs)
            {
                _loginLogService.Delete(log);
            }

            foreach (var transaction in transactionLogs)
            {
                _transactionLogService.Delete(transaction);
            }
        }

        private void GetTickets()
        {
            gcTickets.DataSource = _ticketService.GetTicketDetails().Data;
        }
        private void pnlTicketsDiv_Click(object sender, EventArgs e)
        {
            GetTickets();
            pnlTickets.Show();
        }
        private void repositoryItemBtnTicketDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketId = Convert.ToInt32(gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "Id"));
                var getTicket = _ticketService.GetById(ticketId).Data;
                string deleteInfo = gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FirstName").ToString() + " " + gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "LastName").ToString() + " adlı müşterinin, " + gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "FromCity").ToString() + " - " + gvTickets.GetRowCellValue(gvTickets.FocusedRowHandle, "DestinationCity").ToString() + " güzergahı arasındaki biletini silmek istiyor musunuz?";
                var result = MessageBox.Show(deleteInfo, "Bilet silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Added to archives
                    DeletedTicket deletedTicket = new DeletedTicket() { Id = getTicket.Id, CustomerId = getTicket.CustomerId, FromCityId = getTicket.FromCityId, DestinationCityId = getTicket.DestinationCityId, VehicleId = getTicket.VehicleId, DepartureTimeId = getTicket.DepartureTimeId, DepartureDate = getTicket.DepartureDate, Seat = getTicket.Seat, Price = getTicket.Price };
                    _deletedTicketService.Add(deletedTicket);

                    _ticketService.Delete(_ticketService.GetById(ticketId).Data);
                    GetTickets();
                    MessageBox.Show("Bilet başarılı bir şekilde silindi", "Bilet silindi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetVehicles()
        {
            gcVehicles.DataSource = _vehicleService.GetVehiclesDetails().Data;
        }

        private void pnlVehiclesDiv_Click(object sender, EventArgs e)
        {
            GetVehicles();
            pnlVehicles.Show();
            pnlVehicleUpdate.Hide();
            pnlVehicleAdd.Hide();
        }
        private void repositoryItemBtnVehicleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "Id"));
                var result = MessageBox.Show("Bu araca ait daha önceden satın alınmış biletler olabilir. Aracı silerseniz bu araca ait daha önceden alınmış tüm biletler silinip arşivlere eklenir. Aracı yinede silmek istiyor musunuz?", "Araç silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteVehicleRelations(vehicleId);
                    _vehicleService.Delete(_vehicleService.GetById(vehicleId).Data);
                    GetVehicles();
                    MessageBox.Show("Araç başarılı bir şekilde silindi", "Araç silindi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteVehicleRelations(int vehicleId)
        {
            var tickets = _ticketService.GetAll().Data.Where(t => t.VehicleId == vehicleId);
            foreach (var ticket in tickets)
            {
                //Added to archives
                DeletedTicket deletedTicket = new DeletedTicket() { Id = ticket.Id, CustomerId = ticket.CustomerId, FromCityId = ticket.FromCityId, DestinationCityId = ticket.DestinationCityId, VehicleId = ticket.VehicleId, DepartureTimeId = ticket.DepartureTimeId, DepartureDate = ticket.DepartureDate, Seat = ticket.Seat, Price = ticket.Price };
                _deletedTicketService.Add(deletedTicket);
                _ticketService.Delete(ticket);
            }
        }
        private void VehicleUpdateFieldClear()
        {
            lueChauffeur.Properties.DataSource = null;
            lueDapartureTime.Properties.DataSource = null;
            lueFrom.Properties.DataSource = null;
            lueDestination.Properties.DataSource = null;
            teVehiclePlateNumber.Text = "";
        }
        private void repositoryItemBtnVehicleUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleUpdateFieldClear();

                int chauffeurId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "ChauffeurId"));
                var chauffeurs = _chauffeurService.GetAll().Data;
                int timeId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "VehicleDepartureTimeId"));
                var vehicleDepartureTimes = _departureTimeService.GetAll().Data.ToList();
                var cities = _cityService.GetAll().Data;
                var fromCityId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "FromCityId"));
                var destinationCityId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "DestinationCityId"));

                lueChauffeur.Properties.DataSource = chauffeurs;
                lueChauffeur.Properties.DisplayMember = "Name";
                lueChauffeur.Properties.ValueMember = "Id";
                lueChauffeur.Properties.PopulateColumns();
                lueChauffeur.Properties.Columns[0].Visible = lueChauffeur.Properties.Columns[1].Visible = lueChauffeur.Properties.Columns[2].Visible = lueChauffeur.Properties.Columns[3].Visible = lueChauffeur.Properties.Columns[4].Visible = lueChauffeur.Properties.Columns[5].Visible = lueChauffeur.Properties.Columns[6].Visible = lueChauffeur.Properties.Columns[7].Visible = false;
                lueChauffeur.Properties.Columns[8].Caption = "Şoförler";
                lueChauffeur.EditValue = chauffeurId;

                lueDapartureTime.Properties.DataSource = _departureTimeService.GetAll().Data;
                lueDapartureTime.Properties.ValueMember = "Id";
                lueDapartureTime.Properties.DisplayMember = "Time";
                lueDapartureTime.Properties.PopulateColumns();
                lueDapartureTime.Properties.Columns[0].Visible = false;
                lueDapartureTime.Properties.Columns[1].Caption = "Kalkış Saatleri";
                lueDapartureTime.EditValue = timeId;

                lueFrom.Properties.DataSource = _cityService.GetAll().Data;
                lueFrom.Properties.ValueMember = "Id";
                lueFrom.Properties.DisplayMember = "CityName";
                lueFrom.Properties.PopulateColumns();
                lueFrom.Properties.Columns[0].Visible = false;
                lueFrom.Properties.Columns[1].Caption = "Şehirler";
                lueFrom.EditValue = fromCityId;

                lueDestination.Properties.DataSource = _cityService.GetAll().Data;
                lueDestination.Properties.ValueMember = "Id";
                lueDestination.Properties.DisplayMember = "CityName";
                lueDestination.Properties.PopulateColumns();
                lueDestination.Properties.Columns[0].Visible = false;
                lueDestination.Properties.Columns[1].Caption = "Şehirler";
                lueDestination.EditValue = destinationCityId;

                teVehiclePlateNumber.Text = gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "VehiclePlateNumber").ToString();

                pnlVehicleUpdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVehicleUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int vehicleId = Convert.ToInt32(gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "Id"));
                var vehicle = _vehicleService.GetById(vehicleId).Data;
                vehicle.ChauffeurId = Convert.ToInt32(lueChauffeur.EditValue);
                vehicle.VehicleDepartureTimeId = Convert.ToInt32(lueDapartureTime.EditValue);
                vehicle.FromCityId = Convert.ToInt32(lueFrom.EditValue);
                vehicle.DestinationCityId = Convert.ToInt32(lueDestination.EditValue);
                vehicle.PlateNumber = teVehiclePlateNumber.Text;
                _vehicleService.Update(vehicle);
                pnlVehicleUpdate.Hide();
                GetVehicles();
                MessageBox.Show("Araç başarılı bir şekilde güncellendi", "Araç güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVehicleUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlVehicleUpdate.Hide();
        }
        private void VehicleAddFieldClear()
        {
            lueVehicleAddDepartureTime.Properties.DataSource = null;
            lueVehicleAddDepartureTime.EditValue = -1;
            lueVehicleAddDestinationCity.Properties.DataSource = null;
            lueVehicleAddDestinationCity.EditValue = -1;
            lueVehicleAddFromCity.Properties.DataSource = null;
            lueVehicleAddFromCity.EditValue = -1;
            teVehicleAddPlateNumber.Text = "";
        }
        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleAddFieldClear();
                lueVehicleAddChauffeur.Focus();
                var chauffeurs = _chauffeurService.GetAll().Data;

                lueVehicleAddChauffeur.Properties.DataSource = chauffeurs;
                lueVehicleAddChauffeur.Properties.DisplayMember = "Name";
                lueVehicleAddChauffeur.Properties.ValueMember = "Id";
                lueVehicleAddChauffeur.EditValue = -1;
                lueVehicleAddChauffeur.Properties.PopulateColumns();
                lueVehicleAddChauffeur.Properties.Columns[0].Visible = lueVehicleAddChauffeur.Properties.Columns[1].Visible = lueVehicleAddChauffeur.Properties.Columns[2].Visible = lueVehicleAddChauffeur.Properties.Columns[3].Visible = lueVehicleAddChauffeur.Properties.Columns[4].Visible = lueVehicleAddChauffeur.Properties.Columns[5].Visible = lueVehicleAddChauffeur.Properties.Columns[6].Visible = lueVehicleAddChauffeur.Properties.Columns[7].Visible = false;
                lueVehicleAddChauffeur.Properties.Columns[8].Caption = "Şoförler";

                lueVehicleAddDepartureTime.Properties.DataSource = _departureTimeService.GetAll().Data;
                lueVehicleAddDepartureTime.Properties.ValueMember = "Id";
                lueVehicleAddDepartureTime.Properties.DisplayMember = "Time";
                lueVehicleAddDepartureTime.Properties.PopulateColumns();
                lueVehicleAddDepartureTime.Properties.Columns[0].Visible = false;
                lueVehicleAddDepartureTime.Properties.Columns[1].Caption = "Kalkış Saatleri";

                lueVehicleAddFromCity.Properties.DataSource = _cityService.GetAll().Data;
                lueVehicleAddFromCity.Properties.ValueMember = "Id";
                lueVehicleAddFromCity.Properties.DisplayMember = "CityName";
                lueVehicleAddFromCity.Properties.PopulateColumns();
                lueVehicleAddFromCity.Properties.Columns[0].Visible = false;
                lueVehicleAddFromCity.Properties.Columns[1].Caption = "Şehirler";

                lueVehicleAddDestinationCity.Properties.DataSource = _cityService.GetAll().Data;
                lueVehicleAddDestinationCity.Properties.ValueMember = "Id";
                lueVehicleAddDestinationCity.Properties.DisplayMember = "CityName";
                lueVehicleAddDestinationCity.Properties.PopulateColumns();
                lueVehicleAddDestinationCity.Properties.Columns[0].Visible = false;
                lueVehicleAddDestinationCity.Properties.Columns[1].Caption = "Şehirler";

                pnlVehicleAdd.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVehicleAddSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(lueVehicleAddChauffeur.EditValue) < 0 || Convert.ToInt32(lueVehicleAddFromCity.EditValue) < 0 || Convert.ToInt32(lueVehicleAddDestinationCity.EditValue) < 0 || Convert.ToInt32(lueVehicleAddDepartureTime.EditValue) < 0 || teVehicleAddPlateNumber.Text.Length == 0)
                {
                    MessageBox.Show("Araç bilgilerinide eksiklik var, lütfen tüm alanları doldurun", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Vehicle vehicle = new Vehicle();
                    vehicle.ChauffeurId = Convert.ToInt32(lueVehicleAddChauffeur.EditValue);
                    vehicle.FromCityId = Convert.ToInt32(lueVehicleAddFromCity.EditValue);
                    vehicle.DestinationCityId = Convert.ToInt32(lueVehicleAddDestinationCity.EditValue);
                    vehicle.VehicleDepartureTimeId = Convert.ToInt32(lueVehicleAddDepartureTime.EditValue);
                    vehicle.PlateNumber = teVehicleAddPlateNumber.Text;

                    _vehicleService.Add(vehicle);
                    GetVehicles();
                    pnlVehicleAdd.Hide();
                    MessageBox.Show("Araç başarılı bir şekilde eklendi", "Araç Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pnlVehicleAddCancel_Click(object sender, EventArgs e)
        {
            pnlVehicleAdd.Hide();
        }

        private void GetChauffeurs()
        {
            gcChauffeurs.DataSource = _chauffeurService.GetChauffeurDetails().Data;
        }
        private void pnlChauffeursDiv_Click(object sender, EventArgs e)
        {
            GetChauffeurs();
            pnlChauffeurs.Show();
            pnlChauffeurUpdate.Hide();
            pnlChauffeurAdd.Hide();
        }
        private void repositoryItemBtnChauffeurDelete_Click(object sender, EventArgs e)
        {
            string chauffeurName = gvChauffeurs.GetRowCellValue(gvChauffeurs.FocusedRowHandle, "FirstName").ToString() + " " + gvChauffeurs.GetRowCellValue(gvChauffeurs.FocusedRowHandle, "LastName").ToString();
            var chauffeurId = Convert.ToInt32(gvChauffeurs.GetRowCellValue(gvChauffeurs.FocusedRowHandle, "Id"));
            var chauffeurVehicles = _vehicleService.GetAll().Data.Where(c => c.ChauffeurId == chauffeurId).Count();

            try
            {
                if (chauffeurVehicles > 0)
                {
                    MessageBox.Show(chauffeurName + " şoförüne ait " + chauffeurVehicles + " adet araç var bu sebeple şoförü silimessiniz. Şoförü silmek için aracın şoförünü başka bir şoföre devredin", "Şoför silinemez", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var result = MessageBox.Show("Şoför " + chauffeurName + " silinmek üzere silmek, istiyor musunuz?", "Şoför silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _chauffeurService.Delete(_chauffeurService.GetById(chauffeurId).Data);
                        GetChauffeurs();
                        MessageBox.Show("Şoför başarılı bir şekilde silindi", "Şoför silindi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void repositoryItemBtnChauffeurUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var chauffeurId = Convert.ToInt32(gvChauffeurs.GetRowCellValue(gvChauffeurs.FocusedRowHandle, "Id"));
                var chauffeur = _chauffeurService.GetById(chauffeurId).Data;
                teChauffeurFirstName.Text = chauffeur.FirstName;
                teChauffeurLastName.Text = chauffeur.LastName;
                teChauffeurPhone.Text = chauffeur.Phone;
                deChauffeurDateOfBrith.DateTime = Convert.ToDateTime(chauffeur.DateOfBrith);
                deChauffeurDateOfBrith.Properties.MinValue = DateTime.Now.AddYears(-60);
                deChauffeurDateOfBrith.Properties.MaxValue = DateTime.Now.AddYears(-20);
                if (chauffeur.GenderId == 1)
                {
                    rgChauffeurGender.SelectedIndex = 0;
                }
                else
                {
                    rgChauffeurGender.SelectedIndex = 1;
                }
                pnlChauffeurUpdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChauffeurUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (teChauffeurFirstName.Text.Length > 0 && teChauffeurLastName.Text.Length > 0 && teChauffeurPhone.Text.Length == 10 && deChauffeurDateOfBrith.Text.Length > 2)
                {
                    var chauffeurId = Convert.ToInt32(gvChauffeurs.GetRowCellValue(gvChauffeurs.FocusedRowHandle, "Id"));

                    var chauffeur = _chauffeurService.GetById(chauffeurId).Data;
                    chauffeur.FirstName = teChauffeurFirstName.Text;
                    chauffeur.LastName = teChauffeurLastName.Text;
                    chauffeur.Phone = teChauffeurPhone.Text;
                    chauffeur.DateOfBrith = deChauffeurDateOfBrith.DateTime;
                    if (rgChauffeurGender.SelectedIndex == 0)
                    {
                        chauffeur.GenderId = 1;
                    }
                    else
                    {
                        chauffeur.GenderId = 2;
                    }
                    _chauffeurService.Update(chauffeur);
                    GetChauffeurs();
                    pnlChauffeurUpdate.Hide();
                    MessageBox.Show("Şoför başarılı bir şekilde güncellendi", "Şoför güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurun.", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChauffeurUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlChauffeurUpdate.Hide();
        }
        private void btnChauffeurAdd_Click(object sender, EventArgs e)
        {
            pnlChauffeurAdd.Show();
            CleanChauffeurAddField();
            deChauffeurAddDateOfBirth.Properties.MinValue = DateTime.Now.AddYears(-60);
            deChauffeurAddDateOfBirth.Properties.MaxValue = DateTime.Now.AddYears(-20);
        }
        private void CleanChauffeurAddField()
        {
            teChauffeurAddFirstName.Text = "";
            teChauffeurAddLastName.Text = "";
            teChauffeurAddPhone.Text = "";
            teChauffeurAddUserName.Text = "";
            teChauffeurAddPassword.Text = "";
            teChauffeurAddPasswordConfirm.Text = "";
            rgChauffeurAddGender.SelectedIndex = -1;
        }
        private void btnAddChauffeur_Click(object sender, EventArgs e)
        {
            try
            {
                if (teChauffeurAddFirstName.Text.Length > 0 && teChauffeurAddLastName.Text.Length > 0 && teChauffeurAddPhone.Text.Length == 10 && rgChauffeurAddGender.SelectedIndex >= 0 && teChauffeurAddUserName.Text.Length > 0 && teChauffeurAddPassword.Text.Length > 0 && teChauffeurAddPasswordConfirm.Text.Length > 0)
                {
                    if (teChauffeurAddPassword.Text == teChauffeurAddPasswordConfirm.Text)
                    {
                        var chauffeurs = _chauffeurService.GetAll().Data.Where(c=>c.UserName == teChauffeurAddUserName.Text).Count();
                        if (chauffeurs <= 0)
                        {
                            Chauffeur chauffeur = new Chauffeur();
                            chauffeur.FirstName = teChauffeurAddFirstName.Text;
                            chauffeur.LastName = teChauffeurAddLastName.Text;
                            chauffeur.Phone = teChauffeurAddPhone.Text;
                            chauffeur.DateOfBrith = deChauffeurAddDateOfBirth.DateTime;
                            chauffeur.UserName = teChauffeurAddUserName.Text;
                            chauffeur.Password = teChauffeurAddPassword.Text;
                            if (rgChauffeurAddGender.SelectedIndex == 0)
                            {
                                chauffeur.GenderId = 1;
                            }
                            else
                            {
                                chauffeur.GenderId = 2;
                            }
                            _chauffeurService.Add(chauffeur);
                            GetChauffeurs();
                            pnlChauffeurAdd.Hide();
                            MessageBox.Show("Şoför başarılı bir şekilde eklendi", "Şoför eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı başkası tarafından kullanılmaktadır", "Kullanıcı adı zaten kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar birbirleriyle uyuşmuyor, lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurun.", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChauffeurAddCancel_Click(object sender, EventArgs e)
        {
            pnlChauffeurAdd.Hide();
        }
        private void pnlLogsDiv_Click(object sender, EventArgs e)
        {
            lblLoginLogsCount.Text = _loginLogService.GetAll().Data.Count.ToString();
            lblTransactionLogsCount.Text = _transactionLogService.GetAll().Data.Count.ToString();
            pnlLogs.Show();
        }
        private void pnlLoginLogs_Click(object sender, EventArgs e)
        {
            gcLoginLogs.DataSource = _loginLogService.GetLoginLogDetails().Data;
            pnlLoginLogsShow.Show();
        }
        private void pnlTransactionLogs_Click(object sender, EventArgs e)
        {
            gcTransactionLogs.DataSource = _transactionLogService.GetTransactionLogDetails().Data;
            pnlTransactionLogsShow.Show();
        }
        private void pnlStatisticsDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int fromCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocation().Data.OrderByDescending(t => t.TicketCount).FirstOrDefault().FromCityId);
                int destinationCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocation().Data.OrderByDescending(t => t.TicketCount).FirstOrDefault().DestinationCityId);

                int lastOneMonthFromCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocationLastOneMonth().Data.Where(t => (DateTime.Now.Month == t.MonthNumber)).OrderByDescending(t => t.TicketCount).FirstOrDefault().FromCityId);
                int lastOneMonthDestinationCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocationLastOneMonth().Data.Where(t => (DateTime.Now.Month == t.MonthNumber)).OrderByDescending(t => t.TicketCount).FirstOrDefault().DestinationCityId);

                int leastTravelfromCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocation().Data.OrderBy(t => t.TicketCount).FirstOrDefault().FromCityId);
                int leastTraveldestinationCityId = Convert.ToInt32(_ticketService.GetTicketForTheMostLocation().Data.OrderBy(t => t.TicketCount).FirstOrDefault().DestinationCityId);

                int mostTraveledMonth = Convert.ToInt32(_ticketService.GetTicketTopSellingMonth().Data.OrderByDescending(t => t.MonthCount).FirstOrDefault().MonthNumber);
                int leastTraveledMonth = Convert.ToInt32(_ticketService.GetTicketTopSellingMonth().Data.OrderBy(t => t.MonthCount).FirstOrDefault().MonthNumber);

                lblLastOneMonthTicketSalesCount.Text = _transactionLogService.GetAll().Data.Where(t => t.TransactionNameId == 1 && (DateTime.Now - t.DateOfTransaction).TotalDays < 30).Count().ToString();
                lblLastOneMonthTotalMoney.Text = string.Format("{0:C}", _ticketService.GetAll().Data.Where(t => (DateTime.Now - t.DateTaken).TotalDays <= 30).Sum(ti => ti.Price)).ToString();
                lblLastOneMonthNewUsers.Text = _transactionLogService.GetAll().Data.Where(t => t.TransactionNameId == 6 && (DateTime.Now - t.DateOfTransaction).TotalDays < 30).Count().ToString();
                lblLastOneMonthMostLocation.Text = GetCityName(lastOneMonthFromCityId).ToString() + " - " + GetCityName(lastOneMonthDestinationCityId).ToString();
                lblLastOneMonthViewsCount.Text = _loginLogService.GetAll().Data.Where(t => (DateTime.Now - t.DateOfLogin).TotalDays < 30).Count().ToString();
                lblLeastTravelLocation.Text = GetCityName(leastTravelfromCityId).ToString() + " - " + GetCityName(leastTraveldestinationCityId).ToString();

                lblTotalTicketCount.Text = _transactionLogService.GetAll().Data.Where(t => t.TransactionNameId == 1).Count().ToString();
                lblTotalEarnMoney.Text = string.Format("{0:C}", _ticketService.GetAll().Data.Sum(t => t.Price)).ToString();
                lblPopularLocation.Text = GetCityName(fromCityId).ToString() + " - " + GetCityName(destinationCityId).ToString();
                lblTotalViews.Text = _loginLogService.GetAll().Data.Count().ToString();
                lblTotalVehicleCount.Text = _vehicleService.GetAll().Data.Count().ToString();
                lblTotalChauffeurCount.Text = _chauffeurService.GetAll().Data.Count().ToString();
                lblManGenderRate.Text = Math.Round((Convert.ToDecimal(100) * (_customerService.GetAll().Data.Where(g => g.GenderId == 1).Count())) / (_customerService.GetAll().Data.Count()), 2).ToString() + " %";
                lblWomanGenderRate.Text = Math.Round((Convert.ToDecimal(100) * (_customerService.GetAll().Data.Where(g => g.GenderId == 2).Count())) / (_customerService.GetAll().Data.Count()), 2).ToString() + " %";
                Months monthName = (Months)mostTraveledMonth - 1;
                lblTopSellingMonth.Text = monthName.ToString();
                Months leastMonth = (Months)leastTraveledMonth - 1;
                lblLeastTraveledMonth.Text = leastMonth.ToString();
                pnlStatistics.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        enum Months
        {
            Ocak,
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }

        private string GetCityName(int cityId)
        {
            string city = _cityService.GetById(cityId).Data.CityName.ToString();
            return city;
        }

        private void teChauffeurFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teChauffeurLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teChauffeurAddFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teChauffeurAddLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
