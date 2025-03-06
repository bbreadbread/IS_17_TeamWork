using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_17
{
    public partial class FormMaid : Form
    {
        FormMaid_Rooms rooms;
        FormMaid_Profile profile;
        public FormMaid()
        {
            InitializeComponent();
        }

        private void btnHum_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {

                sidebar.Width += 5;
                if (sidebar.Width >= 258)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 62)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
        }

        private void buttonCheckRooms_Click(object sender, EventArgs e)
        {
            if (rooms == null)
            {
                rooms = new FormMaid_Rooms();
                rooms.FormClosed += Rooms_FormClosed;
                rooms.MdiParent = this;
                rooms.Dock = DockStyle.Fill;
                rooms.Show();
            }
            else rooms.Activate();

        }

        private void Rooms_FormClosed(object? sender, FormClosedEventArgs e)
        {
            rooms = null;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                profile = new FormMaid_Profile();
                profile.FormClosed += Profile_FormClosed;
                profile.MdiParent = this;
                profile.Dock = DockStyle.Fill;
                profile.Show();
            }
            else profile.Activate();
        }

        private void Profile_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profile = null;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Authoriz authoriz = new Authoriz();
            this.Hide();
            authoriz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isDragging = false;
        private Point startPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = panel1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-startPoint.X, -startPoint.Y);
                this.Location = newPoint;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
