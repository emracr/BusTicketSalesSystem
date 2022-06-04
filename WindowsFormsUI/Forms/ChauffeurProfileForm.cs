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
    public partial class ChauffeurProfileForm : Form
    {
        ChauffeurMainForm _chauffeurMainForm;
        public ChauffeurProfileForm(ChauffeurMainForm chauffeurMainForm)
        {
            InitializeComponent();
            _chauffeurMainForm = chauffeurMainForm;
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        private IChauffeurService _chauffeurService;
        private ICustomerService _customerService;
        private void ChauffeurProfileForm_Load(object sender, EventArgs e)
        {
            deDateOfBirth.Properties.MinValue = DateTime.Now.AddYears(-70);
            deDateOfBirth.Properties.MaxValue = DateTime.Now.AddYears(-15);

            var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
            teFirstName.Text = chauffeur.FirstName;
            teLastName.Text = chauffeur.LastName;
            tePhone.Text = chauffeur.Phone;
            deDateOfBirth.DateTime = chauffeur.DateOfBrith;
            teUserName.Text = chauffeur.UserName;

            pnlPasswordUpdate.Hide();

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (teFirstName.Text.Length > 0 && teLastName.Text.Length > 0 && tePhone.Text.Length == 10 && deDateOfBirth.Text.Length > 0 && teUserName.Text.Length > 0)
                {
                    var chauffeurs = _chauffeurService.GetAll().Data.Where(c => c.Id != ChauffeurLoginForm.chauffeurId && c.UserName == teUserName.Text).FirstOrDefault();
                    var chauffeursPhoneControl = _chauffeurService.GetAll().Data.Where(c => c.Id != ChauffeurLoginForm.chauffeurId && c.Phone == tePhone.Text).FirstOrDefault();
                    var chauffeursPhoneControl2 = _customerService.GetAll().Data.Where(c => c.Phone == tePhone.Text).FirstOrDefault();
                    if (chauffeurs == null)
                    {
                        if (chauffeursPhoneControl == null && chauffeursPhoneControl2 == null)
                        {
                            var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
                            chauffeur.FirstName = teFirstName.Text;
                            chauffeur.LastName = teLastName.Text;
                            chauffeur.Phone = tePhone.Text;
                            chauffeur.DateOfBrith = deDateOfBirth.DateTime;
                            chauffeur.UserName = teUserName.Text;
                            _chauffeurService.Update(chauffeur);
                            _chauffeurMainForm.lblUserName.Text = chauffeur.FirstName + " " + chauffeur.LastName;
                            MessageBox.Show("Profiliniz başarılı bir şekilde güncellenmiştir", "Profil güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Bu telefon numarsı başka biri tarafından kullanılıyor, lütfen başka bir telefon numarası deneyiniz", "Telefon numarası kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı başka biri tarafından kullanılıyor, lütfen başka bir kullanıcı adı deneyiniz", "Kullanıcı adı kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurun", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void lblPasswordUpdate_Click(object sender, EventArgs e)
        {
            CleanUpdatePasswordField();
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
                        var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
                        if (tePasswordAvailable.Text == chauffeur.Password)
                        {
                            chauffeur.Password = tePasswordNew.Text;
                            _chauffeurService.Update(chauffeur);
                            MessageBox.Show("Parolanız başarılı bir şekilde güncellenmiştir", "Parolanız güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            pnlPasswordUpdate.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mevcut parolanız hatalı, lütfen kontrol edin", "Mevcut parola hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar birbirleriyle uyuşmuyor, lütfen kontrol edin", "Parola uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz bir şekilde doldurun", "Eksik alanlar var", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CleanUpdatePasswordField()
        {
            tePasswordAvailable.Text = null;
            tePasswordNew.Text = null;
            tePasswordNewConfirm.Text = null;
        }
    }
}
