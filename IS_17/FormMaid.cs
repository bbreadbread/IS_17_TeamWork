using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_17
{
    public partial class FormMaid : Form
    {
        FormMaid_Rooms rooms;
        FormMaid_Profile profile;
        public static int IdSelected { get; private set; }
        public static string NameSelected { get; private set; }
        public static string SurnameSelected { get; private set; }
        public static string MailSelected { get; private set; }
        public FormMaid(int userID, string nameSelected, string surnameSelected, string mail)
        {
            IdSelected = userID;
            NameSelected = nameSelected;
            SurnameSelected = surnameSelected;
            MailSelected = mail;
            InitializeComponent();

            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button_EditData.FlatStyle = FlatStyle.Flat;
            button_EditData.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button_EditPassword.FlatStyle = FlatStyle.Flat;
            button_EditPassword.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);
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

        private void button_EditPassword_Click(object sender, EventArgs e)
        {
            FormMaid_Profile.typeDialogForm = false;
            profile = new FormMaid_Profile();
            DialogResult result = profile.ShowDialog();

            if (result == DialogResult.OK)
            {
                
            }
        }

        private void button_EditData_Click(object sender, EventArgs e)
        {
            FormMaid_Profile.typeDialogForm = true;
            profile = new FormMaid_Profile();
            DialogResult result = profile.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////не имеет смысла
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();
        }

        bool menuExpand = false;

        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuConteiner.Height += 10;
                if (menuConteiner.Height >= 165)
                {
                    menuTransition1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuConteiner.Height -= 10;
                if (menuConteiner.Height <= 48)
                {
                    menuTransition1.Stop();
                    menuExpand = false;
                }
            }
        }

        private void FormMaid_Load(object sender, EventArgs e)
        {
            if (rooms == null)
            {
                rooms = new FormMaid_Rooms();
                rooms.FormClosed += Rooms_FormClosed1;
                rooms.MdiParent = this;
                rooms.Dock = DockStyle.Fill;
                rooms.Show();
            }
            else
            {
                rooms.Activate();
            }
        }

        private void Rooms_FormClosed1(object? sender, FormClosedEventArgs e)
        {
            rooms = null;
        }
    }
}
