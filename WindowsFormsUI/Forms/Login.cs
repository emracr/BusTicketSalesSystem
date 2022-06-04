using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _loginLogService = InstanceFactory.GetInstance<ILoginLogService>();
        }

        private ICustomerService _customerService;
        private ILoginLogService _loginLogService;
        private void Login_Load(object sender, EventArgs e)
        {
            pePasswordHide.Visible = false;
        }

        public static int loginCustomerId;
        public static int loginLogId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (teEmail.Text.Length > 0 && tePassword.Text.Length > 0)
                {
                    var customer = _customerService.GetAll().Data.SingleOrDefault(c => c.Email == teEmail.Text && c.Password == tePassword.Text);
                    if (!IsValidMail(teEmail.Text))
                    {
                        MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (customer != null)
                    {
                        loginCustomerId = customer.Id;
                        LoginLog loginLog = new LoginLog() { CustomerId = customer.Id, DateOfLogin = System.DateTime.Now };
                        _loginLogService.Add(loginLog);
                        loginLogId = loginLog.Id;
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email veya parola hatalı lütfen tekrar deneyin", "Hatalı email veya parola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email veya parola boş bırakılamaz", "Email veya parola eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool passwordVisibleHide = true;
        private void pePasswordShow_Click(object sender, EventArgs e)
        {
            if (passwordVisibleHide)
            {
                tePassword.Properties.UseSystemPasswordChar = false;
                passwordVisibleHide = false;
                pePasswordHide.Visible = true;
                pePasswordShow.Visible = false;
            }
        }
        private void pePasswordHide_Click(object sender, EventArgs e)
        {
            if (!passwordVisibleHide)
            {
                tePassword.Properties.UseSystemPasswordChar = true;
                passwordVisibleHide = true;
                pePasswordHide.Visible = false;
                pePasswordShow.Visible = true;
            }
        }

        private void peClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            teEmail.Focus();

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Forms.RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void teEmail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.Alt && e.KeyCode == Keys.A)
            {
                Forms.AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
                this.Hide();
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.S)
            {
                Forms.ChauffeurLoginForm chauffeurLoginForm = new ChauffeurLoginForm();
                chauffeurLoginForm.Show();
                this.Hide();
            }

        }

        private void lblForgotMyPassword_Click(object sender, EventArgs e)
        {
            Forms.PasswordReset passwordReset = new PasswordReset();
            passwordReset.Show();
            this.Hide();
        }
        public bool IsValidMail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
