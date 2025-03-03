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
        }

        private void LoadPanels()
        {
            
        }

        private void FormAdmin_WhoIsWhere_Load(object sender, EventArgs e)
        {
            // Подключение к базе данных
            string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True"; // Замените на вашу строку подключения
            string query = "SELECT [ID_Номера], [Статус] FROM [HotelDB].[dbo].[Номера];"; // Запрос для получения данных

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable); // Заполняем DataTable данными из базы
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                    return;
                }
            }

            // Создаем панели
            int panelSize = 80; // Размер панели (80x80)
            int panelsPerRow = 8; // Количество панелей в ряду
            int spacing = 10; // Расстояние между панелями

            // Вычисляем общую ширину и высоту сетки панелей
            int totalWidth = panelsPerRow * (panelSize + spacing) - spacing;
            int totalHeight = ((dataTable.Rows.Count + panelsPerRow - 1) / panelsPerRow) * (panelSize + spacing) - spacing;

            // Центрируем сетку панелей на форме
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // Получаем данные о номере
                int roomId = Convert.ToInt32(dataTable.Rows[i]["ID_Номера"]);
                string status = dataTable.Rows[i]["Статус"].ToString();

                // Создаем новую панель
                Panel panel = new Panel();
                panel.Size = new Size(panelSize, panelSize);
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Устанавливаем цвет панели в зависимости от статуса
                switch (status)
                {
                    case "Доступно":
                        panel.BackColor = Color.Green;
                        break;
                    case "Забронировано":
                        panel.BackColor = Color.Yellow;
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
                label.Text = roomId.ToString(); // Номер комнаты
                label.AutoSize = true;
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.Location = new Point(10, 10); // Позиция метки на панели
                panel.Controls.Add(label);

                // Вычисляем позицию панели
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
                    MessageBox.Show($"Вы выбрали комнату {roomId} (Статус: {status})");
                };
            }
        }
    }
}