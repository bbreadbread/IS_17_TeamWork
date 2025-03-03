using System;
using System.Collections;
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
            int idSet = dataGridView1.CurrentRow.Index;
            string query = $"UPDATE [HotelDB].[dbo].[Работники] SET [Имя] = '{NametextBox.Text}', [Фамилия] = '{SurnametextBox.Text}', [Почта] = '{EmailtextBox.Text}', [Телефон] = '{NumbertextBox.Text}', " +
                $"[Роль] = '{TypecomboBox.Text}' WHERE [ID_Пользователя] = {idSet + 1};";
            LoadWorkers(query);
            LoadWorkers(allView);
        }

        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            int idSet = dataGridView1.CurrentRow.Index;
            string query = $"DELETE FROM [HotelDB].[dbo].[Работники] WHERE [Имя] = '{NametextBox.Text}' and [Фамилия] = '{SurnametextBox.Text}' and [Почта] = '{EmailtextBox.Text}' and [Телефон] = '{NumbertextBox.Text}';";
            LoadWorkers(query);
            LoadWorkers(allView);
        }
    }
}
