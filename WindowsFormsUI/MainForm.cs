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
using WindowsFormsUI.Forms;

namespace WindowsFormsUI
{
    public partial class MainForm : Form
    {

        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _loginLogService = InstanceFactory.GetInstance<ILoginLogService>();
        }

        private ICustomerService _customerService;
        private ILoginLogService _loginLogService;
        private void MainForm_Load(object sender, EventArgs e)
        {
            var customer = _customerService.GetById(Login.loginCustomerId).Data;
            lblUserName.Text = customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper();
            OpenChildForm(new Forms.HomePageForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void LoginLogged()
        {
            var log = _loginLogService.GetById(Forms.Login.loginLogId).Data;
            log.DateOfLogout = DateTime.Now;
            _loginLogService.Update(log);
            Application.Exit();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginLogged();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginLogged();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomePageForm());
        }

        private void btnGetTicket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GetTicketForm());
        }

        private void btnMyTicktes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MyTicketsForm());
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MyProfileForm(this));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MyProfileForm(this));
        }
    }
}
