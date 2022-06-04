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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private IAdminService _adminService;
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            var admin = _adminService.GetById(Forms.AdminLoginForm.adminId).Data;
            teFirstName.Text = admin.FirstName;
            teLastName.Text = admin.LastName;
            teMail.Text = admin.Mail;
            teUserName.Text = admin.UserName;

            pnlPasswordUpdate.Hide();
            pnlAddAdmin.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (teFirstName.Text.Length > 0 && teLastName.Text.Length > 0 && teMail.Text.Length > 0 && teUserName.Text.Length > 0)
                {
                    if (IsValidMail(teMail.Text))
                    {
                        var adminsUserName = _adminService.GetAll().Data.Where(a => a.Id != AdminLoginForm.adminId && a.UserName == teUserName.Text).Count();
                        var adminsMails = _adminService.GetAll().Data.Where(a => a.Id != AdminLoginForm.adminId && a.Mail == teMail.Text).Count();
                        if (adminsUserName <= 0)
                        {
                            if (adminsMails <= 0)
                            {
                                var admin = _adminService.GetById(Forms.AdminLoginForm.adminId).Data;
                                admin.FirstName = teFirstName.Text;
                                admin.LastName = teLastName.Text;
                                admin.Mail = teMail.Text;
                                admin.UserName = teUserName.Text;
                                _adminService.Update(admin);
                                MessageBox.Show("Profiliniz başarılı bir şekilde güncellendi", "Profilinz güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Email başka admin tarafından kullanılmaktadır", "Email zaten kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı başka admin tarafından kullanılmaktadır", "Kullanıcı adı zaten kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Eksik bilgiler var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPasswordUpdate_Click(object sender, EventArgs e)
        {
            ClanPasswordUpdateField();
            pnlPasswordUpdate.Show();
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tePasswordAvailable.Text.Length > 0 && tePasswordNew.Text.Length > 0 && tePasswordNewConfirm.Text.Length > 0)
                {
                    if (tePasswordNew.Text == tePasswordNewConfirm.Text)
                    {
                        var admin = _adminService.GetById(Forms.AdminLoginForm.adminId).Data;
                        if (tePasswordAvailable.Text == admin.Password)
                        {
                            admin.Password = tePasswordNew.Text;
                            _adminService.Update(admin);
                            MessageBox.Show("Parolanız başarılı bir şekilde güncellendi", "Parolanız güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pnlPasswordUpdate.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mevcut parola hatalı lütfen kontrol edin", "Mevcut parola hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar birbirleriyle eşleşmiyor lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Eksik bilgiler var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClanPasswordUpdateField()
        {
            tePasswordAvailable.Text = null;
            tePasswordNew.Text = null;
            tePasswordNewConfirm.Text = null;
        }
        private void lblAddAdmin_Click(object sender, EventArgs e)
        {
            pnlAddAdmin.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (teAddAdminFirstName.Text.Length > 0 && teAddAdminLastName.Text.Length > 0 && teAddAdminMail.Text.Length > 0 && teAddAdminUserName.Text.Length > 0)
                {
                    if (IsValidMail(teAddAdminMail.Text))
                    {
                        if (teAddAdminPassword.Text == teAddAdminPasswordConfirm.Text)
                        {
                            var adminsUserName = _adminService.GetAll().Data.Where(a => a.UserName == teAddAdminUserName.Text).Count();
                            var adminsMails = _adminService.GetAll().Data.Where(a => a.Mail == teAddAdminMail.Text).Count();
                            if (adminsUserName <= 0)
                            {
                                if (adminsMails <= 0)
                                {
                                    Admin admin = new Admin();
                                    admin.FirstName = teAddAdminFirstName.Text;
                                    admin.LastName = teAddAdminLastName.Text;
                                    admin.Mail = teAddAdminMail.Text;
                                    admin.UserName = teAddAdminUserName.Text;
                                    admin.Password = teAddAdminPassword.Text;
                                    _adminService.Add(admin);
                                    MessageBox.Show("Admin başarılı bir şekilde eklendi", "Admin eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    pnlAddAdmin.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Email başka admin tarafından kullanılmaktadır", "Email zaten kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı başka admin tarafından kullanılmaktadır", "Kullanıcı adı zaten kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parolalar birbirleriyle eşleşmiyor lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun", "Eksik bilgiler var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void teAddAdminFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teAddAdminLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
