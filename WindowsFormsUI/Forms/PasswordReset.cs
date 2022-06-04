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
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _securityQuestionService = InstanceFactory.GetInstance<ISecurityQuestionService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
        }

        private ICustomerService _customerService;
        private ISecurityQuestionService _securityQuestionService;
        private ITransactionLogService _transactionLogService;
        private void PasswordReset_Load(object sender, EventArgs e)
        {
            pnlSecurityQuestion.Hide();
            pnlNewPassword.Hide();
        }

        private void PasswordReset_Shown(object sender, EventArgs e)
        {
            teMail.Focus();
        }

        private int customerId;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (teMail.Text.Length > 0)
                {
                    Customer customer = _customerService.GetAll().Data.Where(c => c.Email == teMail.Text).FirstOrDefault();

                    if (!IsValidMail(teMail.Text))
                    {
                        MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (customer != null)
                    {
                        customerId = customer.Id;
                        var question = _securityQuestionService.GetById(Convert.ToInt32(customer.SecurityQuestionId)).Data;
                        lblSecurityQuestion.Text = question.Question.ToString();
                        pnlSecurityQuestion.Show();
                        teSecurityQuestionAnswer.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Email sistemde kayıtlı değil", "Email bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Email boş bırakılamaz lütfen bir email girin", "Email boş bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNextNewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerService.GetById(customerId).Data;
                if (teSecurityQuestionAnswer.Text.Length > 0)
                {
                    if (teSecurityQuestionAnswer.Text == customer.SecurityQuestionAnswer)
                    {
                        pnlNewPassword.Show();
                        teNewPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik sorusunun cevabı hatalı", "Hatalı cevap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Güvenlik sorusunun cevabı boş bırakılamaz lütfen bir cevap girin", "Güvenlik sorusu boş bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PasswordReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void peClose_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (teNewPassword.Text.Length > 0 && teNewPasswordConfirm.Text.Length > 0)
                {
                    if (teNewPassword.Text == teNewPasswordConfirm.Text)
                    {
                        var customer = _customerService.GetById(customerId).Data;
                        customer.Password = teNewPassword.Text;
                        _customerService.Update(customer);
                        TransactionLog transactionLog = new TransactionLog() { CustomerId = customer.Id, TransactionNameId = 8, DateOfTransaction = DateTime.Now };
                        _transactionLogService.Add(transactionLog);
                        MessageBox.Show("Parolanız başarılı bir şekilde kurtarıldı", "Parola kurtarıldı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Parolalar birbirleriyle uyuşmuyor lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
