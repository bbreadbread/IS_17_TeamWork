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
    public partial class FormAdmin_WhoIsWhere : Form
    {

        public FormAdmin_WhoIsWhere()
        {
            InitializeComponent();
            LoadPanels();
            refreshTimer.Start();
        }

        private void LoadPanels()
        {
            this.Controls.Clear();
            string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
            string query = "SELECT [ID_Номера], [Статус],[Закрепленная горничная] FROM [HotelDB].[dbo].[Номера];";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                    return;
                }
            }



            int panelSize = 80;
            int panelsPerRow = 8;
            int spacing = 10;

            int totalWidth = panelsPerRow * (panelSize + spacing) - spacing;
            int totalHeight = ((dataTable.Rows.Count + panelsPerRow - 1) / panelsPerRow) * (panelSize + spacing) - spacing;

            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int roomId = Convert.ToInt32(dataTable.Rows[i]["ID_Номера"]);
                string status = dataTable.Rows[i]["Статус"].ToString();
                string maidHad = dataTable.Rows[i]["Закрепленная горничная"].ToString();
                // Создаем новую панель
                Panel panel = new Panel();
                panel.Size = new Size(panelSize, panelSize);
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Устанавливаем цвет панели в зависимости от статуса
                switch (status)
                {
                    case "Доступно":
                        if (maidHad == "") panel.BackColor = Color.Green;
                        else panel.BackColor = Color.Chartreuse;
                        break;
                    case "Забронировано":
                        if (maidHad == "") panel.BackColor = Color.Orange;
                        else panel.BackColor = Color.Yellow;
                        break;
                    case "Тех. обслуживание":
                        panel.BackColor = Color.Red;
                        break;
                    default:
                        panel.BackColor = Color.LightGray;
                        break;
                }

                // Добавляем номер комнаты на панель
                Label label = new Label();
                label.Text = roomId.ToString();
                label.AutoSize = true;
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.ForeColor = Color.White;

                label.Location = new Point(10, 10);
                panel.Controls.Add(label);
                this.Text = "Закрепление комнаты " + $"{roomId}";
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;
                panel.Location = new Point(
                    startX + col * (panelSize + spacing), // X
                    startY + row * (panelSize + spacing)  // Y
                );

                // Добавляем панель на форму
                this.Controls.Add(panel);

                // Обработка клика по панели
                panel.Click += (sender, e) =>
                {

                    string query2 = $@"SELECT 
                                        b.[ID_Номера] AS Номер,
                                        g.[Имя] AS Имя,
                                        g.[Фамилия] AS Фамилия
                                    FROM 
                                        [HotelDB].[dbo].[Бронирования] b
                                    JOIN 
                                        [HotelDB].[dbo].[Работники] g ON b.[ID_Горничной] = g.[ID_Пользователя]
                                    WHERE 
                                        b.[Статус бронирования] = 'Подтверждено'
                                    AND b.[ID_Номера] = {roomId};";

                    string MaidName = "";
                    string MaidSurname = "";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query2, connection))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(command);

                                SqlDataReader reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    MaidName = reader["Имя"].ToString();
                                    MaidSurname = reader["Фамилия"].ToString();
                                }
                                reader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                            return;
                        }
                    }
                    ///Color [Yellow]
                    string colorPanel = panel.BackColor.ToString();
                    CustomMessageBox customMessageBox = new CustomMessageBox(MaidName, MaidSurname, roomId, colorPanel);
                    DialogResult result = customMessageBox.ShowDialog();

                    if (result == DialogResult.OK && panel.BackColor == Color.Green)
                    {
                        int idSelected = customMessageBox.IdSelected;

                        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
                        string query = $"UPDATE [HotelDB].[dbo].[Номера] " +
                                       $"SET [Статус] = 'Забронировано' " +
                                       $"WHERE [ID_Номера] = {idSelected};";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_Номера", idSelected);
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Статус номера успешно обновлен.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ошибка: номер не найден или не обновлен.");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                            }
                        }
                    }
                };

               
            }
        }

        private void FormAdmin_WhoIsWhere_Load(object sender, EventArgs e)
        {

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            LoadPanels();
        }

        private void FormAdmin_WhoIsWhere_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshTimer.Stop();
        }
    }
}