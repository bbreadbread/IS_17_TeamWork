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
        int idThisMaid = 8;
        List<string[]> preferencesList = new List<string[]>();
        public FormMaid_Rooms()
        {
            InitializeComponent();
            LoadPanels();
        }
        private void LoadPanels()
        {
            flowLayoutPanel1.Controls.Clear();

            string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
            query = $"SELECT [ID_Номера], [Статус], [Закрепленная горничная] FROM [HotelDB].[dbo].[Номера] WHERE [Закрепленная горничная] = {idThisMaid};";

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
                        Бронирования.[ID_Горничной] = 3;";


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

                int i = 0;
                // Создаем панели на основе полученных данных
                foreach (DataRow row in dataTable1.Rows)
                {
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

                    Label label3 = new Label();
                    if (preferencesList[i][1] != null) label3.Text = $"Время уборки: {preferencesList[i][1]}";
                    else label3.Text = $"Время уборки: 10:00 - 12:00";
                    i++;

                    label3.Location = new Point(200, 20);
                    label3.AutoSize = true;
                    panel.Controls.Add(label3);
                    
                    Button button = new Button();
                    button.Text = "Действие";
                    button.Tag = row["ID_Номера"];
                    button.Width = 256;
                    button.Height = 48;
                    button.Location = new Point(flowLayoutPanel1.Width / 3, 40);
                    panel.Controls.Add(button);
                    flowLayoutPanel1.Controls.Add(panel);

                    button.Click += (sender, e) =>
                    {
                        Button clickedButton = sender as Button;
                        if (clickedButton != null)
                        {
                            MaidCustomMessageBox customMessageBox = new MaidCustomMessageBox();
                            DialogResult result = customMessageBox.ShowDialog();

                            if (result == DialogResult.OK)
                            {

                            }
                            else
                            {

                            }
                        }
                    };
                }
            }
        }
    }
}
