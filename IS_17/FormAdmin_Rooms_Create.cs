using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_17
{
    public partial class FormAdmin_Rooms_Create : Form
    {
        string allView = $"SELECT TOP (1000)  [ID_Номера], [Тип комнаты], [Количество мест], [Цена за сутки], [Статус] FROM [HotelDB].[dbo].[Номера]";
        public FormAdmin_Rooms_Create()
        {
            InitializeComponent();
            dataGridView1.GridColor = Color.FromArgb(29, 29, 67);
            LoadWorkers(allView);
        }
        private void LoadWorkers(string query)
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Номер комнаты", typeof(string));
                    dataTable.Columns.Add("Тип комнаты", typeof(string));
                    dataTable.Columns.Add("Количество мест", typeof(int));
                    dataTable.Columns.Add("Цена за сутки", typeof(int));
                    dataTable.Columns.Add("Статус", typeof(string));

                    while (reader.Read())
                    {
                        string num = reader["ID_Номера"].ToString();
                        string type = reader["Тип комнаты"].ToString();
                        string count = reader["Количество мест"].ToString();
                        string price = reader["Цена за сутки"].ToString();
                        string status = reader["Статус"].ToString();

                        dataTable.Rows.Add(num, type, count, price, status);
                    }
                    reader.Close();

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].Width = 70;
                    dataGridView1.Columns[1].Width = 70;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string тип = typeRoomComboBox.Text;
            string количество_мест = CountSeatnumericUpDown.Text;
            string цена_за_сутки = PricetextBox.Text;
            string статус = StatuscomboBox.Text;

            bool isValid = true;

            typeRoomComboBox.BackColor = Color.White;
            CountSeatnumericUpDown.BackColor = Color.White;
            PricetextBox.BackColor = Color.White;
            StatuscomboBox.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(тип))
            {
                typeRoomComboBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(количество_мест))
            {
                CountSeatnumericUpDown.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!int.TryParse(количество_мест, out int количествоМестЧисло) || количествоМестЧисло <= 0)
            {
                CountSeatnumericUpDown.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(цена_за_сутки))
            {
                PricetextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!decimal.TryParse(цена_за_сутки, out decimal ценаЗаСуткиЧисло) || ценаЗаСуткиЧисло <= 0)
            {
                PricetextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(статус))
            {
                StatuscomboBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            var допустимыеТипы = new List<string> { "Стандарт", "Люкс" };
            if (!допустимыеТипы.Contains(тип))
            {
                typeRoomComboBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            var допустимыеСтатусы = new List<string> { "Доступно", "Забронировано", "Тех. обслуживание" };
            if (!допустимыеСтатусы.Contains(статус))
            {
                StatuscomboBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            string email = "aggata.serggeeva@mail.ru";
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некорректный email.");
                return;
            }

            LoadWorkers($"INSERT INTO [HotelDB].[dbo].[Номера] ([Тип комнаты], [Количество мест], [Цена за сутки], [Статус]) VALUES" +
                $" ('{тип}', '{количество_мест}', '{цена_за_сутки}', '{статус}');");
            LoadWorkers(allView);

            SendMessage(email);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^(?!.*\.\.)(?!.*\.$)(?!^\.)[a-zA-Z]+[a-zA-Z0-9]{0,3}(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,6}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        //aggata.serggeeva@mail.ru
        private void SendMessage(string email)
        {
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("agata_andreevna@mail.ru", "ExrbrJMgNfELNKuWcPS3");

            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("agata_andreevna@mail.ru");
            Message.To.Add(new MailAddress($"{email}"));
            Message.Subject = "Вы в системе!";
            Message.Body = "Хорошо трудитель на благо партии! Ваш дефолтный пароль:\n Qw12G5J4Dcl000 \n измените его для вашей же безопасности!";

            try
            {
                Smtp.Send(Message);
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"Ошибка при отправке письма: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.RowBounds);
            }
        }

        private void StatuscomboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Устанавливаем цвет фона для выделенного элемента
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(StatuscomboBox.BackColor), e.Bounds);
            }

            // Рисуем текст элемента
            e.Graphics.DrawString(StatuscomboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
        }


        private void typeRoomComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Устанавливаем цвет фона для выделенного элемента
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(typeRoomComboBox.BackColor), e.Bounds);
            }

            // Рисуем текст элемента
            e.Graphics.DrawString(typeRoomComboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
        }
    }
}
