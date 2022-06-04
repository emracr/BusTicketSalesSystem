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
    public partial class ChauffeurHomePageForm : Form
    {
        public ChauffeurHomePageForm()
        {
            InitializeComponent();
            _chauffeurService = InstanceFactory.GetInstance<IChauffeurService>();
            _ticketService = InstanceFactory.GetInstance<ITicketService>();
        }
        private IChauffeurService _chauffeurService;
        private ITicketService _ticketService;
        private void ChauffeurHomePageForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = DateTime.Now.ToLongDateString();
                tmrClock.Start();
                var chauffeur = _chauffeurService.GetById(Forms.ChauffeurLoginForm.chauffeurId).Data;
                string upcomingExpedition = _ticketService.GetAll().Data.Where(t => t.VehicleId == chauffeur.Id && t.DepartureDate > DateTime.Now).OrderBy(t => t.DepartureDate).First().DepartureDate.ToLongDateString();
                string chauffeurName = chauffeur.FirstName + " " + chauffeur.LastName;
                lblTravelInfo.Text = "Sn. " + chauffeurName + " " + upcomingExpedition + " tarihinde yaklaşan seferiniz bulunmaktadır. Sefere çıkamadan önce yolcularımızın güvenliği için sefere çıkacağınız aracın bakımını yapmayı unutumayınız. Yolcularımızın konforlu bir şekilde seyahat etmesi için gerekli malzemeleri alınız. Sefere çıkmadan önce rapor alıp yolcularımızın biletlerini teğit ediniz. İyi yolculuklar.";

            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu, lütfen daha sonra tekrar deneyin", "Beklenmedik bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
