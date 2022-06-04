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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private IAdminService _adminService;
        private void peClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int adminId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (teUserName.Text.Length == 0 || tePassword.Text.Length == 0)
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı ve parolarnızı eksiksiz girin", "Kullanıcı adı veya parola eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var admin = _adminService.GetAll().Data.SingleOrDefault(a => a.UserName == teUserName.Text && a.Password == tePassword.Text);
                    if (admin != null)
                    {
                        Forms.AdminMainForm adminMainForm = new AdminMainForm();
                        adminId = admin.Id;
                        adminMainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya parola hatalı", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
