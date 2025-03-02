using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_17
{
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contin = 0;
            string email = emailTB.Text;
            string pattern = @"^(?!.*\.\.)(?!.*\.$)(?!^\.)[a-zA-Z]+[a-zA-Z0-9]{0,3}(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,6}$";


            if (Regex.IsMatch(email, pattern))
            {
                contin++;
            }
            else
            {
                emailTB.BackColor = Color.FromArgb(238, 165, 176);
                contin--;
            }

            string password = passTB.Text;

            string validationMessage = ValidatePassword(password);

            if (string.IsNullOrEmpty(validationMessage))
            {

                contin++;
            }
            else
            {
                passTB.BackColor = Color.FromArgb(238, 165, 176);
                passShow.BackColor = Color.FromArgb(238, 165, 176);
                contin--;
            }

            if (contin == 2)
            {
                MessageBox.Show("Сделайте переход на форму, соответсвующую роли чела", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //это в случае, когда пользователь захочет ввести данные - мы убираем подсказку
        private void emailTB_Enter(object sender, EventArgs e)
        {
            emailTB.BackColor = Color.FromArgb(224, 214, 233);
            if (emailTB.Text == "Почта")
            {
                emailTB.Text = "";
                emailTB.ForeColor = Color.Black;

                //emailTB.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        //это в случае, когда пользователь оставит поле для ввода пустым - мы возвращаем подказку
        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                emailTB.Text = "Почта";
                emailTB.ForeColor = Color.Gray;
            }

            emailTB.BackColor = Color.White;
        }

        //это в случае, когда пользователь захочет ввести данные - мы убираем подсказку
        private void passTB_Enter(object sender, EventArgs e)
        {
            passTB.BackColor = Color.FromArgb(224, 214, 233);
            passShow.BackColor = Color.FromArgb(224, 214, 233);
            if (passTB.Text == "Пароль")
            {
                passTB.Text = "";
                passTB.ForeColor = Color.Black;
                passTB.PasswordChar = '·';
                //passTB.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        //это в случае, когда пользователь оставит поле для ввода пустым - мы возвращаем подказку
        private void passTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passTB.Text))
            {
                passTB.Text = "Пароль";
                passTB.ForeColor = Color.Gray;
                passTB.PasswordChar = '\0';

            }
            passTB.BackColor = Color.White;
            passShow.BackColor = Color.White;
        }

        private void passShow_MouseDown(object sender, MouseEventArgs e)
        {
            passTB.PasswordChar = '\0';
        }

        private void passShow_MouseUp(object sender, MouseEventArgs e)
        {
            if (passTB.Text == "Пароль")
                passTB.PasswordChar = '\0';
            else
                passTB.PasswordChar = '·';
        }

        private string ValidatePassword(string password)
        {
            // Проверяем длину пароля
            if (password.Length < 8)
            {
                return "0";
            }

            // Проверяем наличие цифр
            if (!password.Any(char.IsDigit))
            {
                return "0";
            }

            // Проверяем наличие специальных символов
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "0";
            }

            // Проверяем наличие букв разного регистра
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                return "0";
            }

            // Проверяем, чтобы не было более двух подряд идущих букв, которые на клавиатуре стоят рядом
            string keyboardLayout = "qwertyuiopasdfghjklzxcvbnm";
            string keyboardLayoutUpper = keyboardLayout.ToUpper();

            for (int i = 0; i < password.Length - 2; i++)
            {
                char first = password[i];
                char second = password[i + 1];
                char third = password[i + 2];

                if (IsAdjacentOnKeyboard(first, second, keyboardLayout) && IsAdjacentOnKeyboard(second, third, keyboardLayout))
                {
                    return "0";
                }

                if (IsAdjacentOnKeyboard(first, second, keyboardLayoutUpper) && IsAdjacentOnKeyboard(second, third, keyboardLayoutUpper))
                {
                    return "0";
                }
            }
            return string.Empty;
        }

        private bool IsAdjacentOnKeyboard(char first, char second, string keyboardLayout)
        {
            int index1 = keyboardLayout.IndexOf(first);
            int index2 = keyboardLayout.IndexOf(second);

            return index1 != -1 && index2 != -1 && Math.Abs(index1 - index2) == 1;
        }

        private void Authoriz_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            //пишем подсказку для пользователя
            emailTB.Text = "Почта";
            emailTB.ForeColor = Color.Gray;


            //пишем подсказку для пользователя
            passTB.Text = "Пароль";
            passTB.ForeColor = Color.Gray;
            passTB.PasswordChar = '\0';
        }
    }
}
