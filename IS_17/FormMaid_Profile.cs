using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace IS_17
{
    public partial class FormMaid_Profile : Form
    {
        //false = пароль
        //true = данные
        //SELECT TOP (1000)[Пароль]

        string query = $"SELECT TOP (1000) [ID_Пользователя], [Имя], [Фамилия], [Пароль], [Почта], [Телефон] FROM [HotelDB].[dbo].[Работники] WHERE [ID_Пользователя] = {FormMaid.IdSelected}";
        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
        public static bool typeDialogForm;
        string password;
        string mail;
        string number;
        Random random = new Random();
        int num;
        public FormMaid_Profile()
        {
            InitializeComponent();
        }

        private void FormMaid_Profile_Load(object sender, EventArgs e)
        {
            labelWHO.Text = $"{FormMaid.SurnameSelected} {FormMaid.NameSelected}";
            buttonConfirm.Enabled = false;
        }

        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        password = reader["Пароль"].ToString();
                        mail = reader["Почта"].ToString();
                        number = reader["Телефон"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

            if (typeDialogForm == false)
            {
                label1.Text = "Изменение пароля";
                if (password == textBox1.Text)
                {
                    if (ValidatePassword(textBox2.Text) == "0")
                    {
                        SendMessage(FormMaid.MailSelected);
                        buttonConfirm.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат нового пароля");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                if (IsValidEmail(textBox1.Text) == true)
                {
                    if (IsValidPhoneNumber(textBox2.Text) == true)
                    {
                        SendMessage(textBox1.Text);
                        buttonConfirm.Enabled = true;
                    }
                }
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "")
            {
                if (int.TryParse(textBox3.Text, out int a))
                {
                    if(a == num)
                    {
                        if (typeDialogForm == false) Update(textBox2.Text);
                        else Update(textBox1.Text, textBox2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введен неверный код!");
                    }
                }
                else
                {
                    MessageBox.Show("Введен неверный код!");
                }
            }
            else
            {
                MessageBox.Show("Код не введен!");
            }
        }
        void Update(string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE [Работники] SET [Пароль] = @НовыйПароль WHERE [ID_Пользователя] = @ID_Пользователя";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@НовыйПароль", newPassword);
                    command.Parameters.AddWithValue("@ID_Пользователя", FormMaid.IdSelected);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пароль успешно обновлён.");
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден или пароль не изменён.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
        }
        void Update(string newMail, string newNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE [Работники] SET [Почта] = @НоваяПочта, [Телефон] = @НовыйТелефон WHERE [ID_Пользователя] = @ID_Пользователя";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@НоваяПочта", newMail);
                    command.Parameters.AddWithValue("@НовыйТелефон", newNumber);
                    command.Parameters.AddWithValue("@ID_Пользователя", FormMaid.IdSelected);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пароль успешно обновлён.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден или пароль не изменён.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^(?!.*\.\.)(?!.*\.$)(?!^\.)[a-zA-Z]+[a-zA-Z0-9]{0,3}(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,6}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            if (phoneNumber[0] != '9')
            {
                return false;
            }

            return true;
        }

        private string ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return "0";
            }

            if (!password.Any(char.IsDigit))
            {
                return "0";
            }

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "0";
            }

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                return "0";
            }

            string keyboardLayout = "qwertyuiopasdfghjklzxcvbnm";
            string keyboardLayoutUpper = keyboardLayout.ToUpper();

            for (int i = 0; i < password.Length - 2; i++)
            {
                char first = password[i];
                char second = password[i + 1];
                char third = password[i + 2];

                if (IsAdjacentOnKeyboard(first, second, keyboardLayout) && IsAdjacentOnKeyboard(second, third, keyboardLayout))
                {
                    return "0";
                }

                if (IsAdjacentOnKeyboard(first, second, keyboardLayoutUpper) && IsAdjacentOnKeyboard(second, third, keyboardLayoutUpper))
                {
                    return "0";
                }
            }
            return string.Empty;
        }

        private bool IsAdjacentOnKeyboard(char first, char second, string keyboardLayout)
        {
            int index1 = keyboardLayout.IndexOf(first);
            int index2 = keyboardLayout.IndexOf(second);

            return index1 != -1 && index2 != -1 && Math.Abs(index1 - index2) == 1;
        }

        private void SendMessage(string email)
        {

            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("agata_andreevna@mail.ru", "ExrbrJMgNfELNKuWcPS3");

            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("agata_andreevna@mail.ru");
            Message.To.Add(new MailAddress($"{email}"));
            Message.Subject = "Ваш код подтверждения!";
            num = random.Next(9999);
            Message.Body = $"Чтобы изменить информацию о Вас, введите этот код в соответсвующее поле: {num}";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
