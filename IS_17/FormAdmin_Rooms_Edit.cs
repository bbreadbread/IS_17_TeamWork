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
            int int1 = int.Parse(CountSeatnumericUpDown.Text);
            int int2 = int.Parse(PricetextBox.Text);
            int idSet = dataGridView1.CurrentRow.Index;
            string query = $"UPDATE [HotelDB].[dbo].[Номера] SET [Тип комнаты] = '{typeRoomcomboBox.Text}', [Количество мест] = {int1},  [Цена за сутки] = {int2}, [Статус] = '{StatuscomboBox.Text}' WHERE [ID_Номера] = {idSet + 1};";
            LoadWorkers(query);
            LoadWorkers($@"DELETE FROM[HotelDB].[dbo].[Бронирования]
                        WHERE[ID_Номера] IN(
                            SELECT[ID_Номера]
                            FROM[HotelDB].[dbo].[Номера]
                            WHERE[Статус] = 'Доступно'
                        );");
            LoadWorkers(allView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                object value = selectedRow.Cells[0].Value;

                if (value != null)
                {
                    int roomId = Convert.ToInt32(value);
                    int int1 = int.Parse(CountSeatnumericUpDown.Text);
                    int int2 = int.Parse(PricetextBox.Text);
                    int idSet = dataGridView1.CurrentRow.Index;
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
                    LoadWorkers(query);
                    LoadWorkers(allView);
                }
                else
                {
                    MessageBox.Show("Значение в первом столбце отсутствует.");
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана.");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.RowBounds);
            }
        }

        private void typeRoomcomboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Устанавливаем цвет фона для выделенного элемента
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(231, 212, 247)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(typeRoomcomboBox.BackColor), e.Bounds);
            }

            // Рисуем текст элемента
            e.Graphics.DrawString(typeRoomcomboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
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
    }
}
