﻿namespace IS_17
{
    partial class FormAdmin_Rooms_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_Rooms_Create));
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            StatuscomboBox = new ComboBox();
            PricetextBox = new TextBox();
            dataGridView1 = new DataGridView();
            typeRoomComboBox = new ComboBox();
            CountSeatnumericUpDown = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountSeatnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 29, 67);
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(635, 478);
            button3.Name = "button3";
            button3.Size = new Size(174, 42);
            button3.TabIndex = 31;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(596, 383);
            label8.Name = "label8";
            label8.Size = new Size(183, 23);
            label8.TabIndex = 30;
            label8.Text = "Статус комнаты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(596, 308);
            label9.Name = "label9";
            label9.Size = new Size(156, 23);
            label9.TabIndex = 29;
            label9.Text = "Цена за сутки";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(596, 232);
            label10.Name = "label10";
            label10.Size = new Size(189, 23);
            label10.TabIndex = 28;
            label10.Text = "Количество мест";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label11.Location = new Point(596, 153);
            label11.Name = "label11";
            label11.Size = new Size(139, 23);
            label11.TabIndex = 27;
            label11.Text = "Тип комнаты";
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Items.AddRange(new object[] { "Доступно" });
            StatuscomboBox.Location = new Point(597, 409);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(259, 31);
            StatuscomboBox.TabIndex = 25;
            StatuscomboBox.DrawItem += StatuscomboBox_DrawItem;
            // 
            // PricetextBox
            // 
            PricetextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PricetextBox.Location = new Point(597, 334);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(259, 32);
            PricetextBox.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(527, 602);
            dataGridView1.TabIndex = 32;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // typeRoomComboBox
            // 
            typeRoomComboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typeRoomComboBox.FormattingEnabled = true;
            typeRoomComboBox.Items.AddRange(new object[] { "Стандарт", "Люкс" });
            typeRoomComboBox.Location = new Point(596, 179);
            typeRoomComboBox.Name = "typeRoomComboBox";
            typeRoomComboBox.Size = new Size(259, 31);
            typeRoomComboBox.TabIndex = 33;
            typeRoomComboBox.DrawItem += typeRoomComboBox_DrawItem;
            // 
            // CountSeatnumericUpDown
            // 
            CountSeatnumericUpDown.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountSeatnumericUpDown.Location = new Point(596, 258);
            CountSeatnumericUpDown.Name = "CountSeatnumericUpDown";
            CountSeatnumericUpDown.Size = new Size(259, 32);
            CountSeatnumericUpDown.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(644, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 81);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin_Rooms_Create
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 602);
            Controls.Add(pictureBox1);
            Controls.Add(CountSeatnumericUpDown);
            Controls.Add(typeRoomComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(StatuscomboBox);
            Controls.Add(PricetextBox);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_Rooms_Create";
            Text = "FormAdmin_Rooms_Create";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountSeatnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox StatuscomboBox;
        private TextBox PricetextBox;
        private DataGridView dataGridView1;
        private ComboBox typeRoomComboBox;
        private NumericUpDown CountSeatnumericUpDown;
        private PictureBox pictureBox1;
    }
}