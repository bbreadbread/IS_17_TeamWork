using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_17
{
    public partial class CustomMessageBox : Form
    {

        public int IdSelected { get; private set; }
        List<string[]> listMaid;
        int roomId;
        string allView = $"SELECT TOP (1000) [ID_Пользователя], [Имя], [Фамилия] FROM [HotelDB].[dbo].[Работники] where [Роль] = 'Горничная'";
        string query = "";
        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
        string colorPanel;
        public CustomMessageBox(string name, string surname, int roomId, string colorPanel)
        {
            InitializeComponent();
            this.colorPanel = colorPanel;
            this.roomId = roomId;
            LoadMaidList();

            labelName.Text = name;
            labelSurname.Text = surname;

            listBoxReservation.DrawItem += ListBox_DrawItem;

            //// Добавление ListBox на форму
            //this.Controls.Add(listBox);
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Проверяем, выделен ли элемент
            if (e.Index >= 0)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    // Устанавливаем цвет выделения
                    e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#E7D4F7")), e.Bounds);
                }
                else
                {
                    // Устанавливаем цвет фона для невыделенных элементов
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                }

                // Рисуем текст
                e.Graphics.DrawString(listBoxReservation.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void LoadMaidList()
        {

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
                        listBoxReservation.Items.Add($"{id}, {name}, {surname}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }


            switch (colorPanel)
            {
                case "Color [Green]":
                    buttonUnassign.Enabled = false;
                    break;

                case "Color [Yellow]":
                    buttonUnassign.Enabled = true;
                    buttonReservation.Text = "Поменять ответственного за комнату";
                    break;

                case "Color [Red]":
                    string message = "Сообщение от горничной: [текст сообщения]";
                    MessageBox.Show(message);
                    break;

                default:
                    break;
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            IdSelected = int.Parse(listMaid[listBoxReservation.SelectedIndex][0]);

            if (listBoxReservation.SelectedIndex >= 0)
            {
                query = $@"
                        IF EXISTS (SELECT 1 FROM [HotelDB].[dbo].[Бронирования] WHERE [ID_Номера] = {roomId})
                        BEGIN
                            UPDATE [HotelDB].[dbo].[Бронирования]
                            SET [ID_Горничной] = {IdSelected}
                            WHERE [ID_Номера] = {roomId};

                            UPDATE [HotelDB].[dbo].[Номера]
                            SET [Закрепленная горничная] = {IdSelected}
                            WHERE [ID_Номера] = {roomId};
                        END
                        ELSE
                        BEGIN
                            UPDATE [HotelDB].[dbo].[Номера]
                            SET [Закрепленная горничная] = {IdSelected}
                            WHERE [ID_Номера] = {roomId};
                        END";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены.");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось обновить данные. Возможно, номер не найден.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите горничную.");
            }
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void buttonUnassign_Click(object sender, EventArgs e)
        {
            query = $@"UPDATE[HotelDB].[dbo].[Бронирования]
                                    SET[ID_Горничной] = NULL
                                    WHERE[ID_Номера] = {roomId};

                           UPDATE[HotelDB].[dbo].[Номера]
                                    SET[Закрепленная горничная] = NULL
                                WHERE[ID_Номера] = {roomId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить данные. Возможно, номер не найден.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
