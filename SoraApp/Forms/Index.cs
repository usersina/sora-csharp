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

        public Index(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

            InitializeComponent();
            TargeterPanel.Height = HomeBtn.Height;
            TargeterPanel.Top = HomeBtn.Top;
            SubHeaderPanel.Height = 71;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("----------- Index Form Loading -----------");
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            TargeterPanel.Height = HomeBtn.Height;
            TargeterPanel.Top = HomeBtn.Top;
            this.TabControl.SelectedTab = HomeTabPage;
        }

        private void CollectionBtn_Click(object sender, EventArgs e)
        {
            TargeterPanel.Height = CollectionBtn.Height;
            TargeterPanel.Top = CollectionBtn.Top;
            this.TabControl.SelectedTab = CollectionTabPage;
        }

        private void SavedBtn_Click(object sender, EventArgs e)
        {
            TargeterPanel.Height = SavedBtn.Height;
            TargeterPanel.Top = SavedBtn.Top;
            this.TabControl.SelectedTab = SavedTabPage;
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            TargeterPanel.Height = ProfileBtn.Height;
            TargeterPanel.Top = ProfileBtn.Top;
            this.TabControl.SelectedTab = ProfileTabPage;
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
