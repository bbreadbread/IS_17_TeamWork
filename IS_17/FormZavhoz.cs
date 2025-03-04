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

namespace IS_17
{
    public partial class FormZavhoz : Form
    {
        public FormZavhoz()
        {
            InitializeComponent();
        }
        void postupdate()
        {
            string connect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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


            string connect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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
        }
        private void FormZavhoz_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                TextBox a = new TextBox();
                a.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                TextBox a2 = new TextBox();
                a2.Location = new Point(0, (a.Size.Height + 6) * 1);
                a2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TextBox a3 = new TextBox();
                a3.Location = new Point(0, (a.Size.Height + 6) * 2);
                a3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                TextBox a4 = new TextBox();
                a4.Location = new Point(0, (a.Size.Height + 6) * 3);
                a4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ComboBox b = new ComboBox();
                b.Location = new Point(0, (a.Size.Height + 6) * 4);
                b.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                TextBox a5 = new TextBox();
                a5.Location = new Point(0, (a.Size.Height + 6) * 5);
                a5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                NumericUpDown c = new NumericUpDown();
                c.Location = new Point(0, (a.Size.Height + 6) * 6);
                Button d = new Button();
                d.Location = new Point(0, (a.Size.Height + 6) * 7);
                d.Text = "Купить";
                d.Size = new Size(a.Size.Width, a.Size.Height);
                // d.Click += new EventHandler(save);
                Button d1 = new Button();
                d1.Location = new Point(0, (a.Size.Height + 6) * 8);
                d1.Size = new Size(a.Size.Width, a.Size.Height);
                d1.Text = "Сохранить";
                d1.Click += new EventHandler(save);
                d.Click += new EventHandler(otchet);
                btn = d1;
                s = c;
                aa = a;
                aa2 = a2;
                aa3 = a3;
                aa4 = a4;
                aa5 = b;
                aa6 = a5;

                panel1.Controls.Add(a);
                panel1.Controls.Add(a2);
                panel1.Controls.Add(a3);
                panel1.Controls.Add(a4);
                panel1.Controls.Add(b);
                panel1.Controls.Add(a5);
                panel1.Controls.Add(c);
                panel1.Controls.Add(d);
                panel1.Controls.Add(d1);
                panel1.Visible = true;
                string connect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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
            catch { }
        }
        TextBox aa = new TextBox();
        TextBox aa2 = new TextBox();
        TextBox aa3 = new TextBox();
        TextBox aa4 = new TextBox();
        ComboBox aa5 = new ComboBox();
        TextBox aa6 = new TextBox();
        private void save(object sender, EventArgs e)
        {
            string connect2 = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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



            string connect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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
        NumericUpDown s = new NumericUpDown();
        Button btn = new Button();
        private void otchet(object sender, EventArgs e)
        {
            string connect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";
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

        private void button7_Click(object sender, EventArgs e)
        {
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
    }
}
