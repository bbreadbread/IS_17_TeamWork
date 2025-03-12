using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace IS_17
{
    public partial class FormZavhoz : Form
    {
        //Data Source=DESKTOP-60C99SS\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False
        //Эту строчку нужно будет заменить когда будете показывать проект!
        string allconect = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";

        public FormZavhoz()
        {
            InitializeComponent();

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            menu.FlatStyle = FlatStyle.Flat;
            menu.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.FromArgb(29, 29, 67);

        }


        int tablee = 0;
        void postupdate()
        {
            PostList.Clear();
            string connect = allconect;
            string query = $"SELECT TOP (1000) [ID_Поставщика]\r\n      ,[Название компании]\r\n      ,[Телефон]\r\n      ,[Адрес]\r\n      ,[Категория]\r\n  FROM [HotelDB].[dbo].[Поставщики]";

            using (SqlConnection connect1 = new SqlConnection(connect))
            {
                try
                {
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        post f = new post();
                        f.namepost = reader["Название компании"].ToString();
                        f.idpost = reader["ID_Поставщика"].ToString();
                        f.phone = reader["Телефон"].ToString();
                        f.email = reader["Адрес"].ToString();
                        f.category = reader["Категория"].ToString();
                        PostList.Add(f);
                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }
        void Inventupdate()
        {
            if (textBox1.Text != "")
            {
                string jh = textBox1.Text;
                textBox1.Text = "";
                textBox1.Text = jh;
                return;
            }
            InventList.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("1", "Название");
            dataGridView1.Columns.Add("2", "Общее кол-во");
            dataGridView1.Columns.Add("3", "Кол-во на складе");
            dataGridView1.Columns.Add("4", "Кол-во повреждённых");
            dataGridView1.Columns.Add("5", "поставщик");
            dataGridView1.Columns.Add("6", "цена");
            dataGridView1.Columns.Add("7", "id");


            string connect = allconect;
            string query = $"SELECT TOP (1000) [ID_Инвертарь]\r\n      ,[Название предмета]\r\n      ,[Общее кол-во]\r\n      ,[Кол-во на складе]\r\n      ,[Кол-во поврежденных]\r\n      ,[ID_Поставщика]\r\n      ,[Цена шт.]\r\n  FROM [HotelDB].[dbo].[Инвентарь]\r\n";

            using (SqlConnection connect1 = new SqlConnection(connect))
            {
                try
                {
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        invent f = new invent();
                        f.idinvent = reader["ID_Инвертарь"].ToString();
                        f.name = reader["Название предмета"].ToString();
                        f.allcount = reader["Общее кол-во"].ToString();
                        f.count = reader["Кол-во на складе"].ToString();
                        f.defectcount = reader["Кол-во поврежденных"].ToString();
                        f.idpost = reader["ID_Поставщика"].ToString();
                        f.price = reader["Цена шт."].ToString();
                        InventList.Add(f);
                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }

            using (SqlConnection connect2 = new SqlConnection(connect))
            {
                connect2.Open();
                for (int i = 0; i < InventList.Count; i++)
                {
                    string q = $"SELECT Поставщики.[Название компании] FROM Поставщики JOIN Инвентарь ON Поставщики.ID_Поставщика = Инвентарь.ID_Поставщика WHERE Поставщики.ID_Поставщика = {InventList[i].idpost}";
                    SqlCommand command1 = new SqlCommand(q, connect2);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {

                        InventList[i].namepost = reader1["Название компании"].ToString();

                    }
                    reader1.Close();
                }
            }
            for (int i = 0; i < InventList.Count; i++)
            {
                dataGridView1.Rows.Add(InventList[i].name, InventList[i].allcount, InventList[i].count, InventList[i].defectcount, InventList[i].namepost, InventList[i].price, InventList[i].idinvent);
            }
            dataGridView1.Visible = true;
            totable();
        }
        private void FormZavhoz_Load(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button4.Visible = true;
            panel1.Controls.Clear();
            panel1.Enabled = true;
            panel1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            tablee = 1;
            Inventupdate();
            postupdate();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (tablee == 1)
                {
                    try
                    {
                        if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
                        {
                            panel1.Controls.Clear();

                            int currentY = 0; // Текущая Y-координата
                            int verticalPadding = 10; // Отступ между элементами

                            // Создание и добавление меток
                            Label f = new Label();
                            f.Location = new Point(3, currentY);
                            f.Text = "Название:";
                            f.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f);
                            currentY += f.Height + verticalPadding; // Обновляем Y-координату для следующего элемента

                            Label f1 = new Label();
                            f1.Location = new Point(3, currentY);
                            f1.Text = "Общее кол-во:";
                            f1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f1);
                            currentY += f1.Height + verticalPadding; // Обновляем Y-координату

                            Label f2 = new Label();
                            f2.Location = new Point(3, currentY);
                            f2.Text = "Кол-во на складе:";
                            f2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f2);
                            currentY += f2.Height + verticalPadding; // Обновляем Y-координату

                            Label f3 = new Label();
                            f3.Location = new Point(3, currentY);
                            f3.Text = "Кол-во повреждённых:";
                            f3.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f3);
                            currentY += f3.Height + verticalPadding; // Обновляем Y-координату

                            Label f4 = new Label();
                            f4.Location = new Point(3, currentY);
                            f4.Text = "Поставщик:";
                            f4.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f4);
                            currentY += f4.Height + verticalPadding; // Обновляем Y-координату

                            Label f5 = new Label();
                            f5.Location = new Point(3, currentY);
                            f5.Text = "Цена:";
                            f5.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f5);
                            currentY += f5.Height + verticalPadding; // Обновляем Y-координату

                            Label f6 = new Label();
                            f6.Location = new Point(3, currentY);
                            f6.Text = "Кол-во для покупки:";
                            f6.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            panel1.Controls.Add(f6);
                            currentY += f6.Height + verticalPadding; // Обновляем Y-координату

                            // Создание и добавление текстовых полей
                            TextBox a = new TextBox();
                            a.Location = new Point(3, currentY);
                            panel1.Controls.Add(a);
                            currentY += a.Height + verticalPadding; // Обновляем Y-координату

                            TextBox a2 = new TextBox();
                            a2.Location = new Point(3, currentY);
                            panel1.Controls.Add(a2);
                            currentY += a2.Height + verticalPadding; // Обновляем Y-координату

                            TextBox a3 = new TextBox();
                            a3.Location = new Point(3, currentY);
                            panel1.Controls.Add(a3);
                            currentY += a3.Height + verticalPadding; // Обновляем Y-координату

                            TextBox a4 = new TextBox();
                            a4.Location = new Point(3, currentY);
                            panel1.Controls.Add(a4);
                            currentY += a4.Height + verticalPadding; // Обновляем Y-координату

                            ComboBox b = new ComboBox();
                            b.Location = new Point(3, currentY);
                            panel1.Controls.Add(b);
                            currentY += b.Height + verticalPadding; // Обновляем Y-координату

                            TextBox a5 = new TextBox();
                            a5.Location = new Point(3, currentY);
                            panel1.Controls.Add(a5);
                            currentY += a5.Height + verticalPadding; // Обновляем Y-координату

                            NumericUpDown c = new NumericUpDown();
                            c.Location = new Point(3, currentY);
                            panel1.Controls.Add(c);
                            currentY += c.Height + verticalPadding; // Обновляем Y-координату

                            // Создание и добавление кнопок
                            Button d = new Button();
                            d.Location = new Point(0, currentY);
                            d.Text = "Купить";
                            d.Size = new Size(a.Size.Width + 23, a.Size.Height + 10);
                            panel1.Controls.Add(d);
                            currentY += d.Height + verticalPadding; // Обновляем Y-координату

                            Button d1 = new Button();
                            d1.Location = new Point(0, currentY);
                            d1.Size = new Size(a.Size.Width + 23, a.Size.Height + 10);
                            d1.Text = "Сохранить";
                            d1.Click += new EventHandler(save);
                            panel1.Controls.Add(d1);
                            currentY += d1.Height + verticalPadding; // Обновляем Y-координату

                            Button d3 = new Button();
                            d3.Location = new Point(0, currentY);
                            d3.Text = "Удалить";
                            d3.Size = new Size(a.Size.Width + 23, a.Size.Height + 10);
                            d3.Click += new EventHandler(deleteinvent);
                            panel1.Controls.Add(d3);
                            currentY += d3.Height + verticalPadding; // Обновляем Y-координату

                            Button d4 = new Button();
                            d4.Location = new Point(0, currentY);
                            d4.Text = "Добавить";
                            d4.Size = new Size(a.Size.Width + 23, a.Size.Height + 10);
                            d4.Click += new EventHandler(insertinvent);
                            panel1.Controls.Add(d4);

                            // Установка стилей для кнопок
                            Color buttonColor = Color.FromArgb(29, 29, 67);
                            d.BackColor = buttonColor;
                            d1.BackColor = buttonColor;
                            d3.BackColor = buttonColor;
                            d4.BackColor = buttonColor;

                            Font buttonFont = new Font("Century Gothic", 9, FontStyle.Bold);
                            d.Font = buttonFont;
                            d1.Font = buttonFont;
                            d3.Font = buttonFont;
                            d4.Font = buttonFont;

                            /////
                            panel1.Controls.Add(a);
                            panel1.Controls.Add(a2);
                            panel1.Controls.Add(a3);
                            panel1.Controls.Add(a4);
                            panel1.Controls.Add(b);
                            panel1.Controls.Add(a5);
                            panel1.Controls.Add(c);
                            panel1.Controls.Add(d);
                            panel1.Controls.Add(d1);
                            panel1.Controls.Add(d3);
                            panel1.Controls.Add(d4);
                            panel1.Controls.Add(f);
                            panel1.Controls.Add(f1);
                            panel1.Controls.Add(f2);
                            panel1.Controls.Add(f3);
                            panel1.Controls.Add(f4);
                            panel1.Controls.Add(f5);
                            panel1.Controls.Add(f6);
                            panel1.Visible = true;
                            string connect = allconect;
                            string query = $"SELECT TOP (1000) [Название компании]\r\n  FROM [HotelDB].[dbo].[Поставщики]\r\n";

                            using (SqlConnection connect1 = new SqlConnection(connect))
                            {
                                try
                                {
                                    connect1.Open();
                                    int index = 0;
                                    SqlCommand command = new SqlCommand(query, connect1);
                                    SqlDataReader reader = command.ExecuteReader();

                                    while (reader.Read())
                                    {
                                        b.Items.Add(reader["Название компании"].ToString());
                                    }
                                    command.Dispose();
                                    reader.Close();
                                    connect1.Close();
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                                }
                            }

                        }
                        else
                        {
                            panel1.Controls.Clear();
                            TextBox a = new TextBox();
                            a.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                            a.Location = new Point(3, 20);
                            TextBox a2 = new TextBox();
                            a2.Location = new Point(3, a.Size.Height * 1 + 20 * 2);
                            a2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                            TextBox a3 = new TextBox();
                            a3.Location = new Point(3, a.Size.Height * 2 + 20 * 3);
                            a3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                            TextBox a4 = new TextBox();
                            a4.Location = new Point(3, a.Size.Height * 3 + 20 * 4);
                            a4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                            ComboBox b = new ComboBox();
                            b.Location = new Point(3, a.Size.Height * 4 + 20 * 5);
                            b.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                            TextBox a5 = new TextBox();
                            a5.Location = new Point(3, a.Size.Height * 5 + 20 * 6);
                            a5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                            NumericUpDown c = new NumericUpDown();
                            c.Location = new Point(3, a.Size.Height * 6 + 20 * 7);

                            Button d = new Button();
                            d.Location = new Point(0, a.Size.Height * 6 + 20 * 9 - 10);
                            d.Text = "Купить";
                            d.Size = new Size(a.Size.Width, a.Size.Height);
                            d.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                            d.Click += new EventHandler(otchet);

                            // d.Click += new EventHandler(save);
                            Button d1 = new Button();
                            d1.Location = new Point(0, a.Size.Height * 8 + 20 * 9 - 25);
                            d1.Size = new Size(a.Size.Width, a.Size.Height);
                            d1.Text = "Сохранить";
                            d1.Click += new EventHandler(save);
                            d1.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                            Button d3 = new Button();
                            d3.Location = new Point(0, a.Size.Height * 9 + 20 * 10 - 33);
                            d3.Text = "Удалить";
                            d3.Size = new Size(a.Size.Width, a.Size.Height);
                            d3.Click += new EventHandler(deleteinvent);
                            d3.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                            Button d4 = new Button();
                            d4.Location = new Point(0, a.Size.Height * 10 + 20 * 11 - 41);
                            d4.Text = "Добавить";
                            d4.Size = new Size(a.Size.Width, a.Size.Height);
                            d4.Click += new EventHandler(insertinvent);
                            d4.Font = new Font("Century Gothic", 9, FontStyle.Bold);

                            btn = d1;
                            s = c;
                            aa = a;
                            aa2 = a2;
                            aa3 = a3;
                            aa4 = a4;
                            aa5 = b;
                            aa6 = a5;
                            /////
                            d.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            d1.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            d3.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            d4.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            c.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            b.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            a.Size = new Size(a.Size.Width * 2, a.Size.Height + 10);
                            a2.Size = new Size(a2.Size.Width * 2, a.Size.Height + 10);
                            a3.Size = new Size(a3.Size.Width * 2, a.Size.Height + 10);
                            a4.Size = new Size(a4.Size.Width * 2, a.Size.Height + 10);
                            a5.Size = new Size(a5.Size.Width * 2, a.Size.Height + 10);
                            Label f = new Label();
                            f.Location = new Point(3, 0);
                            f.Text = "Название:";
                            f.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ////////                            
                            Label f1 = new Label();
                            f1.Location = new Point(3, f.Size.Height + 20 + 1);
                            f1.Text = "Общее кол-во:";
                            f1.Size = new Size(f.Width * 2, f.Height);
                            f1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ///////
                            /// ////////                            
                            Label f2 = new Label();
                            f2.Location = new Point(3, (f.Size.Height + 20 + 1) * 2);
                            f2.Text = "Кол-во на складе:";
                            f2.Size = new Size(f.Width * 3, f.Height);
                            f2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ///////
                            /// /// ////////                            
                            Label f3 = new Label();
                            f3.Location = new Point(3, (f.Size.Height + 20 + 1) * 3);
                            f3.Text = "Кол-во повреждённых:";
                            f3.Size = new Size(f.Width * 3, f.Height);
                            f3.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ///////
                            ////// /// ////////                            
                            Label f4 = new Label();
                            f4.Location = new Point(3, (f.Size.Height + 20) * 4 + 4);
                            f4.Text = "Поставщик:";
                            f4.Size = new Size(f.Width * 4, f.Height);
                            f4.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ///////
                            /// /// ////////                            
                            Label f5 = new Label();
                            f5.Location = new Point(3, (f.Size.Height + 20) * 5 + 4);
                            f5.Text = "Цена:";
                            f5.Size = new Size(f.Width * 3, f.Height);
                            f5.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            ///////
                            /// /// /// ////////                            
                            Label f6 = new Label();
                            f6.Location = new Point(3, (f.Size.Height + 20) * 6 + 4);
                            f6.Text = "Кол-во для покупки:";
                            f6.Size = new Size(f.Width * 3, f.Height);
                            f6.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            /////
                            d.BackColor = Color.FromArgb(29, 29, 67);
                            d1.BackColor = Color.FromArgb(29, 29, 67);
                            d4.BackColor = Color.FromArgb(29, 29, 67);
                            d3.BackColor = Color.FromArgb(29, 29, 67);
                            d.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            d.ForeColor = Color.White;
                            d1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            d1.ForeColor = Color.White;
                            d3.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            d3.ForeColor = Color.White;
                            d4.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            d4.ForeColor = Color.White;

                            panel1.Controls.Add(a);
                            panel1.Controls.Add(a2);
                            panel1.Controls.Add(a3);
                            panel1.Controls.Add(a4);
                            panel1.Controls.Add(b);
                            panel1.Controls.Add(a5);
                            panel1.Controls.Add(c);
                            panel1.Controls.Add(d);
                            panel1.Controls.Add(d1);
                            panel1.Controls.Add(d3);
                            panel1.Controls.Add(d4);
                            panel1.Controls.Add(f);
                            panel1.Controls.Add(f1);
                            panel1.Controls.Add(f2);
                            panel1.Controls.Add(f3);
                            panel1.Controls.Add(f4);
                            panel1.Controls.Add(f5);
                            panel1.Controls.Add(f6);
                            panel1.Visible = true;
                            string connect = allconect;
                            string query = $"SELECT TOP (1000) [Название компании]\r\n  FROM [HotelDB].[dbo].[Поставщики]\r\n";

                            using (SqlConnection connect1 = new SqlConnection(connect))
                            {
                                try
                                {
                                    connect1.Open();
                                    int index = 0;
                                    SqlCommand command = new SqlCommand(query, connect1);
                                    SqlDataReader reader = command.ExecuteReader();

                                    while (reader.Read())
                                    {
                                        b.Items.Add(reader["Название компании"].ToString());
                                    }
                                    command.Dispose();
                                    reader.Close();
                                    connect1.Close();
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                                }
                            }
                        }
                    }
                    catch (Exception eeee) { }

                }
                else
                    if (tablee == 2)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        Label f = new Label();
                        f.Location = new Point(3, 0);
                        f.Text = "Название компании:";
                        f.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ////////                            
                        Label f1 = new Label();
                        f1.Location = new Point(3, f.Size.Height + 20);
                        f1.Text = "Общее кол-во:";
                        f1.Size = new Size(f.Width * 2, f.Height);
                        f1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        /// ////////                            
                        Label f2 = new Label();
                        f2.Location = new Point(3, (f.Size.Height + 20) * 2);
                        f2.Text = "Кол-во на складе:";
                        f2.Size = new Size(f.Width * 3, f.Height);
                        f2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        /// /// ////////                            
                        Label f3 = new Label();
                        f3.Location = new Point(3, ((f.Size.Height + 20) * 3) + 2);
                        f3.Text = "Категория:";
                        f3.Size = new Size(f.Width * 3, f.Height);
                        f3.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        ///
                        panel1.Controls.Clear();
                        dataGridView1.Visible = true;
                        TextBox a = new TextBox();
                        a.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        TextBox a2 = new TextBox();
                        a2.Location = new Point(0, (a.Size.Height + 6) * 1);
                        a2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        TextBox a3 = new TextBox();
                        a3.Location = new Point(0, (a.Size.Height + 6) * 2);
                        a3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        TextBox a4 = new TextBox();
                        a4.Location = new Point(0, (a.Size.Height + 6) * 3);
                        a4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        Button d = new Button();
                        d.Location = new Point(0, (a.Size.Height + 6) * 4);
                        d.Text = "Сохранить";
                        d.Size = new Size(a.Size.Width, a.Size.Height);
                        d.Click += new EventHandler(savepost);
                        Button d1 = new Button();
                        d1.Location = new Point(0, (a.Size.Height + 6) * 5);
                        d1.Text = "Удалить строку";
                        d1.Size = new Size(a.Size.Width, a.Size.Height);
                        d1.Click += new EventHandler(deletepost);
                        Button d2 = new Button();
                        d2.Location = new Point(0, (a.Size.Height + 6) * 6);
                        d2.Text = "Добавить";
                        d2.Size = new Size(a.Size.Width, a.Size.Height);
                        d2.Click += new EventHandler(insertpost);
                        ///////
                        a.Size = new Size(a2.Size.Width * 2, a.Size.Height + 10);
                        a2.Size = new Size(a3.Size.Width * 2, a.Size.Height + 10);
                        a3.Size = new Size(a4.Size.Width * 2, a.Size.Height + 10);
                        a4.Size = new Size(a4.Size.Width * 2, a.Size.Height + 10);
                        a2.Location = new Point(3, a.Size.Height * 1 + 20 * 2);
                        a3.Location = new Point(3, a.Size.Height * 2 + 20 * 3);
                        a4.Location = new Point(3, a.Size.Height * 3 + 20 * 4);
                        a.Location = new Point(3, 20);
                        d.BackColor = Color.FromArgb(29, 29, 67);
                        d1.BackColor = Color.FromArgb(29, 29, 67);
                        d2.BackColor = Color.FromArgb(29, 29, 67);

                        d.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d.ForeColor = Color.White;
                        d1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d1.ForeColor = Color.White;
                        d2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d2.ForeColor = Color.White;
                        d.Location = new Point(0, a.Size.Height * 4 + 20 * 5 - 10);
                        d1.Location = new Point(0, a.Size.Height * 5 + 20 * 6 - 10);
                        d2.Location = new Point(0, a.Size.Height * 6 + 20 * 7 - 10);
                        d.Size = new Size(d.Size.Width * 2, a.Size.Height + 10);
                        d1.Size = new Size(d1.Size.Width * 2, a.Size.Height + 10);
                        d2.Size = new Size(d2.Size.Width * 2, a.Size.Height + 10);
                        //////
                        panel1.Controls.Add(a);
                        panel1.Controls.Add(a2);
                        panel1.Controls.Add(a3);
                        panel1.Controls.Add(a4);
                        panel1.Controls.Add(d);
                        panel1.Controls.Add(d1);
                        panel1.Controls.Add(d2);
                        panel1.Controls.Add(f2);
                        panel1.Controls.Add(f1);
                        panel1.Controls.Add(f3);
                        panel1.Controls.Add(f);
                        aaa = a;
                        aaa2 = a2;
                        aaa3 = a3;
                        aaa4 = a4;
                    }
                    else
                    {
                        Label f = new Label();
                        f.Location = new Point(3, 0);
                        f.Text = "Название компании:";
                        f.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ////////                            
                        Label f1 = new Label();
                        f1.Location = new Point(3, f.Size.Height + 20 + 3);
                        f1.Text = "Общее кол-во:";
                        f1.Size = new Size(f.Width * 2, f.Height);
                        f1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        /// ////////                            
                        Label f2 = new Label();
                        f2.Location = new Point(3, (f.Size.Height + 20 + 3) * 2);
                        f2.Text = "Кол-во на складе:";
                        f2.Size = new Size(f.Width * 3, f.Height);
                        f2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        /// /// ////////                            
                        Label f3 = new Label();
                        f3.Location = new Point(3, ((f.Size.Height + 20 + 3) * 3) + 2);
                        f3.Text = "Категория:";
                        f3.Size = new Size(f.Width * 3, f.Height);
                        f3.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        ///////
                        panel1.Controls.Clear();
                        dataGridView1.Visible = true;
                        TextBox a = new TextBox();
                        a.Text = "";
                        TextBox a2 = new TextBox();
                        a2.Location = new Point(0, (a.Size.Height + 6) * 1);
                        a2.Text = "";
                        TextBox a3 = new TextBox();
                        a3.Location = new Point(0, (a.Size.Height + 6) * 2);
                        a3.Text = "";
                        TextBox a4 = new TextBox();
                        a4.Location = new Point(0, (a.Size.Height + 6) * 3);
                        a4.Text = "";
                        Button d = new Button();
                        d.Location = new Point(0, (a.Size.Height + 6) * 4);
                        d.Text = "Сохранить";
                        d.Size = new Size(a.Size.Width, a.Size.Height);
                        d.Click += new EventHandler(savepost);
                        Button d1 = new Button();
                        d1.Location = new Point(0, (a.Size.Height + 6) * 5);
                        d1.Text = "Удалить строку";
                        d1.Size = new Size(a.Size.Width, a.Size.Height);
                        d1.Click += new EventHandler(deletepost);
                        Button d2 = new Button();
                        d2.Location = new Point(0, (a.Size.Height + 6) * 6);
                        d2.Text = "Добавить";
                        d2.Size = new Size(a.Size.Width, a.Size.Height);
                        d2.Click += new EventHandler(insertpost);
                        a.Size = new Size(a2.Size.Width * 2, a.Size.Height + 10);
                        a2.Size = new Size(a3.Size.Width * 2, a.Size.Height + 10);
                        a3.Size = new Size(a4.Size.Width * 2, a.Size.Height + 10);
                        a4.Size = new Size(a4.Size.Width * 2, a.Size.Height + 10);
                        a2.Location = new Point(3, a.Size.Height * 1 + 20 * 2);
                        a3.Location = new Point(3, a.Size.Height * 2 + 20 * 3);
                        a4.Location = new Point(3, a.Size.Height * 3 + 20 * 4);
                        a.Location = new Point(3, 20);
                        d.BackColor = Color.FromArgb(29, 29, 67);
                        d1.BackColor = Color.FromArgb(29, 29, 67);
                        d2.BackColor = Color.FromArgb(29, 29, 67);

                        d.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d.ForeColor = Color.White;
                        d1.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d1.ForeColor = Color.White;
                        d2.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        d2.ForeColor = Color.White;
                        d.Location = new Point(0, a.Size.Height * 4 + 20 * 5 - 10);
                        d1.Location = new Point(0, a.Size.Height * 5 + 20 * 6 - 10);
                        d2.Location = new Point(0, a.Size.Height * 6 + 20 * 7 - 10);
                        d.Size = new Size(d.Size.Width * 2, a.Size.Height + 10);
                        d1.Size = new Size(d1.Size.Width * 2, a.Size.Height + 10);
                        d2.Size = new Size(d2.Size.Width * 2, a.Size.Height + 10);
                        panel1.Controls.Add(a);
                        panel1.Controls.Add(a2);
                        panel1.Controls.Add(a3);
                        panel1.Controls.Add(a4);
                        panel1.Controls.Add(d);
                        panel1.Controls.Add(d1);
                        panel1.Controls.Add(d2);
                        panel1.Controls.Add(f2);
                        panel1.Controls.Add(f1);
                        panel1.Controls.Add(f3);
                        panel1.Controls.Add(f);

                        aaa = a;
                        aaa2 = a2;
                        aaa3 = a3;
                        aaa4 = a4;
                    }
                }
            }
            catch (Exception et) { }
        }
        TextBox aa = new TextBox();
        TextBox aa2 = new TextBox();
        TextBox aa3 = new TextBox();
        TextBox aa4 = new TextBox();
        ComboBox aa5 = new ComboBox();
        TextBox aa6 = new TextBox();
        private void insertpost(object sender, EventArgs e)
        {
            if (aaa2.Text[0] != '+' && !char.IsNumber(aaa2.Text[0]))
            {
                aaa2.BackColor = Color.Red;
                return;
            }
            for (int i = 1; i < aaa2.Text.Length; i++)
            {
                if (!char.IsNumber(aaa2.Text[i]))
                {
                    aaa2.BackColor = Color.Red;
                    return;
                }
            }
            aaa2.BackColor = Color.White;
            bool a = false;
            for (int i = 0; i < PostList.Count; i++)
            {
                if (PostList[i].namepost == aaa.Text)
                {
                    a = true;
                }
            }
            if (a)
            {
                MessageBox.Show("Поставщик с таким названием уже есть!");
            }
            else
            {
                string connect4 = allconect;
                string query4 = $"INSERT INTO Поставщики ([Название компании], Телефон, Адрес,Категория)\r\nVALUES ('{aaa.Text}', '{aaa2.Text}', '{aaa3.Text}','{aaa4.Text}')";
                using (SqlConnection connect3 = new SqlConnection(connect4))
                {

                    try
                    {
                        connect3.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query4, connect3);
                        command.ExecuteNonQuery();


                        command.Dispose();

                        connect3.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }
                postupdate();
                button8.PerformClick();
            }
        }

        private void insertinvent(object sender, EventArgs e)
        {

            string connect2 = allconect;
            string query1 = $"SELECT ID_Поставщика \r\nFROM Поставщики \r\nWHERE [Название компании] = '{aa5.Text}'";
            string id = "";
            using (SqlConnection connect3 = new SqlConnection(connect2))
            {

                try
                {
                    connect3.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query1, connect3);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader["ID_Поставщика"].ToString();
                    }

                    command.Dispose();
                    reader.Close();
                    connect3.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Некорректные данные!");
                }


            }
            bool f = false;
            string connect5 = allconect;
            string query5 = $"SELECT \r\n    *\r\nFROM \r\n    Инвентарь\r\nWHERE \r\n    [Название предмета] = '{aa.Text}'\r\n    AND ID_Поставщика = '{id}';";
            using (SqlConnection connect3 = new SqlConnection(connect5))
            {

                try
                {
                    connect3.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query5, connect3);
                    var count = command.ExecuteScalar();
                    if (count != null)
                    {
                        f = true;
                    }
                }
                catch (SqlException ex)
                {
                    // MessageBox.Show("Некорректные данные!");
                }
                catch (Exception ex2)
                {

                }
            }
            if (f)
            {
                MessageBox.Show("Такой предмет закупаемый у этого поставщика уже есть в таблице!");
            }
            else
            {
                bool jk = true;
                if (!int.TryParse(aa2.Text, out int gh))
                {
                    aa2.BackColor = Color.Red;
                    jk = false;
                }
                else
                    aa2.BackColor = Color.White;
                if (!int.TryParse(aa3.Text, out int gh12))
                {
                    aa3.BackColor = Color.Red;
                    jk = false;
                }
                else
                    aa3.BackColor = Color.White;
                if (!int.TryParse(aa4.Text, out int gh2))
                {
                    aa4.BackColor = Color.Red;
                    jk = false;
                }
                else
                    aa4.BackColor = Color.White;
                if (!int.TryParse(aa6.Text, out int g1h))
                {
                    aa6.BackColor = Color.Red;
                    jk = false;
                }
                else
                    aa6.BackColor = Color.White;
                if (jk == true)
                {


                    string connect4 = allconect;
                    string query4 = $"INSERT INTO Инвентарь ( [Название предмета], [Общее кол-во], [Кол-во на складе], [Кол-во поврежденных], ID_Поставщика, [Цена шт.])\r\nVALUES ('{aa.Text}', {aa2.Text}, {aa3.Text},{aa4.Text}, {id},{aa6.Text});";
                    using (SqlConnection connect3 = new SqlConnection(connect4))
                    {

                        try
                        {
                            connect3.Open();
                            int index = 0;
                            SqlCommand command = new SqlCommand(query4, connect3);
                            command.ExecuteNonQuery();


                            command.Dispose();

                            connect3.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Некорректные данные!");
                        }
                    }
                    Inventupdate();
                }
            }
        }
        private void save(object sender, EventArgs e)
        {
            bool jk = true;
            if (!int.TryParse(aa2.Text, out int gh))
            {
                aa2.BackColor = Color.Red;
                jk = false;
            }
            else
                aa2.BackColor = Color.White;
            if (!int.TryParse(aa3.Text, out int gh12))
            {
                aa3.BackColor = Color.Red;
                jk = false;
            }
            else
                aa3.BackColor = Color.White;
            if (!int.TryParse(aa4.Text, out int gh2))
            {
                aa4.BackColor = Color.Red;
                jk = false;
            }
            else
                aa4.BackColor = Color.White;
            if (!int.TryParse(aa6.Text, out int g1h))
            {
                aa6.BackColor = Color.Red;
                jk = false;
            }
            if (jk == false) { return; }
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Вы не выбрали строку!");
            }

            {
                string connect2 = allconect;
                string query1 = $"SELECT ID_Поставщика \r\nFROM Поставщики \r\nWHERE [Название компании] = '{aa5.Text}'";
                string id = "";
                using (SqlConnection connect3 = new SqlConnection(connect2))
                {

                    try
                    {
                        connect3.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query1, connect3);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            id = reader["ID_Поставщика"].ToString();
                        }

                        command.Dispose();
                        reader.Close();
                        connect3.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }


                }

                bool f = false;
                for (int i = 0; i < InventList.Count; i++)
                {
                    if (InventList[i].name == aa.Text && InventList[i].idpost == id && InventList[i].idinvent != dataGridView1.SelectedRows[0].Cells[6].Value.ToString())
                    {
                        f = true;
                        break;
                    }
                }
                if (f)
                {
                    MessageBox.Show("Такой предмет закупаемый у этого поставщика уже есть в таблице!");
                }


                else
                {
                    ooo = false;
                    string connect = allconect;
                    string query = $"UPDATE Инвентарь SET [Название предмета]='{aa.Text}', [Общее кол-во]='{aa2.Text}', [Кол-во на складе]='{aa3.Text}', [Кол-во поврежденных]='{aa4.Text}',ID_поставщика='{id}',[Цена шт.]='{aa6.Text}' WHERE ID_Инвертарь='{dataGridView1.SelectedRows[0].Cells[6].Value.ToString()}'";
                    using (SqlConnection connect1 = new SqlConnection(connect))
                    {
                        try
                        {
                            connect1.Open();
                            int index = 0;
                            SqlCommand command = new SqlCommand(query, connect1);


                            command.ExecuteNonQuery();
                            command.Dispose();

                            connect1.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                        }
                    }
                    Inventupdate();
                }
            }
        }
        NumericUpDown s = new NumericUpDown();
        Button btn = new Button();
        private void deleteinvent(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Вы не выбрали строку!");
            }
            else
            {
                string connect = allconect;
                string query = $"DELETE FROM Инвентарь\r\nWHERE ID_Инвертарь = {dataGridView1.SelectedRows[0].Cells[6].Value.ToString()}";
                using (SqlConnection connect1 = new SqlConnection(connect))
                {
                    try
                    {
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);


                        command.ExecuteNonQuery();
                        command.Dispose();

                        connect1.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }
                Inventupdate();


            }
        }
        bool ooo = false;
        private void otchet(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Вы не выбрали строку!");
            }
            else
            {
                if (s.Value == 0)
                {
                    MessageBox.Show("Выберите вол-во!");
                }
                else
                {
                    string connect = allconect;
                    string query = $"INSERT INTO Отчеты ([Тип], [Описание], [ID_Ответственного Работника], [Дата создания записи]) VALUES ('Финансовый', 'Покупка товара: {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()} кол-во: {s.Value.ToString()} на сумму: {int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()) * s.Value}', '2', '{DateTime.Now.ToString()}')";
                    using (SqlConnection connect1 = new SqlConnection(connect))
                    {
                        connect1.Open();
                        SqlCommand command = new SqlCommand(query, connect1);
                        command.ExecuteNonQuery();
                    }
                    //dataGridView1.SelectedRows[0].Cells[1].Value=int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) + s.Value;
                    //dataGridView1.SelectedRows[0].Cells[2].Value = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) + s.Value;

                    aa2.Text = (int.Parse(aa2.Text) + s.Value).ToString();
                    aa3.Text = (int.Parse(aa3.Text) + s.Value).ToString();

                    btn.PerformClick();
                }

            }
            pdfsave($"Покупка товара: {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}кол - во: {s.Value.ToString()}на сумму: {int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()) * s.Value} в{DateTime.Now.ToString()}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button4.Visible = true;
            panel1.Controls.Clear();
            panel1.Enabled = true;
            panel1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            tablee = 1;
            Inventupdate();
        }
        class invent
        {
            public string idinvent;
            public string name;
            public string count;
            public string allcount;
            public string defectcount;
            public string idpost;
            public string price;
            public string namepost;
        }
        class post
        {
            public string namepost;
            public string idpost;
            public string phone;
            public string email;
            public string category;

        }
        List<invent> InventList = new List<invent>();
        List<post> PostList = new List<post>();

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = false;
            panel1.Enabled = true;
            panel1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            panel1.Controls.Clear();
            panel1.Visible = true;
            tablee = 0;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("1", "Id поставщика");
            dataGridView1.Columns.Add("2", "Название компании");
            dataGridView1.Columns.Add("3", "Телефон");
            dataGridView1.Columns.Add("4", "Адрес");
            dataGridView1.Columns.Add("5", "Категория");
            tablee = 2;
            for (int i = 0; i < PostList.Count; i++)
            {
                dataGridView1.Rows.Add(PostList[i].idpost, PostList[i].namepost, PostList[i].phone, PostList[i].email, PostList[i].category);
            }
            dataGridView1.Visible = true;
        }
        TextBox aaa = new TextBox();
        TextBox aaa2 = new TextBox();
        TextBox aaa3 = new TextBox();
        TextBox aaa4 = new TextBox();
        bool ooo1 = false;
        private void savepost(object sender, EventArgs e)
        {
            if (aaa2.Text[0] != '+' && !char.IsNumber(aaa2.Text[0]))
            {
                aaa2.BackColor = Color.Red;
                return;
            }
            for (int i = 1; i < aaa2.Text.Length; i++)
            {
                if (!char.IsNumber(aaa2.Text[i]))
                {
                    aaa2.BackColor = Color.Red;
                    return;
                }
            }
            aaa2.BackColor = Color.White;
            bool a = false;
            for (int i = 0; i < PostList.Count; i++)
            {
                if (PostList[i].namepost == aaa.Text && PostList[i].idpost != dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    a = true;
                }
            }
            if (a)
            {
                MessageBox.Show("Поставщик с таким названием уже есть!");
            }
            else
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Вы не выбрали строку!");
                }
                else
                {


                    string connect = allconect;
                    string query = $"UPDATE Поставщики SET [Название компании]='{aaa.Text}', [Телефон]='{aaa2.Text}', [Адрес]='{aaa3.Text}',Категория='{aaa4.Text}' WHERE ID_Поставщика='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'";
                    using (SqlConnection connect1 = new SqlConnection(connect))
                    {
                        try
                        {
                            connect1.Open();
                            int index = 0;
                            SqlCommand command = new SqlCommand(query, connect1);


                            command.ExecuteNonQuery();
                            command.Dispose();

                            connect1.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                        }
                    }

                    postupdate();
                    button8.PerformClick();
                }
            }
        }
        private void deletepost(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Вы не выбрали строку!");
            }
            else
            {
                string connect = allconect;
                string query = $"DELETE FROM Поставщики WHERE ID_Поставщика = '{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'";
                using (SqlConnection connect1 = new SqlConnection(connect))
                {
                    try
                    {
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);


                        command.ExecuteNonQuery();
                        command.Dispose();

                        connect1.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Данный поставщик есть в таблице инвентарь! Удалите строку с этим поставщиком или поменяйте поставщика!");
                    }
                }

                postupdate();
                button8.PerformClick();
            }
        }
        class ot
        {
            public string idot;
            public string type;
            public string descript;
            public string idrab;
            public string date;
        }
        List<ot> otList = new List<ot> { };
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = false;
            panel1.Enabled = true;
            panel1.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Enabled = true;

            dataGridView1.Visible = true;
            tablee = 0;
            panel1.Controls.Clear();
            panel1.Visible = true;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("1", "ID Отчета");
            dataGridView1.Columns.Add("2", "Тип");
            dataGridView1.Columns.Add("3", "Описание");
            dataGridView1.Columns.Add("4", "Работник");
            dataGridView1.Columns.Add("5", "Дата создания записи");


            string connect2 = allconect;
            string query2 = $"SELECT     Отчеты.ID_Отчета,    Отчеты.Тип,     Отчеты.Описание,    Работники.Имя,     Работники.Фамилия,     Отчеты.[Дата создания записи] FROM     Отчеты JOIN      Работники ON Отчеты.[ID_Ответственного Работника] = Работники.ID_Пользователя";

            using (SqlConnection connect1 = new SqlConnection(connect2))
            {
                try
                {
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query2, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ot g = new ot();
                        g.idot = reader["ID_Отчета"].ToString();
                        g.type = reader["Тип"].ToString();
                        g.descript = reader["Описание"].ToString();
                        g.idrab = reader["Имя"].ToString() + " " + reader["Фамилия"].ToString();
                        g.date = reader["Дата создания записи"].ToString();
                        otList.Add(g);
                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }

            }
            for (int i = 0; i < otList.Count; i++)
            {
                dataGridView1.Rows.Add(otList[i].idot, otList[i].type, otList[i].descript, otList[i].idrab, otList[i].date);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InventList.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("1", "Название");
            dataGridView1.Columns.Add("2", "Общее кол-во");
            dataGridView1.Columns.Add("3", "Кол-во на складе");
            dataGridView1.Columns.Add("4", "Кол-во повреждённых");
            dataGridView1.Columns.Add("5", "поставщик");
            dataGridView1.Columns.Add("6", "цена");
            dataGridView1.Columns.Add("7", "id");

            string connect = allconect;
            string query = $"SELECT \r\n Инвентарь.[Цена шт.],   Инвентарь.ID_Инвертарь,\r\n    Инвентарь.[Название предмета],\r\n    Инвентарь.[Общее кол-во],\r\n    Инвентарь.[Кол-во на складе],\r\n    Инвентарь.[Кол-во поврежденных],\r\n    Поставщики.[Название компании],\r\n    Поставщики.Телефон,\r\n    Поставщики.Адрес\r\nFROM \r\n    Инвентарь\r\nJOIN \r\n    Поставщики ON Инвентарь.ID_Поставщика = Поставщики.ID_Поставщика\r\nWHERE \r\n    Инвентарь.[Название предмета] LIKE '%{textBox1.Text}%'\r\n    OR Поставщики.[Название компании] LIKE '%{textBox1.Text}%';";
            using (SqlConnection connect1 = new SqlConnection(connect))
            {
                try
                {
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        invent f = new invent();
                        f.idinvent = reader["ID_Инвертарь"].ToString();
                        f.name = reader["Название предмета"].ToString();
                        f.allcount = reader["Общее кол-во"].ToString();
                        f.count = reader["Кол-во на складе"].ToString();
                        f.defectcount = reader["Кол-во поврежденных"].ToString();
                        // f.idpost = reader["ID_Поставщика"].ToString();
                        f.price = reader["Цена шт."].ToString();
                        f.namepost = reader["Название компании"].ToString();
                        InventList.Add(f);
                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                }
                catch (SqlException ex)
                {
                    // MessageBox.Show("Данный поставщик есть в таблице инвентарь! Удалите строку с этим поставщиком или поменяйте поставщика!");
                }
                for (int i = 0; i < InventList.Count; i++)
                {
                    dataGridView1.Rows.Add(InventList[i].name, InventList[i].allcount, InventList[i].count, InventList[i].defectcount, InventList[i].namepost, InventList[i].price, InventList[i].idinvent);
                }
                dataGridView1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.SortCompare += DataGridView1_SortCompare;
            dataGridView1.Sort(dataGridView1.Columns["3"], ListSortDirection.Descending);
        }
        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

            if (int.TryParse(e.CellValue1?.ToString(), out int number1) &&
                int.TryParse(e.CellValue2?.ToString(), out int number2))
            {
                // Сравниваем числа
                e.SortResult = number1.CompareTo(number2);
            }
            else
            {
                // Если преобразование не удалось, сортируем как строки
                e.SortResult = string.Compare(e.CellValue1?.ToString(), e.CellValue2?.ToString());
            }

            // Указываем, что сортировка выполнена
            e.Handled = true;

        }
        public void totable()
        {
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                if (int.Parse(dataGridView1.Rows[j].Cells[2].Value.ToString()) < 5)
                {
                    dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.White;
                }
            }
        }
        public void pdfsave(string content)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"; // Фильтр для PDF
                saveFileDialog.Title = "Сохранить PDF файл";
                saveFileDialog.FileName = "Document.pdf"; // Имя файла по умолчанию

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Создаем PDF вручную
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        WritePdfContent(fs, content);
                    }

                    // MessageBox.Show("PDF файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void WritePdfContent(Stream stream, string content)
        {
            // Кодировка Windows-1251 (для поддержки кириллицы)
            Encoding encoding = Encoding.GetEncoding(1251);

            // Заголовок PDF
            string pdfHeader = "%PDF-1.7\n";

            // Объект для текста
            string contentObj = "1 0 obj\n" +
                                "<< /Length " + encoding.GetByteCount(content) + " >>\n" +
                                "stream\n" +
                                "BT\n" + // Начало текстового блока
                                "/F1 12 Tf\n" + // Установка шрифта и размера
                                "50 700 Td\n" + // Позиция текста (x=50, y=700)
                                "(" + EscapeContent(content) + ") Tj\n" + // Текст
                                "ET\n" + // Конец текстового блока
                                "endstream\n" +
                                "endobj\n";

            // Шрифт (используем Times New Roman, который поддерживает кириллицу)
            string fontObj = "2 0 obj\n" +
                             "<< /Type /Font\n" +
                             "   /Subtype /TrueType\n" +
                             "   /BaseFont /TimesNewRoman\n" +
                             "   /Encoding /WinAnsiEncoding\n" + // Используем WinAnsiEncoding
                             ">>\n" +
                             "endobj\n";

            // Каталог объектов
            string catalogObj = "3 0 obj\n" +
                               "<< /Type /Catalog\n" +
                               "   /Pages 4 0 R\n" +
                               ">>\n" +
                               "endobj\n";

            // Страницы
            string pagesObj = "4 0 obj\n" +
                              "<< /Type /Pages\n" +
                              "   /Kids [5 0 R]\n" +
                              "   /Count 1\n" +
                              ">>\n" +
                              "endobj\n";

            // Страница
            string pageObj = "5 0 obj\n" +
                             "<< /Type /Page\n" +
                             "   /Parent 4 0 R\n" +
                             "   /MediaBox [0 0 612 792]\n" + // Размер страницы (A4)
                             "   /Contents 1 0 R\n" + // Содержимое страницы
                             "   /Resources << /Font << /F1 2 0 R >> >>\n" + // Ресурсы (шрифт)
                             ">>\n" +
                             "endobj\n";

            // Кросс-ссылки
            string xref = "xref\n" +
                          "0 6\n" +
                          "0000000000 65535 f \n" +
                          "0000000018 00000 n \n" +
                          "0000000077 00000 n \n" +
                          "0000000126 00000 n \n" +
                          "0000000195 00000 n \n" +
                          "0000000270 00000 n \n";

            // Завершение PDF
            string trailer = "trailer\n" +
                             "<< /Size 6\n" +
                             "   /Root 3 0 R\n" +
                             ">>\n" +
                             "startxref\n" +
                             "0\n" +
                             "%%EOF\n";

            // Записываем все части в поток
            byte[] headerBytes = Encoding.ASCII.GetBytes(pdfHeader);
            byte[] contentBytes = Encoding.ASCII.GetBytes(contentObj);
            byte[] fontBytes = Encoding.ASCII.GetBytes(fontObj);
            byte[] catalogBytes = Encoding.ASCII.GetBytes(catalogObj);
            byte[] pagesBytes = Encoding.ASCII.GetBytes(pagesObj);
            byte[] pageBytes = Encoding.ASCII.GetBytes(pageObj);
            byte[] xrefBytes = Encoding.ASCII.GetBytes(xref);
            byte[] trailerBytes = Encoding.ASCII.GetBytes(trailer);

            stream.Write(headerBytes, 0, headerBytes.Length);
            stream.Write(contentBytes, 0, contentBytes.Length);
            stream.Write(fontBytes, 0, fontBytes.Length);
            stream.Write(catalogBytes, 0, catalogBytes.Length);
            stream.Write(pagesBytes, 0, pagesBytes.Length);
            stream.Write(pageBytes, 0, pageBytes.Length);
            stream.Write(xrefBytes, 0, xrefBytes.Length);
            stream.Write(trailerBytes, 0, trailerBytes.Length);
        }

        // Экранирование специальных символов в тексте
        private string EscapeContent(string content)
        {
            return content
                .Replace("\\", "\\\\")
                .Replace("(", "\\(")
                .Replace(")", "\\)")
                .Replace("\r", "\\r")
                .Replace("\n", "\\n");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isDragging = false;
        private Point startPoint;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = panel4.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-startPoint.X, -startPoint.Y);
                this.Location = newPoint;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        //открывашка основного меню
        private void pictureBox6_Click(object sender, EventArgs e)
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

        Form_Profiles profile;
        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Authoriz authoriz = new Authoriz();
            this.Hide();
            authoriz.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();
        }
        private void button_EditPassword_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = false;

            Form_Profiles.typeDialogForm = false;
            profile = new Form_Profiles();
            DialogResult result = profile.ShowDialog();
        }

        private void button_EditData_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = false;

            Form_Profiles.typeDialogForm = true;
            profile = new Form_Profiles();
            DialogResult result = profile.ShowDialog();
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
    }
}





