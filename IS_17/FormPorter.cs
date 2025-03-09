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
        int indexxx = 0;
        List<number> numberlist = new List<number>();
        private void button3_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            textBox6.Visible = false;
            indexxx = 1;
            button2.Text = "Забронировать";
            button1.Text = "Отменить бронь";
            button5.Text = "Сохранить изменения";

            label1.Text = "Фамилия Имя:";
            label2.Text = "Номер телефона:";
            label3.Text = "Серия Номер паспорта:";
            label4.Text = "Время уборки:";
            label5.Text = "Предпочтения:";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


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
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
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
            if (indexxx == 1)
            {
                bool gh = true;
                string[] a1 = textBox1.Text.Split(' ');
                if (a1.Length != 2 || a1 == null)
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                    textBox1.BackColor = Color.White;
                bool hl = true;
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }
                else
                if (textBox2.Text[0] != '+' && !char.IsNumber(textBox2.Text[0]))
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }

                for (int i = 1; i < textBox2.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox2.Text[i]))
                    {
                        textBox2.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox2.BackColor = Color.White;
                hl = true;
                if (textBox3.Text.Length != 11)
                {
                    textBox3.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }

                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox3.Text[i]) && i != 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (textBox3.Text[i] != ' ' && i == 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox3.BackColor = Color.White;
                hl = true;
                if (textBox4.Text.Length != 5)
                {
                    textBox4.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]) && i != 2)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (i == 2 && textBox4.Text[i] != ':')
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }


                if (hl)
                {
                    string[] n1 = textBox4.Text.Split(':');
                    if (int.Parse(n1[0]) > 24 || int.Parse(n1[1]) > 59)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;

                    }
                    else
                    {
                        textBox4.BackColor = Color.White;
                    }
                }
                hl = true;
                bool hl1 = true;
                if (dateTimePicker1.Value.DayOfYear < DateTime.Now.DayOfYear)
                {
                    MessageBox.Show("Вы не можете сделать бронь на прошедшее число!");
                    gh = false;
                    hl = false;
                }
                else
                if (dateTimePicker2.Value.DayOfYear < DateTime.Now.DayOfYear)
                {
                    MessageBox.Show("Вы не можете сделать бронь на прошедшее число!");
                    gh = false;
                    hl1 = false;
                }
                else
                if (dateTimePicker2.Value.CompareTo(dateTimePicker1.Value) < 0)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда!!");
                    gh = false;
                    hl1 = false;
                }
                if (hl)
                {
                    dateTimePicker1.CalendarMonthBackground = Color.White;
                }
                if (hl1)
                {
                    dateTimePicker2.CalendarMonthBackground = Color.White;
                }

                if (aaa == null)
                {
                    MessageBox.Show("Выберите номер!");

                }
                else
                if (aaa.BackColor == Color.Red)
                {
                    MessageBox.Show("Номер уже забронирован!");
                }
                if (gh == false)
                {
                    return;
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
            else
            {

                bool gh = true;
                string[] a1 = textBox1.Text.Split(' ');
                if (a1.Length != 2 || a1 == null)
                {
                    textBox1.BackColor = Color.Red;

                    gh = false;
                }
                else
                    textBox1.BackColor = Color.White;
                bool hl = true;
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }
                else
                if (textBox2.Text[0] != '+' && !char.IsNumber(textBox2.Text[0]))
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }

                for (int i = 1; i < textBox2.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox2.Text[i]))
                    {
                        textBox2.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox2.BackColor = Color.White;
                hl = true;
                if (textBox3.Text.Length != 11)
                {
                    textBox3.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }

                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox3.Text[i]) && i != 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (textBox3.Text[i] != ' ' && i == 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox3.BackColor = Color.White;
                hl = true;
                if (textBox4.Text.Length != 5)
                {
                    textBox4.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]) && i != 2)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (i == 2 && textBox4.Text[i] != ':')
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }


                if (hl)
                {
                    string[] n1 = textBox4.Text.Split(':');
                    if (int.Parse(n1[0]) > 24 || int.Parse(n1[1]) > 59)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;

                    }
                    else
                    {
                        textBox4.BackColor = Color.White;
                    }
                }
                hl = true;
                bool hl1 = true;
                if (gh == false)
                {
                    return;
                }
                string[] df = textBox1.Text.Split(' ');
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"UPDATE Гости\r\nSET Фамилия = '{df[0]}', Имя = '{df[1]}', Номер = '{textBox2.Text}', [Паспорт(серия, номер)] = '{textBox3.Text}', Предпочтения = '{textBox5.Text}', [Время уборки] = '{textBox4.Text}'\r\nWHERE ID_Гостя = '{f.SelectedRows[0].Cells[6].Value.ToString()}'";
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
                updateclient();
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
            if (indexxx == 1)
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
            else
            {

                if (f.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Выберите строку!");
                    return;
                }

                string[] df = textBox1.Text.Split(' ');
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"DELETE FROM Гости\r\nWHERE ID_Гостя = '{f.SelectedRows[0].Cells[6].Value.ToString()}'";
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
                updateclient();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (indexxx == 1)
            {
                bool gh = true;
                string[] a1 = textBox1.Text.Split(' ');
                if (a1.Length != 2 || a1 == null)
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                    textBox1.BackColor = Color.White;
                bool hl = true;
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }
                else
                if (textBox2.Text[0] != '+' && !char.IsNumber(textBox2.Text[0]))
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }

                for (int i = 1; i < textBox2.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox2.Text[i]))
                    {
                        textBox2.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox2.BackColor = Color.White;
                hl = true;
                if (textBox3.Text.Length != 11)
                {
                    textBox3.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }

                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox3.Text[i]) && i != 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (textBox3.Text[i] != ' ' && i == 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox3.BackColor = Color.White;
                hl = true;
                if (textBox4.Text.Length != 5)
                {
                    textBox4.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]) && i != 2)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (i == 2 && textBox4.Text[i] != ':')
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }


                if (hl)
                {
                    string[] n1 = textBox4.Text.Split(':');
                    if (int.Parse(n1[0]) > 24 || int.Parse(n1[1]) > 59)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;

                    }
                    else
                    {
                        textBox4.BackColor = Color.White;
                    }
                }
                hl = true;
                bool hl1 = true;
                if (dateTimePicker1.Value.DayOfYear < DateTime.Now.DayOfYear)
                {
                    MessageBox.Show("Вы не можете сделать бронь на прошедшее число!");
                    gh = false;
                    hl = false;
                }
                else
                if (dateTimePicker2.Value.DayOfYear < DateTime.Now.DayOfYear)
                {
                    MessageBox.Show("Вы не можете сделать бронь на прошедшее число!");
                    gh = false;
                    hl1 = false;
                }
                else
                if (dateTimePicker2.Value.CompareTo(dateTimePicker1.Value) < 0)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда!!");
                    gh = false;
                    hl1 = false;
                }
                if (hl)
                {
                    dateTimePicker1.CalendarMonthBackground = Color.White;
                }
                if (hl1)
                {
                    dateTimePicker2.CalendarMonthBackground = Color.White;
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
            else
            {
                bool gh = true;
                string[] a1 = textBox1.Text.Split(' ');
                if (a1.Length != 2 || a1 == null)
                {
                    textBox1.BackColor = Color.Red;

                    gh = false;
                }
                else
                    textBox1.BackColor = Color.White;
                bool hl = true;
                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }
                else
                if (textBox2.Text[0] != '+' && !char.IsNumber(textBox2.Text[0]))
                {
                    textBox2.BackColor = Color.Red;
                    hl = false;
                    gh = false;
                }

                for (int i = 1; i < textBox2.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox2.Text[i]))
                    {
                        textBox2.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox2.BackColor = Color.White;
                hl = true;
                if (textBox3.Text.Length != 11)
                {
                    textBox3.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }

                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox3.Text[i]) && i != 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (textBox3.Text[i] != ' ' && i == 4)
                    {
                        textBox3.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }
                if (hl)
                    textBox3.BackColor = Color.White;
                hl = true;
                if (textBox4.Text.Length != 5)
                {
                    textBox4.BackColor = Color.Red;
                    gh = false;
                    hl = false;
                }
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]) && i != 2)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                    else
                    if (i == 2 && textBox4.Text[i] != ':')
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;
                        hl = false;
                    }
                }


                if (hl)
                {
                    string[] n1 = textBox4.Text.Split(':');
                    if (int.Parse(n1[0]) > 24 || int.Parse(n1[1]) > 59)
                    {
                        textBox4.BackColor = Color.Red;
                        gh = false;

                    }
                    else
                    {
                        textBox4.BackColor = Color.White;
                    }
                }
                hl = true;
                bool hl1 = true;
                if (gh == false)
                {
                    return;
                }
                string[] k = textBox1.Text.Split(" ");
                using (SqlConnection connect1 = new SqlConnection(allconect))
                {

                    try
                    {
                        string query = $"INSERT INTO Гости (Фамилия, Имя, Номер, [Паспорт(серия, номер)], Предпочтения, [Время уборки])\r\nVALUES ('{k[0]}', '{k[1]}', '{textBox2.Text}', '{textBox3.Text}', '{textBox5.Text}', '{textBox4.Text}')";
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
                updateclient();
            }
        }
        DataGridView f;
        private void dataclick(object sender, EventArgs e)
        {
            if (f != null && f.SelectedRows[0].Cells[0]!.Value != null)
            {
                textBox1.Text = f.SelectedRows[0].Cells[0].Value.ToString() + " " + f.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = f.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = f.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = f.SelectedRows[0].Cells[5].Value.ToString();
                textBox5.Text = f.SelectedRows[0].Cells[4].Value.ToString();

            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            button6.Visible =true;
            textBox6.Visible = true;
            indexxx = 2;
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
            /////

            button2.Visible = true;
            button1.Visible = true;
            button5.Visible = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            button2.Text = "Сохранить";
            button1.Text = "Удалить";
            button5.Text = "Добавить";
            ///
            label1.Text = "Фамилия Имя:";
            label2.Text = "Номер телефона:";
            label3.Text = "Серия Номер паспорта:";
            label4.Text = "Время уборки:";
            label5.Text = "Предпочтения:";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            dateTimePicker2.Enabled = false;
            dateTimePicker2.Visible = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Visible = false;
            updateclient();

        }
        public void updateclient()
        {
            string query = "SELECT * FROM Гости";
            panel1.Controls.Clear();
            DataGridView d = new DataGridView();
            d.Columns.Add("1", "Фамилия");
            d.Columns.Add("2", "Имя");
            d.Columns.Add("3", "Номер");
            d.Columns.Add("4", "Паспорт");
            d.Columns.Add("5", "Предпочтения");
            d.Columns.Add("6", "Время уборки");
            d.Columns.Add("6", "id пользователя");
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.SelectionChanged += dataclick;
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
                        string v9 = reader["ID_Гостя"].ToString();
                        d.Rows.Add(v1, v2, v3, v4, v8, v7, v9);

                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                    panel1.Controls.Add(d);
                    f = d;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Гости\r\nWHERE Имя Like '%{textBox6.Text}%' OR Фамилия Like '%{textBox6.Text}%'";
            panel1.Controls.Clear();
            DataGridView d = new DataGridView();
            d.Columns.Add("1", "Фамилия");
            d.Columns.Add("2", "Имя");
            d.Columns.Add("3", "Номер");
            d.Columns.Add("4", "Паспорт");
            d.Columns.Add("5", "Предпочтения");
            d.Columns.Add("6", "Время уборки");
            d.Columns.Add("6", "id пользователя");
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.SelectionChanged += dataclick;
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
                        string v9 = reader["ID_Гостя"].ToString();
                        d.Rows.Add(v1, v2, v3, v4, v8, v7, v9);

                    }
                    command.Dispose();
                    reader.Close();
                    connect1.Close();
                    panel1.Controls.Add(d);
                    f = d;
                }
                catch (SqlException ex)
                {
                    //  MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f.Sort(f.Columns["1"], ListSortDirection.Ascending);
        }
    }
}
