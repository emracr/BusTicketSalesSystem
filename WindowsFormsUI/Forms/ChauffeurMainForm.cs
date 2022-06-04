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
    public partial class ChauffeurMainForm : Form
    {
        private Form activeForm;
        public ChauffeurMainForm()
        {
            InitializeComponent();
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
        }

        private IChauffeurService _chauffeurService;
        private void ChauffeurMainForm_Load(object sender, EventArgs e)
        {
            var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
            lblUserName.Text = chauffeur.FirstName + " " + chauffeur.LastName;
            OpenChildForm(new Forms.ChauffeurHomePageForm());
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

        private void ChauffeurMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ChauffeurHomePageForm());
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ChauffeurCustomerTicketsForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ChauffeurProfileForm(this));
        }
    }
}
