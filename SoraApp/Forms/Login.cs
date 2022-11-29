using Microsoft.EntityFrameworkCore;
using SoraApp.DataAccess;
using SoraApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SoraApp.Forms
{
    public partial class Login : Form
    {
        private ApplicationDbContext dbContext;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("----------- Login Form Loading -----------");
            dbContext = new ApplicationDbContext();

            // DEVONLY: Drop and re-create the database then seed data
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            new DatabaseSeeder(dbContext).PopulateDatabase();
        }

        private void QuitPb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = EmailTb.Text;
            string password = PasswordTb.Text;
            User? user = this.dbContext
                .Users
                .Where(user => user.Username == usernameOrEmail || user.Email == usernameOrEmail)
                .FirstOrDefault();
            if (user == null || user.Password != password)
            {
                MessageBox.Show("Cannot login with the specified credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // hide main form
            this.Hide();

            // show other form as dialog
            Index index = new Index(dbContext);
            index.ShowDialog();

            // close application on dialog quit
            this.Close();
        }
    }
}
