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

        // Moving the window
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Index()
        {
            InitializeComponent();
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            //firstCustomControl1.BringToFront();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("----------- Index Form Loading -----------");
            dbContext = new ApplicationDbContext();
            // DEVONLY: Drop and re-create the database
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            //firstCustomControl1.BringToFront();
        }

        private void CollectionBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CollectionBtn.Height;
            SidePanel.Top = CollectionBtn.Top;
            //mySecondCustmControl1.BringToFront();
        }

        private void SavedBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SavedBtn.Height;
            SidePanel.Top = SavedBtn.Top;
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ProfileBtn.Height;
            SidePanel.Top = ProfileBtn.Top;
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void QuitPb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
