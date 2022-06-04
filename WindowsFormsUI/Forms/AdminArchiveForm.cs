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
    public partial class AdminArchiveForm : Form
    {
        public AdminArchiveForm()
        {
            InitializeComponent();
            _deletedCustomerService = InstanceFactory.GetInstance<IDeletedCustomerService>();
            _deletedTicketService = InstanceFactory.GetInstance<IDeletedTicketService>();
        }
        private IDeletedCustomerService _deletedCustomerService;
        private IDeletedTicketService _deletedTicketService;
        private void AdminArchiveForm_Load(object sender, EventArgs e)
        {
            lblUsersCount.Text = _deletedCustomerService.GetAll().Data.Count.ToString();
            lblTicketCount.Text = _deletedTicketService.GetAll().Data.Count().ToString();
            pnlDeletedCustomers.Hide();
            pnlDeletedTickets.Hide();
        }
        private void pnlUsersDiv_Click(object sender, EventArgs e)
        {
            gcDeletedCustomers.DataSource = _deletedCustomerService.GetDeletedCustomerDetails().Data;
            pnlDeletedCustomers.Show();
        }

        private void pnlTicketsDiv_Click(object sender, EventArgs e)
        {
            gcTickets.DataSource = _deletedTicketService.GetDeletedTicketDetails().Data;
            pnlDeletedTickets.Show();
        }
    }
}
