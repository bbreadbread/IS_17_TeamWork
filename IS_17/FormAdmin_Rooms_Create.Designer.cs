namespace IS_17
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountSeatnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.Location = new Point(530, 362);
            button3.Name = "button3";
            button3.Size = new Size(227, 40);
            button3.TabIndex = 31;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(530, 283);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 30;
            label8.Text = "Статус комнаты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(530, 222);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 29;
            label9.Text = "Цена за сутки";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.Location = new Point(530, 159);
            label10.Name = "label10";
            label10.Size = new Size(156, 20);
            label10.TabIndex = 28;
            label10.Text = "Количество мест";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(530, 100);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 27;
            label11.Text = "Тип комнаты";
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Items.AddRange(new object[] { "Доступно" });
            StatuscomboBox.Location = new Point(530, 306);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(227, 28);
            StatuscomboBox.TabIndex = 25;
            // 
            // PricetextBox
            // 
            PricetextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            PricetextBox.Location = new Point(530, 245);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(227, 26);
            PricetextBox.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 531);
            dataGridView1.TabIndex = 32;
            // 
            // typeRoomComboBox
            // 
            typeRoomComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            typeRoomComboBox.FormattingEnabled = true;
            typeRoomComboBox.Items.AddRange(new object[] { "Стандарт", "Люкс" });
            typeRoomComboBox.Location = new Point(530, 123);
            typeRoomComboBox.Name = "typeRoomComboBox";
            typeRoomComboBox.Size = new Size(227, 28);
            typeRoomComboBox.TabIndex = 33;
            // 
            // CountSeatnumericUpDown
            // 
            CountSeatnumericUpDown.Location = new Point(530, 190);
            CountSeatnumericUpDown.Name = "CountSeatnumericUpDown";
            CountSeatnumericUpDown.Size = new Size(227, 23);
            CountSeatnumericUpDown.TabIndex = 34;
            // 
            // FormAdmin_Rooms_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 531);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_Rooms_Create";
            Text = "FormAdmin_Rooms_Create";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountSeatnumericUpDown).EndInit();
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
    }
}