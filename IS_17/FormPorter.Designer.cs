﻿namespace IS_17
{
    partial class FormPorter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            colorDialog1 = new ColorDialog();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(246, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(246, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(246, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(246, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(246, 219);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            textBox5.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(426, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 445);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(246, 252);
            button2.Name = "button2";
            button2.Size = new Size(154, 31);
            button2.TabIndex = 8;
            button2.Text = "Забронировать";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 41);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "бронирование";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 97);
            button4.Name = "button4";
            button4.Size = new Size(103, 26);
            button4.TabIndex = 10;
            button4.Text = "пользователи";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(216, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 27);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(216, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 27);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.Visible = false;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(246, 299);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 14;
            button1.Text = "Отменить бронь";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(220, 347);
            button5.Name = "button5";
            button5.Size = new Size(180, 31);
            button5.TabIndex = 15;
            button5.Text = "Сохранить изменения";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click_1;
            // 
            // FormPorter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 513);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormPorter";
            Text = "FormPorter";
            Load += FormPorter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ColorDialog colorDialog1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button5;
    }
}