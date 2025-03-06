using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IS_17
{
    public partial class FormAdmin : Form
    {
        FormAdmin_Workers_Create formAdmin_Workers_Create;
        FormAdmin_Workers_Edit formAdmin_Workers_Edit;

        FormAdmin_Rooms_Create formAdmin_Rooms_Create;
        FormAdmin_Rooms_Edit formAdmin_Rooms_Edit;

        FormAdmin_WhoIsWhere formAdmin_WhoIsWhere;

        public FormAdmin()
        {
            InitializeComponent();

            menu.FlatStyle = FlatStyle.Flat; 
            menu.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67); 

            button_CreateWorkers.FlatStyle = FlatStyle.Flat;
            button_CreateWorkers.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button_EditWorkers.FlatStyle = FlatStyle.Flat;
            button_EditWorkers.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            menu2.FlatStyle = FlatStyle.Flat;
            menu2.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button_CreateRooms.FlatStyle = FlatStyle.Flat;
            button_CreateRooms.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button_EditRooms.FlatStyle = FlatStyle.Flat;
            button_EditRooms.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);


            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (formAdmin_Workers_Create == null)
            {
                formAdmin_Workers_Create = new FormAdmin_Workers_Create();
                formAdmin_Workers_Create.FormClosed += FormAdmin_Workers_Create_FormClosed;
                formAdmin_Workers_Create.MdiParent = this;
                formAdmin_Workers_Create.Dock = DockStyle.Fill;
                formAdmin_Workers_Create.Show();
            }
            else
            {
                formAdmin_Workers_Create.Activate();
            }
        }
        //открывашка основного меню
        //открывашка основного меню
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
                    button_CreateWorkers.Width = sidebar.Width;
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

        //открывашка меню СОТРУДНИКИ
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

        //открывашка меню НОМЕРА
        private void menu2_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }

        bool menuExpand2 = false;
        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuConteiner2.Height += 10;
                if (menuConteiner2.Height >= 165)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuConteiner2.Height -= 10;
                if (menuConteiner2.Height <= 62)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }
        private void button_CreateWorkers_Click(object sender, EventArgs e)
        {
            if (formAdmin_Workers_Create == null)
            {
                formAdmin_Workers_Create = new FormAdmin_Workers_Create();
                formAdmin_Workers_Create.FormClosed += FormAdmin_Workers_Create_FormClosed;
                formAdmin_Workers_Create.MdiParent = this;
                formAdmin_Workers_Create.Dock = DockStyle.Fill;
                formAdmin_Workers_Create.Show();
            }
            else
            {
                formAdmin_Workers_Create.Activate();
            }
        }

        private void FormAdmin_Workers_Create_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAdmin_Workers_Create = null;
        }

        private void button_EditWorkers_Click(object sender, EventArgs e)
        {
            if (formAdmin_Workers_Edit == null)
            {
                formAdmin_Workers_Edit = new FormAdmin_Workers_Edit();
                formAdmin_Workers_Edit.FormClosed += FormAdmin_Workers_Edit_FormClosed;
                formAdmin_Workers_Edit.MdiParent = this;
                formAdmin_Workers_Edit.Dock = DockStyle.Fill;
                formAdmin_Workers_Edit.Show();
            }
            else
            {
                formAdmin_Workers_Edit.Activate();
            }
        }

        private void FormAdmin_Workers_Edit_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAdmin_Workers_Edit = null;
        }

        private void button_CreateRooms_Click(object sender, EventArgs e)
        {
            if (formAdmin_Rooms_Create == null)
            {
                formAdmin_Rooms_Create = new FormAdmin_Rooms_Create();
                formAdmin_Rooms_Create.FormClosed += FormAdmin_Rooms_Create_FormClosed;
                formAdmin_Rooms_Create.MdiParent = this;
                formAdmin_Rooms_Create.Dock = DockStyle.Fill;
                formAdmin_Rooms_Create.Show();
            }
            else
            {
                formAdmin_Rooms_Create.Activate();
            }
        }

        private void FormAdmin_Rooms_Create_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAdmin_Rooms_Create = null;
        }

        private void button_EditRooms_Click(object sender, EventArgs e)
        {
            if (formAdmin_Rooms_Edit == null)
            {
                formAdmin_Rooms_Edit = new FormAdmin_Rooms_Edit();
                formAdmin_Rooms_Edit.FormClosed += FormAdmin_Rooms_Edit_FormClosed;
                formAdmin_Rooms_Edit.MdiParent = this;
                formAdmin_Rooms_Edit.Dock = DockStyle.Fill;
                formAdmin_Rooms_Edit.Show();
            }
            else
            {
                formAdmin_Rooms_Edit.Activate();
            }
        }

        private void FormAdmin_Rooms_Edit_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAdmin_Rooms_Edit = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (formAdmin_WhoIsWhere == null)
            {
                formAdmin_WhoIsWhere = new FormAdmin_WhoIsWhere();
                formAdmin_WhoIsWhere.FormClosed += FormAdmin_WhoIsWhere_FormClosed;
                formAdmin_WhoIsWhere.MdiParent = this;
                formAdmin_WhoIsWhere.Dock = DockStyle.Fill;
                formAdmin_WhoIsWhere.Show();
            }
            else
            {
                formAdmin_WhoIsWhere.Activate();
            }
        }

        private void FormAdmin_WhoIsWhere_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAdmin_WhoIsWhere = null;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Authoriz authoriz = new Authoriz();
            this.Hide();
            authoriz.Show();
        }
    }
}

