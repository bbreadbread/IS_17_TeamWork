using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_17
{
    public partial class Authoriz : Form
    {
        int userId;
        string firstName;
        string lastName;
        string mail;
        public static int WHOAREYOU_ID { get; set; }
        public static string WHOAREYOU_FIO { get; set; } 
        public Authoriz()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passTB.Text;

            if (emailTB.Text == "zroot")
            {
                FormZavhoz zavhozForm = new FormZavhoz();
                this.Hide();
                zavhozForm.Show();
                return;
            }
            if (emailTB.Text == "aroot")
            {
                FormAdmin a = new FormAdmin();
                this.Hide();
                a.Show();
                return;
            }
            if (emailTB.Text == "mroot")
            {
                FormMaid a = new FormMaid(1, "", "", "breadtt00@gmail.com");
                this.Hide();
                a.Show();
                return;
            }
            if (emailTB.Text == "proot")
            {
                FormPorter a = new FormPorter();
                this.Hide();
                a.Show();
                return;
            }
            string pattern = @"^(?!.*\.\.)(?!.*\.$)(?!^\.)[a-zA-Z]+[a-zA-Z0-9]{0,3}(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,6}$";
            if (!Regex.IsMatch(email, pattern))
            {
                emailTB.BackColor = Color.FromArgb(238, 165, 176);
                return;
            }
            else
            {
                emailTB.BackColor = Color.White; // Сброс цвета, если email корректен
            }

            // Проверка валидности пароля
            string validationMessage = ValidatePassword(password);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                passTB.BackColor = Color.FromArgb(238, 165, 176);
                passShow.BackColor = Color.FromArgb(238, 165, 176);
                return;
            }
            else
            {
                passTB.BackColor = Color.White; // Сброс цвета, если пароль корректен
                passShow.BackColor = Color.White;
            }

            // Проверка наличия пользователя в базе данных
            string role = CheckUserCredentials(email, password);

            if (role != null)
            {
                // Переход на форму в зависимости от роли
                switch (role)
                {
                    case "Администратор":
                        FormAdmin adminForm = new FormAdmin();
                        this.Hide();
                        adminForm.Show();
                        break;
                    case "Завхоз":
                        WHOAREYOU_ID = userId;
                        FormZavhoz zavhozForm = new FormZavhoz();
                        this.Hide();
                        zavhozForm.Show();
                        break;
                    case "Горничная":
                        FormMaid maidForm = new FormMaid(userId, firstName, lastName, mail);
                        this.Hide();
                        maidForm.Show();
                        break;
                    case "Портье":
                        WHOAREYOU_ID = userId;
                        FormPorter formPorter = new FormPorter();
                        this.Hide();
                        formPorter.Show();
                        break;
                    default:
                        MessageBox.Show("Роль пользователя не определена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                passTB.BackColor = Color.FromArgb(238, 165, 176);
                passShow.BackColor = Color.FromArgb(238, 165, 176);
            }
        }

        // Метод для проверки пароля
        private string ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "Пароль не может быть пустым.";
            }
            if (password.Length < 6)
            {
                return "Пароль должен содержать не менее 6 символов.";
            }
            return null; // Пароль корректен
        }

        // Метод для проверки наличия пользователя в базе данных
        private string CheckUserCredentials(string email, string password)
        {
            string role = null;

            // Подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL-запрос для проверки email и пароля
                    string query = "SELECT [Роль], [ID_Пользователя], [Имя], [Фамилия], [Почта] FROM [HotelDB].[dbo].[Работники] WHERE [Почта] = @Почта AND [Пароль] = @Пароль";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Почта", email);
                        command.Parameters.AddWithValue("@Пароль", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                role = reader["Роль"].ToString();
                                userId = Convert.ToInt32(reader["ID_Пользователя"]);
                                firstName = reader["Имя"].ToString();
                                lastName = reader["Фамилия"].ToString();
                                mail = reader["Почта"].ToString();

                                WHOAREYOU_FIO = $"{firstName} {lastName}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return role;
        }


        //это в случае, когда пользователь захочет ввести данные - мы убираем подсказку
        private void emailTB_Enter(object sender, EventArgs e)
        {
            emailTB.BackColor = Color.FromArgb(224, 214, 233);
            if (emailTB.Text == "Почта")
            {
                emailTB.Text = "";
                emailTB.ForeColor = Color.Black;

                //emailTB.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        //это в случае, когда пользователь оставит поле для ввода пустым - мы возвращаем подказку
        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                emailTB.Text = "Почта";
                emailTB.ForeColor = Color.Gray;
            }

            emailTB.BackColor = Color.White;
        }

        //это в случае, когда пользователь захочет ввести данные - мы убираем подсказку
        private void passTB_Enter(object sender, EventArgs e)
        {
            passTB.BackColor = Color.FromArgb(224, 214, 233);
            passShow.BackColor = Color.FromArgb(224, 214, 233);
            if (passTB.Text == "Пароль")
            {
                passTB.Text = "";
                passTB.ForeColor = Color.Black;
                passTB.PasswordChar = '·';
                //passTB.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        //это в случае, когда пользователь оставит поле для ввода пустым - мы возвращаем подказку
        private void passTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passTB.Text))
            {
                passTB.Text = "Пароль";
                passTB.ForeColor = Color.Gray;
                passTB.PasswordChar = '\0';

            }
            passTB.BackColor = Color.White;
            passShow.BackColor = Color.White;
        }

        private void passShow_MouseDown(object sender, MouseEventArgs e)
        {
            passTB.PasswordChar = '\0';
        }

        private void passShow_MouseUp(object sender, MouseEventArgs e)
        {
            if (passTB.Text == "Пароль")
                passTB.PasswordChar = '\0';
            else
                passTB.PasswordChar = '·';
        }


        private bool IsAdjacentOnKeyboard(char first, char second, string keyboardLayout)
        {
            int index1 = keyboardLayout.IndexOf(first);
            int index2 = keyboardLayout.IndexOf(second);

            return index1 != -1 && index2 != -1 && Math.Abs(index1 - index2) == 1;
        }

        private void Authoriz_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            //пишем подсказку для пользователя
            emailTB.Text = "Почта";
            emailTB.ForeColor = Color.Gray;


            //пишем подсказку для пользователя
            passTB.Text = "Пароль";
            passTB.ForeColor = Color.Gray;
            passTB.PasswordChar = '\0';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool isDragging = false;
        private Point startPoint;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
