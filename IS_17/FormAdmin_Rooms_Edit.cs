﻿using System;
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
            LoadWorkers(allView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int int1 = int.Parse(CountSeatnumericUpDown.Text);
            int int2 = int.Parse(PricetextBox.Text);
            int idSet = dataGridView1.CurrentRow.Index;
            string query = $"DELETE FROM [HotelDB].[dbo].[Номера] WHERE [Тип комнаты] = '{typeRoomcomboBox.Text}' and [Количество мест] = {int1} and [Цена за сутки] = {int2}";
            LoadWorkers(query);
            LoadWorkers(allView);
        }
    }
}
