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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
            _securityQuestionService = InstanceFactory.GetInstance<ISecurityQuestionService>();
        }

        private ICustomerService _customerService;
        private ITransactionLogService _transactionLogService;
        private ISecurityQuestionService _securityQuestionService;
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            deDateOfBrith.Properties.MinValue = DateTime.Now.AddYears(-100);
            deDateOfBrith.Properties.MaxValue = DateTime.Now;
            deDateOfBrith.DateTime = DateTime.Now.AddYears(-30);

            foreach (var securityQuestion in _securityQuestionService.GetAll().Data)
            {
                cbeSecurityQuestion.Properties.Items.Add(securityQuestion.Question);
            }

        }
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void teFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void teLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnRegisterComplete_Click(object sender, EventArgs e)
        {
            teTC.Focus();
            try
            {
                if (teTC.Text.Length != 11 || teFirstName.Text.Length == 0 || teLastName.Text.Length == 0 || rgGender.SelectedIndex == -1 || teMail.Text.Length == 0 || tePhone.Text.Length <= 0 || tePassword.Text.Length == 0 || tePasswordConfirm.Text.Length == 0)
                {
                    MessageBox.Show("Lütfen tüm bilgilerinizi eksiksiz bir şekilde doldurun", "Eksik bilgiler var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tePassword.Text != tePasswordConfirm.Text)
                    {
                        MessageBox.Show("Parolalar birbirleriyle uyuşmuyor lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var tcVerify = _customerService.GetAll().Data.SingleOrDefault(t => t.TC == teTC.Text);
                        var emailVerify = _customerService.GetAll().Data.SingleOrDefault(m => m.Email == teMail.Text);
                        var phoneVerify = _customerService.GetAll().Data.SingleOrDefault(p => p.Phone == tePhone.Text);
                        if (tcVerify != null)
                        {
                            MessageBox.Show("TC kimlik numarası zaten sistemde kayıtlı", "TC Kimlik Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (emailVerify != null)
                        {
                            MessageBox.Show("Email adresi zaten sistemde kayıtlı", "Email Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (phoneVerify != null)
                        {
                            MessageBox.Show("Telefon numarası zaten sistemde kayıtlı", "Telefon numarası Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (!IsValidMail(teMail.Text))
                        {
                            MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Customer customer = new Customer();
                            customer.TC = teTC.Text;
                            customer.FirstName = teFirstName.Text;
                            customer.LastName = teLastName.Text;
                            customer.DateOfBrith = deDateOfBrith.DateTime;
                            customer.Email = teMail.Text;
                            customer.Phone = tePhone.Text;
                            customer.Password = tePassword.Text;
                            customer.SecurityQuestionId = Convert.ToInt32(cbeSecurityQuestion.SelectedIndex) + 1;
                            customer.SecurityQuestionAnswer = teSecurityQuestionAnswer.Text;
                            if (rgGender.SelectedIndex == 0)
                            {
                                customer.GenderId = 1;
                            }
                            else
                            {
                                customer.GenderId = 2;
                            }
                            _customerService.Add(customer);
                            TransactionLog transactionLog = new TransactionLog() { CustomerId = customer.Id, TransactionNameId = 6, DateOfTransaction = DateTime.Now };
                            _transactionLogService.Add(transactionLog);
                            MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı", "Kayıt tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Forms.Login loginForm = new Login();
                            loginForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void peClose_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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
