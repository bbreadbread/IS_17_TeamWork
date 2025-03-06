using System;
using System.Collections;
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
    public partial class FormAdmin_Workers_Edit : Form
    {
        string allView = $"SELECT TOP (1000) [ID_Пользователя], [Имя], [Фамилия], [Почта], [Телефон], [Пароль], [Роль] FROM [HotelDB].[dbo].[Работники]";
        public FormAdmin_Workers_Edit()
        {
            InitializeComponent();
            LoadWorkers(allView);
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                NametextBox.Text = row.Cells["Имя"].Value.ToString();
                SurnametextBox.Text = row.Cells["Фамилия"].Value.ToString();
                EmailtextBox.Text = row.Cells["Почта"].Value.ToString();
                NumbertextBox.Text = row.Cells["Телефон"].Value.ToString();
                TypecomboBox.Text = row.Cells["Роль"].Value.ToString();
            }
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

        private void buttonEditWorker_Click(object sender, EventArgs e)
        {
            // Проверка, что выбрана строка в dataGridView1
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для редактирования.");
                return;
            }

            // Получаем ID выбранного работника
            int idSet = dataGridView1.CurrentRow.Index + 1; // +1, если ID начинается с 1

            // Получаем значения из полей
            string имя = NametextBox.Text;
            string фамилия = SurnametextBox.Text;
            string почта = EmailtextBox.Text;
            string телефон = NumbertextBox.Text;
            string роль = TypecomboBox.Text;

            // Проверка имени
            if (string.IsNullOrWhiteSpace(имя) || !ContainsOnlyLetters(имя))
            {
                MessageBox.Show("Поле 'Имя' не может быть пустым и должно содержать только буквы.");
                return;
            }

            // Проверка фамилии
            if (string.IsNullOrWhiteSpace(фамилия) || !ContainsOnlyLetters(фамилия))
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым и должно содержать только буквы.");
                return;
            }

            // Проверка почты
            if (!IsValidEmail(почта))
            {
                MessageBox.Show("Некорректный формат почты.");
                return;
            }

            // Проверка телефона
            if (!IsValidPhoneNumber(телефон))
            {
                MessageBox.Show("Некорректный формат телефона. Телефон должен состоять из 10 цифр.");
                return;
            }

            // Проверка роли
            if (string.IsNullOrWhiteSpace(роль))
            {
                MessageBox.Show("Поле 'Роль' не может быть пустым.");
                return;
            }

            // Формируем SQL-запрос
            string query = $"UPDATE [HotelDB].[dbo].[Работники] SET " +
                $"[Имя] = '{имя}', " +
                $"[Фамилия] = '{фамилия}', " +
                $"[Почта] = '{почта}', " +
                $"[Телефон] = '{телефон}', " +
                $"[Роль] = '{роль}' " +
                $"WHERE [ID_Пользователя] = {idSet};";

            // Выполняем запрос
            LoadWorkers(query);
            LoadWorkers(allView);

            MessageBox.Show("Данные работника успешно обновлены.");
        }

        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            // Проверка, что выбрана строка в dataGridView1
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для удаления.");
                return;
            }

            // Получаем ID выбранного работника
            int idSet = dataGridView1.CurrentRow.Index + 1; // +1, если ID начинается с 1

            // Подтверждение удаления
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого работника?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Формируем SQL-запрос
            string query = $"DELETE FROM [HotelDB].[dbo].[Работники] WHERE [ID_Пользователя] = {idSet};";

            // Выполняем запрос
            LoadWorkers(query);
            LoadWorkers(allView);

            MessageBox.Show("Работник успешно удалён.");
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

        private void TypecomboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Устанавливаем цвет фона для выделенного элемента
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(TypecomboBox.BackColor), e.Bounds);
            }

            // Рисуем текст элемента
            e.Graphics.DrawString(TypecomboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.RowBounds);
            }
        }
    }
}
