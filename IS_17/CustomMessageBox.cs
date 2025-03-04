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
    public partial class CustomMessageBox : Form
    {
        public int IdSelected { get; private set; }
        List<string[]> listMaid;
        string allView = $"SELECT TOP (1000) [ID_Пользователя], [Имя], [Фамилия] FROM [HotelDB].[dbo].[Работники] where [Роль] = 'Горничная'";
        public CustomMessageBox()
        {
            InitializeComponent();

            string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(allView, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    listMaid = new List<string[]>();
                    while (reader.Read())
                    {
                        string id = reader["ID_Пользователя"].ToString();
                        string name = reader["Имя"].ToString();
                        string surname = reader["Фамилия"].ToString();
                        string[] str = { id, name, surname };

                        listMaid.Add(str);
                        listBoxReservation.Items.Add($"{id} , {name}, {surname}");
                    }
                    reader.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            if (listBoxReservation.SelectedIndex >= 0)
            {
                IdSelected = int.Parse(listMaid[listBoxReservation.SelectedIndex][0]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите горничную.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxReservation.SelectedIndex >= 0)
            {
                IdSelected = int.Parse(listMaid[listBoxReservation.SelectedIndex][0]);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите горничную.");
            }
        }
    }
}
