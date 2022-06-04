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
    public partial class ChauffeurLoginForm : Form
    {
        public ChauffeurLoginForm()
        {
            InitializeComponent();
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
        }
        private IChauffeurService _chauffeurService;

        public static int chauffeurId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (teUserName.Text.Length > 0 && tePassword.Text.Length > 0)
                {
                    var chauffeurs = _chauffeurService.GetAll().Data.Where(c => c.UserName == teUserName.Text && c.Password == tePassword.Text).FirstOrDefault();
                    if (chauffeurs != null)
                    {
                        chauffeurId = chauffeurs.Id;
                        Forms.ChauffeurMainForm chauffeurMainForm = new ChauffeurMainForm();
                        chauffeurMainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya parola hatalı", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola boş bırakılamaz", "Kullanıcı adı veya parola eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void peClose_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ChauffeurLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
