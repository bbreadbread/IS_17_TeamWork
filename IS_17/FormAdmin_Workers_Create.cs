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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IS_17
{
    public partial class FormAdmin_Workers_Create : Form
    {
        string allView = $"SELECT TOP (1000) [ID_Пользователя], [Имя], [Фамилия], [Почта], [Телефон], [Пароль], [Роль] FROM [HotelDB].[dbo].[Работники]";
        public FormAdmin_Workers_Create()
        {
            InitializeComponent();
        }

        private void FormAdmin_Workers_Create_Load(object sender, EventArgs e)
        {
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
                    dataTable.Columns.Add("Имя", typeof(string));
                    dataTable.Columns.Add("Фамилия", typeof(string));
                    dataTable.Columns.Add("Почта", typeof(string));
                    dataTable.Columns.Add("Телефон", typeof(string));
                    dataTable.Columns.Add("Роль", typeof(string));

                    while (reader.Read())
                    {
                        string name = reader["Имя"].ToString();
                        string surname = reader["Фамилия"].ToString();
                        string email = reader["Почта"].ToString();
                        string number = reader["Телефон"].ToString();
                        string role = reader["Роль"].ToString();

                        dataTable.Rows.Add(name, surname, email, number, role);
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

        private void buttonAddWorkers_Click(object sender, EventArgs e)
        {
            string имя = NametextBox.Text;
            string фамилия = SurnametextBox.Text;
            string почта = EmailtextBox.Text;
            string телефон = NumbertextBox.Text;
            string роль = TypecomboBox.Text;


            if (string.IsNullOrWhiteSpace(имя) || !ContainsOnlyLetters(имя))
            {
                MessageBox.Show("Поле 'Имя' не может быть пустым.");
                return;
            }

            if (string.IsNullOrWhiteSpace(фамилия) || !ContainsOnlyLetters(фамилия))
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым.");
                return;
            }

            if (!IsValidEmail(почта))
            {
                MessageBox.Show("Некорректный формат почты.");
                return;
            }

            if (!IsValidPhoneNumber(телефон))
            {
                MessageBox.Show("Некорректный формат телефона.");
                return;
            }

            if (string.IsNullOrWhiteSpace(роль))
            {
                MessageBox.Show("Поле 'Роль' не может быть пустым.");
                return;
            }

            LoadWorkers($"INSERT INTO [HotelDB].[dbo].[Работники] ([Имя], [Фамилия], [Почта], [Телефон], [Пароль], [Роль]) VALUES ('{NametextBox.Text}'," +
                $" '{SurnametextBox.Text}', '{EmailtextBox.Text}', '{NumbertextBox.Text}', 'Qw12G5J4Dcl000', '{TypecomboBox.Text}');");
            LoadWorkers(allView);

            SendMessage(EmailtextBox.Text);
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
