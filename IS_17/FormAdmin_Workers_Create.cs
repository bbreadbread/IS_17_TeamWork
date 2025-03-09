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
            dataGridView1.GridColor = Color.FromArgb(29, 29, 67);
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
            // Получаем значения из полей
            string имя = NametextBox.Text;
            string фамилия = SurnametextBox.Text;
            string почта = EmailtextBox.Text;
            string телефон = NumbertextBox.Text;
            string роль = TypecomboBox.Text;

            bool isValid = true;

            NametextBox.BackColor = Color.White;;
            SurnametextBox.BackColor = Color.White;;
            EmailtextBox.BackColor = Color.White;;
            NumbertextBox.BackColor = Color.White;;
            TypecomboBox.BackColor = Color.White;;

            if (string.IsNullOrWhiteSpace(имя) || !ContainsOnlyLetters(имя))
            {
                NametextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(фамилия) || !ContainsOnlyLetters(фамилия))
            {
                SurnametextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!IsValidEmail(почта))
            {
                EmailtextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!IsValidPhoneNumber(телефон))
            {
                NumbertextBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(роль))
            {
                TypecomboBox.BackColor = Color.FromArgb(255, 35, 0);
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            // Если все проверки пройдены, выполняем запрос к базе данных
            LoadWorkers($"INSERT INTO [HotelDB].[dbo].[Работники] ([Имя], [Фамилия], [Почта], [Телефон], [Пароль], [Роль]) VALUES " +
                $"('{имя}', '{фамилия}', '{почта}', '{телефон}', '{GeneratePassword(12)}', '{роль}');");
            LoadWorkers(allView);

            // Отправка сообщения
            SendMessage(почта);
        }
        static string GeneratePassword(int length)
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Заглавные буквы
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz"; // Строчные буквы
            const string digits = "0123456789"; // Цифры
            const string additionalChars = "!" + "$" + "%" + "&" + "@" + "#"; // Дополнительные символы (по желанию)

            // Объединяем все символы в один набор
            string allChars = upperChars + lowerChars + digits + additionalChars;

            // Генерируем пароль
            Random random = new Random();
            char[] password = new char[length];

            // Генерируем случайные символы
            for (int i = 0; i < length; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            return new string(password);
        }
        // Метод для проверки, что строка содержит только буквы
        private bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Метод для проверки корректности email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^(?!.*\.\.)(?!.*\.$)(?!^\.)[a-zA-Z]+[a-zA-Z0-9]{0,3}(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,6}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Метод для проверки корректности телефона
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Проверка, что телефон состоит из 10 цифр
            string pattern = @"^\d{10}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
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
            Message.Body = "Хорошо трудитеcь на благо партии! \n\nВаш дефолтный пароль:\n           Qw12G5J4Dcl000 \nИзмените его для вашей же безопасности!";

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
    }
}
