using Microsoft.EntityFrameworkCore;
using SoraApp.DataAccess;
using SoraApp.Entities;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SoraApp
{

    public partial class Index : Form
    {
        private ApplicationDbContext dbContext;

        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("----------- Index Form Loading -----------");
            dbContext = new ApplicationDbContext();
            // DEVONLY: Drop and re-create the database
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my alerting message!", "Alert Tilte", MessageBoxButtons.OK);
        }

    }
}
