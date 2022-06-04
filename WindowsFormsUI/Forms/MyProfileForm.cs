using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Forms
{
    public partial class MyProfileForm : Form
    {
        MainForm _mainForm;
        public MyProfileForm(MainForm mainFom)
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _transactionLogService = InstanceFactory.GetInstance<ITransactionLogService>();
            _mainForm = mainFom;
        }

        private ICustomerService _customerService;
        private ITransactionLogService _transactionLogService;
        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerService.GetById(Login.loginCustomerId).Data;
                GetCustomerInformation();
                ProfileImageControl();
                deDateOfBrith.Properties.MinValue = DateTime.Now.AddYears(-100);
                deDateOfBrith.Properties.MaxValue = DateTime.Now;
                pnlPasswordUpdate.Hide();
                btnProfileImageUpload.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProfileImageControl()
        {
            var customer = _customerService.GetById(Login.loginCustomerId).Data;
            if (customer.Image != null)
            {
                string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())).ToString() + @"\ProfileImages\" + customer.Image;
                peProfilePicture.Image = CropCircle(Image.FromFile(path));
                btnProfileImageUpload.Hide();
            }
            else
            {
                peProfilePicture.Image = global::WindowsFormsUI.Properties.Resources.profile_user;
                Point point = new Point();
                point.X = 120;
                point.Y = 7;
                btnProfileImage.Location = point;
                btnProfileImageRemove.Hide();
            }
        }
        private void GetCustomerInformation()
        {
            var customer = _customerService.GetById(Convert.ToInt32(Login.loginCustomerId)).Data;
            tbTC.Text = customer.TC;
            tbFirstName.Text = customer.FirstName;
            tbLastName.Text = customer.LastName;
            tbPhone.Text = customer.Phone;
            tbMail.Text = customer.Email;
            deDateOfBrith.DateTime = Convert.ToDateTime(customer.DateOfBrith);

            if (customer.GenderId == 1)
            {
                rgGender.SelectedIndex = 0;
            }
            else
            {
                rgGender.SelectedIndex = 1;
            }
        }
        private void btnPersonalInformationUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFirstName.Text.Length == 0 || tbLastName.Text.Length == 0 || tbMail.Text.Length == 0 || tbPhone.Text.Length != 10 || deDateOfBrith.Text.Length <= 3)
                {
                    MessageBox.Show("Lütfen tüm bilgilerinizi eksiksiz bir şekilde doldurun", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidMail(tbMail.Text))
                {
                    MessageBox.Show("Girdiğiniz Mail uyugun formatta değildir, lütfen kontrol ediniz.", "Mail format uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (EmailAlreadyExists(tbMail.Text))
                {
                    MessageBox.Show("Email adresi başkası tarafından kullanılıyor", "Email zaten kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PhoneNumberAlreadyExists(tbPhone.Text))
                {
                    MessageBox.Show("Telefon numarası başkası tarafından kullanılıyor", "Telefon numarası zaten kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var customer = _customerService.GetById(Convert.ToInt32(Login.loginCustomerId)).Data;
                    customer.FirstName = tbFirstName.Text;
                    customer.LastName = tbLastName.Text;
                    customer.Phone = tbPhone.Text;
                    customer.Email = tbMail.Text;
                    customer.DateOfBrith = deDateOfBrith.DateTime;
                    if (rgGender.SelectedIndex == 0)
                    {
                        customer.GenderId = 1;
                    }
                    else
                    {
                        customer.GenderId = 2;
                    }

                    _customerService.Update(customer);
                    TransactionLog transactionLog = new TransactionLog() { CustomerId = Forms.Login.loginCustomerId, TransactionNameId = 3, DateOfTransaction = DateTime.Now };
                    _transactionLogService.Add(transactionLog);
                    GetCustomerInformation();
                    _mainForm.lblUserName.Text = customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper();
                    MessageBox.Show("Değiştirmiş olduğunuz bilgiler doğrultusunda profiliniz güncellenmiştir", "Profil güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblGoPasswordUpdate_Click(object sender, EventArgs e)
        {
            pnlPasswordUpdate.Show();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOldPassword.Text.Length != 0 && tbNewPassword.Text.Length != 0 || tbNewPasswordConfirm.Text.Length != 0)
                {
                    var customer = _customerService.GetById(Convert.ToInt32(Login.loginCustomerId)).Data;
                    if (tbNewPassword.Text == tbNewPasswordConfirm.Text)
                    {
                        if (tbOldPassword.Text == customer.Password)
                        {
                            customer.Password = tbNewPassword.Text;
                            _customerService.Update(customer);
                            TransactionLog transactionLog = new TransactionLog() { CustomerId = Forms.Login.loginCustomerId, TransactionNameId = 4, DateOfTransaction = DateTime.Now };
                            _transactionLogService.Add(transactionLog);
                            MessageBox.Show("Parolanız başarılı bir şekilde değiştirildi", "Parola değiştirildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            ClearPasswordUpdateField();
                            pnlPasswordUpdate.Hide();
                            pnlPersonalInfo.Show();
                        }
                        else
                        {
                            MessageBox.Show("Mevcut parola hatalı, lütfen kontrol edin", "Mevcut parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar birbirleriyle uyuşmuyor, lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurun", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPasswordUpdateCancel_Click(object sender, EventArgs e)
        {
            ClearPasswordUpdateField();
            pnlPasswordUpdate.Hide();
            pnlPersonalInfo.Show();
        }
        private void ClearPasswordUpdateField()
        {
            tbOldPassword.Text = "";
            tbNewPassword.Text = "";
            tbNewPasswordConfirm.Text = "";
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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
        private bool PhoneNumberAlreadyExists(string phoneNumber)
        {
            var customers = _customerService.GetAll().Data.Where(c => c.Id != Login.loginCustomerId && c.Phone == phoneNumber).Count();
            if (customers > 0)
            {
                return true;
            }
            return false;
        }
        private bool EmailAlreadyExists(string email)
        {
            var customers = _customerService.GetAll().Data.Where(c => c.Id != Login.loginCustomerId && c.Email == email).Count();
            if (customers > 0)
            {
                return true;
            }
            return false;
        }
        string fileName;
        string customerTC;
        string imageType;
        private void btnProfileImage_Click(object sender, EventArgs e)
        {
            try
            {
                customerTC = _customerService.GetById(Login.loginCustomerId).Data.TC.ToString();
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg;*.jpeg|PNG|*.png", ValidateNames = true, Multiselect = false })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Image image = Image.FromFile(openFileDialog.FileName);
                        if (ImageFormat.Jpeg.Equals(image.RawFormat))
                        {
                            imageType = "jpg";
                        }
                        else if (ImageFormat.Png.Equals(image.RawFormat))
                        {
                            imageType = "png";
                        }

                        fileName = openFileDialog.FileName;
                        peProfilePicture.Image = CropCircle(Image.FromFile(fileName));
                        Point point = new Point();
                        point.X = 43;
                        point.Y = 7;
                        btnProfileImage.Location = point;
                        btnProfileImageRemove.Hide();
                        btnProfileImageUpload.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Image CropCircle(Image imgSource)
        {
            Image imgTarget = new Bitmap(imgSource.Width, imgSource.Height);
            Graphics g = Graphics.FromImage(imgTarget);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, imgTarget.Width, imgTarget.Height);
            g.SetClip(path);
            g.DrawImage(imgSource, 0, 0);

            return imgTarget;
        }

        private void btnProfileImageUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileImageRemove();

                string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())).ToString() + @"\ProfileImages\";

                File.Copy(fileName, Path.Combine(path, Path.GetFileName(customerTC) + "." + imageType), true);
                var customer = _customerService.GetById(Login.loginCustomerId).Data;
                customer.Image = customerTC + "." + imageType;
                _customerService.Update(customer);

                btnProfileImageUpload.Hide();
                btnProfileImageRemove.Show();

                MessageBox.Show("Profil resminiz başarılı bir şekilde kaydedildi", "Profil resmi kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProfileImageRemove_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Profil resminizi kaldırmak istiyor musunuz?", "Profil resmi silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (message == DialogResult.Yes)
                {
                    ProfileImageRemove();
                    peProfilePicture.Image = global::WindowsFormsUI.Properties.Resources.profile_user;
                    btnProfileImageRemove.Hide();
                    Point point = new Point();
                    point.X = 120;
                    point.Y = 7;
                    btnProfileImage.Location = point;
                    MessageBox.Show("Profil resminiz başarılı bir şekilde kaldırıldı", "Profil resmi kaldırıldı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
               
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Profil resminiz şu anda sistem tarafından kullanıldığı için silinemiyor, lütfen daha sonra tekrar deneyin", "Profil resmi şu anda silinemiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProfileImageRemove()
        {
            var customer = _customerService.GetById(Login.loginCustomerId).Data;
            string filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())).ToString() + @"\ProfileImages\" + customer.Image;
            if (File.Exists(filePath))
            {
                Image image = Image.FromFile(filePath);
                image.Dispose();
                File.Delete(filePath);
            }
            customer.Image = null;
            _customerService.Update(customer);
        }
    }
}
