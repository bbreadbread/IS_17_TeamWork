﻿using System;
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

namespace IS_17
{
    public partial class FormAdmin_Rooms_Create : Form
    {
        string allView = $"SELECT TOP (1000) [ID_Номера], [Тип комнаты], [Количество мест], [Цена за сутки], [Статус] FROM [HotelDB].[dbo].[Номера]";
        public FormAdmin_Rooms_Create()
        {
            InitializeComponent();
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


            if (string.IsNullOrWhiteSpace(тип))
            {
                MessageBox.Show("Поле 'тип' не может быть пустым.");
                return;
            }

            if (string.IsNullOrWhiteSpace(количество_мест))
            {
                MessageBox.Show("Поле 'количество_мест' не может быть пустым.");
                return;
            }

            if (string.IsNullOrWhiteSpace(цена_за_сутки))
            {
                MessageBox.Show("Поле 'цена_за_сутки' не может быть пустым.");
                return;
            }

            if (string.IsNullOrWhiteSpace(статус))
            {
                MessageBox.Show("Поле 'статус' не может быть пустым.");
                return;
            }

            LoadWorkers($"INSERT INTO [HotelDB].[dbo].[Работники] ([Номер комнаты], [Тип комнаты], [Количество мест], [Цена за сутки], [Статус]) VALUES" +
                $" ('{тип}', '{количество_мест}', '{цена_за_сутки}', '{статус}');");
            LoadWorkers(allView);

            SendMessage("aggata.serggeeva@mail.ru");
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
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }
        private static bool ContainsOnlyLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Zа-яА-Я]+$");
        }
    }
}
