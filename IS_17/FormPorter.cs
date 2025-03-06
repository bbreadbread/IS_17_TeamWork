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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace IS_17
{
    public partial class FormPorter : Form
    {
        //Эту строчку нужно будет заменить когда будете показывать проект!
        string allconect = "Data Source=DESKTOP-60C99SS\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=False";

        public FormPorter()
        {
            InitializeComponent();
        }
        class number
        {
            public string idnumber;
            public string type;
            public string count;
            public string price;
            public string status;

        }
        List<number> numberlist = new List<number>();
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker2.Visible = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;

            panel1.Controls.Clear();
            int index = 0;
            int index1 = 0;
            for (int i = 0; i < numberlist.Count; i++)
            {
                if (i % 4 == 0)
                {
                    index = 0;
                    index1++;
                }
                Button button = new Button();
                button.Size = new Size(panel1.Size.Width / 5, panel1.Size.Width / 5);
                button.Location = new Point((10 * index) + ((panel1.Size.Width / 5) * index), (10 * index1) + ((panel1.Size.Width / 5) * index1));
                button.Tag = numberlist[i];
                button.Text = i.ToString();
                button.Click += new EventHandler(buttonnumber);
                if (numberlist[i].status == "Доступно")
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                index++;
                panel1.Controls.Add(button);

            }


        }
        public void updatelist()
        {
            numberlist.Clear();
            string query = $"SELECT ID_Номера, [Тип комнаты], [Количество мест], [Цена за сутки], Статус\r\nFROM Номера;";

            using (SqlConnection connect1 = new SqlConnection(allconect))
            {
                try
                {
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        number number = new number();
                        number.idnumber = reader["ID_Номера"].ToString();
                        number.type = reader["Тип комнаты"].ToString();
                        number.count = reader["Количество мест"].ToString();
                        number.price = reader["Цена за сутки"].ToString();
                        number.status = reader["Статус"].ToString();
                        numberlist.Add(number);
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
        private void FormPorter_Load(object sender, EventArgs e)
        {
            updatelist();

        }
        static class bron
        {
            static public string idbron;
            static public string idquest;
            static public string datestart;
            static public string dateend;
        }
        string idnum;
        number numinformation;
        Button aaa;
        private void buttonnumber(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            aaa = sender as Button;
            number a = clickedButton.Tag as number;
            numinformation = clickedButton.Tag as number;
            idnum = a.idnumber;
            if (a.status == "Доступно")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

            }

            else
            {
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"SELECT ID_Бронирования, [Дата заезда], [Дата выезда], [Общая стоимость бронирования],ID_Гостя\r\nFROM Бронирования\r\nWHERE ID_Номера = {a.idnumber}";
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            bron.idbron = reader["ID_Бронирования"].ToString();
                            bron.idquest = reader["ID_Гостя"].ToString();
                            bron.datestart = reader["Дата заезда"].ToString();
                            bron.dateend = reader["Дата выезда"].ToString();
                            //number.status = reader["Статус"].ToString();

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
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"SELECT *\r\nFROM Гости\r\nWHERE ID_Гостя = '{bron.idquest}'";
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            textBox1.Text = reader["Фамилия"].ToString() + " " + reader["Имя"].ToString();
                            textBox2.Text = reader["Номер"].ToString();
                            textBox3.Text = reader["Паспорт(серия, номер)"].ToString();
                            dateTimePicker1.Value = DateTime.Parse(bron.datestart);
                            dateTimePicker2.Value = DateTime.Parse(bron.dateend);
                            textBox4.Text = reader["Время уборки"].ToString();
                            textBox5.Text = reader["Предпочтения"].ToString();

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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] a1 = textBox1.Text.Split(' ');
            if (a1.Length != 2 || a1 == null)
            {
                MessageBox.Show("Введите имя и фамилию!");
            }
            else
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            else
            if (dateTimePicker2.Value.CompareTo(dateTimePicker1.Value) < 0)
            {
                MessageBox.Show("Вы ввели непраильную дату!");
            }
            else
            if (aaa == null)
            {
                MessageBox.Show("Выберите номер!");
            }
            else
            if (aaa.BackColor == Color.Red)
            {
                MessageBox.Show("Номер уже забронирован!");
            }

            else
            {
                //object result = command.ExecuteScalar();
                object result = null;
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"SELECT ID_Гостя\r\nFROM Гости\r\nWHERE [Паспорт(серия, номер)] = '{textBox3.Text}'";
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            result = reader["ID_Гостя"].ToString();
                            //number.status = reader["Статус"].ToString();

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }
                if (result != null)
                {
                    string[] a = textBox1.Text.Split(' ');
                    using (SqlConnection connect1 = new SqlConnection(allconect))
                    {

                        try
                        {
                            string query = $"UPDATE Гости\r\nSET \r\n    Фамилия = '{a[0]}',\r\n    Имя = '{a[1]}',\r\n    Номер = '{textBox2.Text}'\r\n   , Предпочтения = '{textBox5.Text}',\r\n    [Время уборки] = '{textBox4.Text}'\r\nWHERE ID_Гостя = '{result}'";
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
                }
                else
                {
                    using (SqlConnection connect1 = new SqlConnection(allconect))
                    {
                        string[] a = textBox1.Text.Split(' ');
                        try
                        {
                            string query = $"INSERT INTO Гости (Фамилия, Имя, Номер, [Паспорт(серия, номер)], Предпочтения, [Время уборки]) VALUES('{a[0]}','{a[1]}', '{textBox2.Text}', '{textBox3.Text}', '{textBox5.Text}','{textBox4.Text}') SELECT SCOPE_IDENTITY();";
                            connect1.Open();
                            int index = 0;
                            SqlCommand command = new SqlCommand(query, connect1);
                            result = Convert.ToInt32(command.ExecuteScalar());
                            command.Dispose();
                            connect1.Close();


                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                        }
                    }
                }
                dateTimePicker1.CustomFormat = "YYYY-MM-DD";
                dateTimePicker2.CustomFormat = "YYYY-MM-DD";
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"INSERT INTO Бронирования ( ID_Гостя, ID_Номера, ID_Горничной, ID_Портье, [Дата заезда], [Дата выезда], [Общая стоимость бронирования], [Статус бронирования])\r\nVALUES ({result}, {idnum}, 5,4, '{dateTimePicker1.Value.Date}', '{dateTimePicker2.Value.Date}', {int.Parse(numinformation.price) * (dateTimePicker2.Value - dateTimePicker1.Value).Days}, 'Подтверждено');";
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);
                        command.ExecuteNonQuery();

                        aaa = null;
                        command.Dispose();

                        connect1.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }

                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"UPDATE Номера\r\nSET Статус='Забронировано' \r\n  WHERE ID_Номера = '{idnum}'";
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
                updatelist();
                button3.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (aaa == null)
            {
                MessageBox.Show("Выберите номер!");
            }
            else
            {
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"DELETE FROM Бронирования WHERE ID_Номера = {idnum}";
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
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"UPDATE Номера\r\nSET Статус='Доступно' \r\n  WHERE ID_Номера = '{idnum}'";
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
                updatelist();
                button3.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string[] a1 = textBox1.Text.Split(' ');
            if (a1.Length != 2 || a1 == null)
            {
                MessageBox.Show("Введите имя и фамилию!");
            }
            else
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            else
            if (dateTimePicker2.Value.CompareTo(dateTimePicker1.Value) < 0)
            {
                MessageBox.Show("Вы ввели непраильную дату!");
            }
            else
            if (aaa == null)
            {
                MessageBox.Show("Выберите номер!");
            }

            else
            {
                object result = null;
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"SELECT ID_Гостя\r\nFROM Гости\r\nWHERE [Паспорт(серия, номер)] = '{textBox3.Text}'";
                        connect1.Open();
                        int index = 0;
                        SqlCommand command = new SqlCommand(query, connect1);
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            result = reader["ID_Гостя"].ToString();
                            //number.status = reader["Статус"].ToString();

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }
                if (result != null)
                {
                    string[] a = textBox1.Text.Split(' ');
                    using (SqlConnection connect1 = new SqlConnection(allconect))
                    {

                        try
                        {
                            string query = $"UPDATE Гости\r\nSET \r\n    Фамилия = '{a[0]}',\r\n    Имя = '{a[1]}',\r\n    Номер = '{textBox2.Text}'\r\n   , Предпочтения = '{textBox5.Text}',\r\n    [Время уборки] = '{textBox4.Text}'\r\nWHERE ID_Гостя = '{result}'";
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
                }
                else
                {
                    using (SqlConnection connect1 = new SqlConnection(allconect))
                    {
                        string[] a = textBox1.Text.Split(' ');
                        try
                        {
                            string query = $"INSERT INTO Гости (Фамилия, Имя, Номер, [Паспорт(серия, номер)], Предпочтения, [Время уборки]) VALUES('{a[0]}','{a[1]}', '{textBox2.Text}', '{textBox3.Text}', '{textBox5.Text}','{textBox4.Text}') SELECT SCOPE_IDENTITY();";
                            connect1.Open();
                            int index = 0;
                            SqlCommand command = new SqlCommand(query, connect1);
                            result = Convert.ToInt32(command.ExecuteScalar());
                            command.Dispose();
                            connect1.Close();


                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                        }
                    }
                }
                dateTimePicker1.CustomFormat = "YYYY-MM-DD";
                dateTimePicker2.CustomFormat = "YYYY-MM-DD";
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"UPDATE Бронирования\r\nSET\r\n    ID_Гостя ='{result}',\r\n      ID_Горничной = 5,\r\n    ID_Портье = 4,\r\n    [Дата заезда] = '{dateTimePicker1.Value.Date}',\r\n    [Дата выезда] = '{dateTimePicker2.Value.Date}',\r\n    [Общая стоимость бронирования] ='{int.Parse(numinformation.price) * (dateTimePicker2.Value - dateTimePicker1.Value).Days}',\r\n    [Статус бронирования] = 'да'\r\nWHERE\r\n    ID_Номера = {idnum}";
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
                updatelist();
                button3.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Visible = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            string query = "SELECT * FROM Гости";
            panel1.Controls.Clear();
            DataGridView d = new DataGridView();
            d.Columns.Add("1", "Фамилия");
            d.Columns.Add("2", "Имя");
            d.Columns.Add("3", "Номер");
            d.Columns.Add("4", "Паспорт");
            d.Columns.Add("5", "Предпочтения");
            d.Columns.Add("6", "Время уборки");
            d.Size = new Size(panel1.Width, panel1.Height);
            using (SqlConnection connect1 = new SqlConnection(allconect))
            {

                try
                {
                    //string query = $"SELECT *\r\nFROM Гости\r\nWHERE ID_Гостя = '{bron.idquest}'";
                    connect1.Open();
                    int index = 0;
                    SqlCommand command = new SqlCommand(query, connect1);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string v1 = reader["Фамилия"].ToString();
                        string v2 = reader["Имя"].ToString();
                        string v3 = reader["Номер"].ToString();
                        string v4 = reader["Паспорт(серия, номер)"].ToString();
                      
                        string v7 = reader["Время уборки"].ToString();
                        string v8 = reader["Предпочтения"].ToString();
                        d.Rows.Add(v1, v2, v3, v4, v7, v8);

                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                    panel1.Controls.Add(d);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }
    }
}
