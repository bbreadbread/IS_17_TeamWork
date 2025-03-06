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

namespace IS_17
{
    public partial class MaidCustomMessageBox : Form
    {
        bool isClening = false;
        public string messageMaid { get; private set; }
        public MaidCustomMessageBox(bool isCleaning)
        {
            this.isClening = isCleaning;
            InitializeComponent();
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
                MessageRichTextBox.Enabled = false ;
            }
            else if (radioButtonBreaking.Checked)
            {
                if (MessageRichTextBox.Text.Length > 15)
                {
                    messageMaid = MessageRichTextBox.Text;

                    using (StreamWriter streamReader = new StreamWriter("messagesMaids.txt"))
                    {
                        streamReader.WriteLine(FormMaid_Rooms.IdThisMaid + " " + messageMaid);
                        streamReader.Close();
                    }

                    SendMessage("aggata.serggeeva@mail.ru");

                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не описали причину тряски");
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
            Message.Body = $"Горничная {FormMaid_Rooms.NameThisMaid} {FormMaid_Rooms.SurameThisMaid} сообщает о тех. неполадках в номере {FormMaid_Rooms.Room}: {messageMaid}!";

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
    }
}
