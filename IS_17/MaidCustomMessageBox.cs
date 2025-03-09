using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace IS_17
{
    public partial class MaidCustomMessageBox : Form
    {
        bool isClening = false;
        public string messageMaid { get; private set; }
        private int roomId;

        string connectionString = "Data Source=HOME-PC;Initial Catalog=HotelDB;Integrated Security=True";
        public MaidCustomMessageBox(bool isCleaning, int roomId)
        {
            this.isClening = isCleaning;
            this.roomId = roomId;

            InitializeComponent();

            MessageRichTextBox.Text = "Опишите причину тряски, по объему превышающую 15 символов.";
            MessageRichTextBox.ForeColor = SystemColors.GrayText;
            MessageRichTextBox.Enter += MessageRichTextBox_Enter;
            MessageRichTextBox.Leave += MessageRichTextBox_Leave;

        }

        private void MessageRichTextBox_Enter(object? sender, EventArgs e)
        {
            if (MessageRichTextBox.Text == "Опишите причину тряски, по объему превышающую 15 символов.")
            {
                MessageRichTextBox.Text = "";
                MessageRichTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void MessageRichTextBox_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageRichTextBox.Text))
            {
                MessageRichTextBox.Text = "Опишите причину тряски, по объему превышающую 15 символов.";
                MessageRichTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        //отмечена уборка
        private void radioButtonCleaning_CheckedChanged(object sender, EventArgs e)
        {
            MessageRichTextBox.Enabled = false;
            buttonSend.Text = "Отметить";

        }
        //отмечена тех.поломка
        private void radioButtonBreaking_CheckedChanged(object sender, EventArgs e)
        {
            MessageRichTextBox.Enabled = true;
            buttonSend.Text = "Отправить";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (radioButtonCleaning.Checked)
            {
                isClening = true;

                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageRichTextBox.Enabled = false;
            }
            else if (radioButtonBreaking.Checked)
            {
                if (MessageRichTextBox.Text.Length > 15)
                {
                    messageMaid = MessageRichTextBox.Text;

                    CustomMessageBox.MessageMaid = messageMaid;

                    SendMessage("aggata.serggeeva@mail.ru");

                    UpdateRoomStatusToMaintenance();

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не описали причину тряски или причина тряски незначительна по объему");
                }
            }
        }

        private void UpdateRoomStatusToMaintenance()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [HotelDB].[dbo].[Номера] SET [Статус] = 'Тех. обслуживание' WHERE [ID_Номера] = @roomId"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void SendMessage(string email)
        {
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("agata_andreevna@mail.ru", "ExrbrJMgNfELNKuWcPS3");

            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("agata_andreevna@mail.ru");
            Message.To.Add(new MailAddress($"{email}"));
            Message.Subject = "Сообщение о технических неполадках!";
            Message.Body = $"Горничная {FormMaid_Rooms.NameThisMaid} {FormMaid_Rooms.SurameThisMaid} сообщает о тех. неполадках в номере {roomId}: {messageMaid}!";

            try
            {
                Smtp.Send(Message);
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"Ошибка при отправке письма: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private bool isDragging = false;
        private Point startPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = panel1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-startPoint.X, -startPoint.Y);
                this.Location = newPoint;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
