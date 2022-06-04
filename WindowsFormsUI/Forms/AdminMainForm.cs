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
    public partial class AdminMainForm : Form
    {
        private Form activeForm;
        public AdminMainForm()
        {
            InitializeComponent();
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminHomePageForm());
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminHomePageForm());
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminArchiveForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminProfile());
        }
    }
}
