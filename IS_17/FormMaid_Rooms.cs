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
    public partial class FormMaid_Rooms : Form
    {
        string query = "" , timeClean = "", preferences = "";
        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
        public static int IdThisMaid { get; set; }
        public static string NameThisMaid { get; set; }
        public static string SurameThisMaid { get; set; }
        public static string Room { get; set; }

        List<string[]> preferencesList = new List<string[]>();
        public FormMaid_Rooms()
        {
            IdThisMaid = FormMaid.IdSelected;
            InitializeComponent();
            LoadPanels();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT TOP (1000) [Имя], [Фамилия] FROM [HotelDB].[dbo].[Работники] WHERE [ID_Пользователя] = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", IdThisMaid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NameThisMaid = reader["Имя"].ToString();
                            SurameThisMaid = reader["Фамилия"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadPanels()
        {
            flowLayoutPanel1.Controls.Clear();
           
            query = $"SELECT [ID_Номера], [Статус], [Закрепленная горничная] FROM [HotelDB].[dbo].[Номера] WHERE [Закрепленная горничная] = {IdThisMaid};";

            DataTable dataTable1 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable1);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Room = reader["ID_Номера"].ToString();
                            }
                        }

                    }
                    query = $@"SELECT 
                        Бронирования.[ID_Номера],
                        Гости.[Предпочтения],
                        Гости.[Время уборки]
                    FROM 
                        Бронирования
                    INNER JOIN 
                        Гости
                    ON 
                        Бронирования.[ID_Гостя] = Гости.[ID_Гостя]
                    WHERE 
                        Бронирования.[ID_Горничной] = {IdThisMaid};";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            preferences = reader["Предпочтения"].ToString();
                            timeClean = reader["Время уборки"].ToString();
                            string[] str = { preferences, timeClean };
                            preferencesList.Add(str);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                    return;
                }

                using (StreamWriter stream = new StreamWriter("cleaningListToday.txt"))
                {
                    int j = 0;
                    foreach (string[] str in preferencesList)
                        stream.WriteLine(str[0] + " " + str[1]);
                }
                // Создаем панели на основе полученных данных
                int i = 0; // Индекс для preferencesList

                foreach (DataRow row in dataTable1.Rows)
                {
                    bool isCleaning = false;

                    Panel panel = new Panel();
                    panel.Size = new Size(flowLayoutPanel1.Width - 5, 100);
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    Label label1 = new Label();
                    label1.Text = $"Номер {row[0]}";
                    label1.Location = new Point(10, 10);
                    panel.Controls.Add(label1);

                    Label label2 = new Label();
                    label2.Text = $"Статус: {row[1]}";
                    label2.Location = new Point(10, 40);
                    label2.AutoSize = true;
                    panel.Controls.Add(label2);

                    string time = "";
                    Label label3 = new Label();
                    if (isCleaning == false)
                    {
                        if (preferencesList.Count > i)
                        {
                            time = preferencesList[i][0];
                            label3.Text = $"Время уборки: {preferencesList[i][1]}";
                        }
                        else
                        {
                            label3.Text = $"Время уборки: 10:00 - 12:00";
                        }
                    }
                    else
                    {
                        label3.Text = $"Номер убран: {preferencesList[i][1]}";
                    }
                    label3.Location = new Point(200, 20);
                    label3.AutoSize = true;
                    panel.Controls.Add(label3);

                    Label label4 = new Label();
                    if (isCleaning == false)
                    {
                        if (preferencesList.Count > i)
                        {
                            label4.Text = $"Предпочтения: {preferencesList[i][0]}";
                        }
                        else
                        {
                            label4.Text = $"Предпочтения: -";
                        }
                    }
                    else
                    {
                        // Логика для убранного номера
                    }
                    label4.Location = new Point(400, 20);
                    label4.AutoSize = true;
                    panel.Controls.Add(label4);

                    Button button = new Button();
                    button.Text = "Отметить уборку";
                    button.Tag = row["ID_Номера"];
                    button.Width = 256;
                    button.Height = 48;
                    button.Location = new Point(flowLayoutPanel1.Width - 265, 40);
                    panel.Controls.Add(button);
                    flowLayoutPanel1.Controls.Add(panel);

                    button.Click += (sender, e) =>
                    {
                        Button clickedButton = sender as Button;
                        if (clickedButton != null)
                        {
                            MaidCustomMessageBox customMessageBox = new MaidCustomMessageBox(isCleaning);
                            DialogResult result = customMessageBox.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                label3.Text = $"Номер убран!";
                                button.Enabled = false;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                label3.Text = $"Номер убран! Тех. Поломка зафиксирована";
                                button.Enabled = false;
                            }
                        }
                    };

                    i++;
                }
            }
        }
    }
}
