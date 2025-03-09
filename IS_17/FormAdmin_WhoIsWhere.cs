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

            Panel bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = this.ClientSize.Height / 4;

            Panel topPanel = new Panel();
            topPanel.Dock = DockStyle.Fill;
            topPanel.AutoScroll = true;
            this.Controls.Add(topPanel);

            
            this.Controls.Add(bottomPanel);

            LoadDataIntoTopPanel(topPanel);

            LoadImageIntoBottomPanel(bottomPanel);
        }

        private void LoadDataIntoTopPanel(Panel topPanel)
        {
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

            int panelSize = 80; // Размер каждой панели
            int panelsPerRow = 8; // Количество панелей в строке
            int spacing = 10; // Расстояние между панелями

            // Рассчитываем общую ширину и высоту для всех панелей
            int totalWidth = panelsPerRow * (panelSize + spacing) - spacing;
            int totalHeight = ((dataTable.Rows.Count + panelsPerRow - 1) / panelsPerRow) * (panelSize + spacing) - spacing;

            // Рассчитываем начальные координаты для центрирования панелей на верхней панели
            int startX = (topPanel.ClientSize.Width - totalWidth) / 2; // Центрирование по горизонтали
            int startY = 10; // Отступ сверху

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int roomId = Convert.ToInt32(dataTable.Rows[i]["ID_Номера"]);
                string status = dataTable.Rows[i]["Статус"].ToString();
                string maidHad = dataTable.Rows[i]["Закрепленная горничная"].ToString();

                // Создаем новую панель
                Panel panel = new Panel();
                panel.Size = new Size(panelSize, panelSize);
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Добавляем номер комнаты на панель
                Label label = new Label();
                label.Text = roomId.ToString();
                label.AutoSize = true;
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.ForeColor = Color.White;

                // Устанавливаем цвет панели в зависимости от статуса
                switch (status)
                {
                    case "Доступно":
                        if (maidHad == "")
                        {
                            panel.BackColor = Color.White;
                            label.ForeColor = Color.Black;
                        }
                        else panel.BackColor = Color.FromArgb(243, 233, 251);
                        break;
                    case "Забронировано":
                        if (maidHad == "") panel.BackColor = Color.FromArgb(100, 100, 185);
                        else panel.BackColor = Color.FromArgb(158, 158, 209);
                        break;
                    case "Тех. обслуживание":
                        panel.BackColor = Color.FromArgb(238, 165, 176);
                        break;
                    default:
                        panel.BackColor = Color.White;
                        break;
                }

                label.Location = new Point(10, 10);
                panel.Controls.Add(label);

                // Рассчитываем позицию панели
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;
                panel.Location = new Point(
                    startX + col * (panelSize + spacing), // X
                    startY + row * (panelSize + spacing)  // Y
                );

                // Добавляем панель на верхнюю панель
                topPanel.Controls.Add(panel);

                // Обработка клика по панели
                panel.Click += (sender, e) =>
                {

                    string query2 = $@"SELECT 
                             n.[ID_Номера] AS Номер,
                             g.[Имя] AS Имя,
                             g.[Фамилия] AS Фамилия
                         FROM 
                             [HotelDB].[dbo].[Номера] n
                         LEFT JOIN 
                             [HotelDB].[dbo].[Работники] g ON n.[Закрепленная горничная] = g.[ID_Пользователя]
                         WHERE 
                             n.[ID_Номера] = {roomId};";

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
                    ///Color [A=255, R=238, G=165, B=176]
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

                                    if (rowsAffected !> 0)
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

        private void LoadImageIntoBottomPanel(Panel bottomPanel)
        {
            // Загружаем картинку
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill; // Картинка занимает всю нижнюю панель
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Растягиваем картинку

            // Укажите путь к вашей картинке
            string imagePath = "help.jpg";
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Картинка не найдена.");
            }

            // Добавляем PictureBox на нижнюю панель
            bottomPanel.Controls.Add(pictureBox);
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