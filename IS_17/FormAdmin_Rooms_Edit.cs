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

namespace IS_17
{
    public partial class FormAdmin_Rooms_Edit : Form
    {
        string allView = $"SELECT TOP (1000) [ID_Номера], [Тип комнаты], [Количество мест], [Цена за сутки], [Статус] FROM [HotelDB].[dbo].[Номера]";
        public FormAdmin_Rooms_Edit()
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

                typeRoomcomboBox.Text = row.Cells["Тип комнаты"].Value.ToString();
                CountSeatnumericUpDown.Text = row.Cells["Количество мест"].Value.ToString();
                PricetextBox.Text = row.Cells["Цена за сутки"].Value.ToString();
                StatuscomboBox.Text = row.Cells["Статус"].Value.ToString();

                if (StatuscomboBox.Text == "Забронировано")
                {
                    StatuscomboBox.Enabled = false;
                }
                else
                {
                    StatuscomboBox.Enabled = true;
                }
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
            try
            {
                // Проверка, что выбрана строка в dataGridView1
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Выберите номер для редактирования.");
                    return;
                }

                // Получаем ID выбранного номера
                int idSet = dataGridView1.CurrentRow.Index + 1; // +1, если ID начинается с 1

                // Получаем значения из полей
                string типКомнаты = typeRoomcomboBox.Text;
                string количество_мест = CountSeatnumericUpDown.Text;
                string цена_за_сутки = PricetextBox.Text;
                string статус = StatuscomboBox.Text;

                // Проверка, что количество мест — целое число
                if (!int.TryParse(количество_мест, out int количествоМест) || количествоМест <= 0)
                {
                    MessageBox.Show("Поле 'Количество мест' должно быть положительным целым числом.");
                    return;
                }

                // Проверка, что цена за сутки — число
                if (!int.TryParse(цена_за_сутки, out int ценаЗаСутки) || ценаЗаСутки <= 0)
                {
                    MessageBox.Show("Поле 'Цена за сутки' должно быть положительным числом.");
                    return;
                }

                // Проверка, что тип комнаты и статус не пустые
                if (string.IsNullOrWhiteSpace(типКомнаты) || string.IsNullOrWhiteSpace(статус))
                {
                    MessageBox.Show("Поля 'Тип комнаты' и 'Статус' не могут быть пустыми.");
                    return;
                }

                // Формируем SQL-запрос для обновления номера
                string query = $"UPDATE [HotelDB].[dbo].[Номера] SET " +
                    $"[Тип комнаты] = '{типКомнаты}', " +
                    $"[Количество мест] = {количествоМест}, " +
                    $"[Цена за сутки] = {ценаЗаСутки}, " +
                    $"[Статус] = '{статус}' " +
                    $"WHERE [ID_Номера] = {idSet};";

                // Выполняем запрос на обновление
                LoadWorkers(query);

                // Удаляем бронирования для номеров со статусом "Доступно"
                LoadWorkers($@"DELETE FROM [HotelDB].[dbo].[Бронирования]
                    WHERE [ID_Номера] IN (
                        SELECT [ID_Номера]
                        FROM [HotelDB].[dbo].[Номера]
                        WHERE [Статус] = 'Доступно'
                    );");

                // Обновляем отображение данных
                LoadWorkers(allView);

                MessageBox.Show("Данные номера успешно обновлены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка, что выбрана строка в dataGridView1
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите номер для удаления.");
                    return;
                }

                // Получаем ID выбранного номера
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                object value = selectedRow.Cells[0].Value;

                if (value == null)
                {
                    MessageBox.Show("Не удалось получить ID номера.");
                    return;
                }

                int roomId = Convert.ToInt32(value);

                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот номер?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Формируем SQL-запрос для удаления номера
                string query = $@"IF EXISTS (SELECT 1 FROM [HotelDB].[dbo].[Номера]
                            WHERE [ID_Номера] = {roomId} 
                            AND [Статус] = 'Забронировано')
                        BEGIN
                            DELETE FROM [HotelDB].[dbo].[Бронирования]
                            WHERE [ID_Номера] = {roomId};

                            DELETE FROM [HotelDB].[dbo].[Номера]
                            WHERE [ID_Номера] = {roomId};
                        END
                        ELSE 
                        BEGIN 
                            DELETE FROM [HotelDB].[dbo].[Номера]
                            WHERE [ID_Номера] = {roomId};
                        END";

                // Выполняем запрос на удаление
                LoadWorkers(query);

                // Обновляем отображение данных
                LoadWorkers(allView);

                MessageBox.Show("Номер успешно удалён.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
