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
            dataGridView1.GridColor = Color.FromArgb(29, 29, 67);
            LoadWorkers(allView);
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        int ID_SET = 0;
        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                ID_SET = (int)row.Cells["ID"].Value;
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
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Имя", typeof(string));
                    dataTable.Columns.Add("Фамилия", typeof(string));
                    dataTable.Columns.Add("Почта", typeof(string));
                    dataTable.Columns.Add("Телефон", typeof(string));
                    dataTable.Columns.Add("Роль", typeof(string));

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID_Пользователя");
                        string name = reader["Имя"].ToString();
                        string surname = reader["Фамилия"].ToString();
                        string email = reader["Почта"].ToString();
                        string number = reader["Телефон"].ToString();
                        string role = reader["Роль"].ToString();

                        dataTable.Rows.Add(id, name, surname, email, number, role);
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

            // Получаем значения из полей
            string имя = NametextBox.Text;
            string фамилия = SurnametextBox.Text;
            string почта = EmailtextBox.Text;
            string телефон = NumbertextBox.Text;
            string роль = TypecomboBox.Text;

            bool isValid = true;

            NametextBox.BackColor = Color.White;
            SurnametextBox.BackColor = Color.White;
            EmailtextBox.BackColor = Color.White;
            NumbertextBox.BackColor = Color.White;
            TypecomboBox.BackColor = Color.White;

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

            string query = $"UPDATE [HotelDB].[dbo].[Работники] SET " +
                $"[Имя] = '{имя}', " +
                $"[Фамилия] = '{фамилия}', " +
                $"[Почта] = '{почта}', " +
                $"[Телефон] = '{телефон}', " +
                $"[Роль] = '{роль}' " +
                $"WHERE [ID_Пользователя] = {ID_SET};";

            // Выполняем запрос
            LoadWorkers(query);
            LoadWorkers(allView);

            MessageBox.Show("Данные работника успешно обновлены.");
        }

        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для удаления.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            object value = selectedRow.Cells[0].Value;

            if (value == null)
            {
                MessageBox.Show("Не удалось получить ID работяги.");
                return;
            }

            int idSet = Convert.ToInt32(value);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого работника?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = $"DELETE FROM [HotelDB].[dbo].[Работники] WHERE [ID_Пользователя] = {idSet};";

            // Выполняем запрос
            LoadWorkers(query);
            LoadWorkers(allView);
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

        private void FormAdmin_Workers_Edit_Load(object sender, EventArgs e)
        {
            LoadWorkers(allView);
        }
    }
}
