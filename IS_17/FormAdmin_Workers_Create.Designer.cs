namespace IS_17
{
    partial class FormAdmin_Workers_Create
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
            NametextBox = new TextBox();
            buttonAddWorkers = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TypecomboBox = new ComboBox();
            NumbertextBox = new TextBox();
            EmailtextBox = new TextBox();
            dataGridView1 = new DataGridView();
            SurnametextBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(524, 157);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(227, 23);
            NametextBox.TabIndex = 13;
            // 
            // buttonAddWorkers
            // 
            buttonAddWorkers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonAddWorkers.Location = new Point(524, 393);
            buttonAddWorkers.Name = "buttonAddWorkers";
            buttonAddWorkers.Size = new Size(227, 40);
            buttonAddWorkers.TabIndex = 22;
            buttonAddWorkers.Text = "Добавить";
            buttonAddWorkers.UseVisualStyleBackColor = true;
            buttonAddWorkers.Click += buttonAddWorkers_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(524, 319);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 21;
            label5.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(524, 256);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 19;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(524, 193);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Почта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(524, 134);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 17;
            label1.Text = "Имя";
            // 
            // TypecomboBox
            // 
            TypecomboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            TypecomboBox.FormattingEnabled = true;
            TypecomboBox.Items.AddRange(new object[] { "Горничная", "Портье", "Завхоз" });
            TypecomboBox.Location = new Point(524, 342);
            TypecomboBox.Name = "TypecomboBox";
            TypecomboBox.Size = new Size(227, 28);
            TypecomboBox.TabIndex = 16;
            // 
            // NumbertextBox
            // 
            NumbertextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            NumbertextBox.Location = new Point(524, 279);
            NumbertextBox.Name = "NumbertextBox";
            NumbertextBox.Size = new Size(227, 26);
            NumbertextBox.TabIndex = 14;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            EmailtextBox.Location = new Point(524, 216);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(227, 26);
            EmailtextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 531);
            dataGridView1.TabIndex = 33;
            // 
            // SurnametextBox
            // 
            SurnametextBox.Location = new Point(524, 98);
            SurnametextBox.Name = "SurnametextBox";
            SurnametextBox.Size = new Size(227, 23);
            SurnametextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(524, 75);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 35;
            label4.Text = "Фамилия";
            // 
            // FormAdmin_Workers_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 531);
            Controls.Add(SurnametextBox);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(NametextBox);
            Controls.Add(buttonAddWorkers);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TypecomboBox);
            Controls.Add(NumbertextBox);
            Controls.Add(EmailtextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_Workers_Create";
            Text = "FormAdmin_Workers";
            Load += FormAdmin_Workers_Create_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NametextBox;
        private Button buttonAddWorkers;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox TypecomboBox;
        private TextBox NumbertextBox;
        private TextBox EmailtextBox;
        private DataGridView dataGridView1;
        private TextBox SurnametextBox;
        private Label label4;
    }
}