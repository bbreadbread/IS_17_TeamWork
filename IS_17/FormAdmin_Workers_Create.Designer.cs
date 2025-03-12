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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_Workers_Create));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("Century Gothic", 12F);
            NametextBox.Location = new Point(518, 193);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(227, 27);
            NametextBox.TabIndex = 13;
            // 
            // buttonAddWorkers
            // 
            buttonAddWorkers.BackColor = Color.FromArgb(29, 29, 67);
            buttonAddWorkers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddWorkers.ForeColor = Color.White;
            buttonAddWorkers.Location = new Point(528, 439);
            buttonAddWorkers.Name = "buttonAddWorkers";
            buttonAddWorkers.Size = new Size(197, 31);
            buttonAddWorkers.TabIndex = 22;
            buttonAddWorkers.Text = "Добавить";
            buttonAddWorkers.UseVisualStyleBackColor = false;
            buttonAddWorkers.Click += buttonAddWorkers_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(518, 355);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 21;
            label5.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(518, 292);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 19;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(518, 229);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 18;
            label2.Text = "Почта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(518, 170);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 17;
            label1.Text = "Имя";
            // 
            // TypecomboBox
            // 
            TypecomboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypecomboBox.FormattingEnabled = true;
            TypecomboBox.Items.AddRange(new object[] { "Горничная", "Портье", "Завхоз" });
            TypecomboBox.Location = new Point(518, 378);
            TypecomboBox.Name = "TypecomboBox";
            TypecomboBox.Size = new Size(227, 29);
            TypecomboBox.TabIndex = 16;
            // 
            // NumbertextBox
            // 
            NumbertextBox.Font = new Font("Century Gothic", 12F);
            NumbertextBox.Location = new Point(518, 315);
            NumbertextBox.Name = "NumbertextBox";
            NumbertextBox.Size = new Size(227, 27);
            NumbertextBox.TabIndex = 14;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Font = new Font("Century Gothic", 12F);
            EmailtextBox.Location = new Point(518, 252);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(227, 27);
            EmailtextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 531);
            dataGridView1.TabIndex = 33;
            // 
            // SurnametextBox
            // 
            SurnametextBox.Font = new Font("Century Gothic", 12F);
            SurnametextBox.Location = new Point(518, 134);
            SurnametextBox.Name = "SurnametextBox";
            SurnametextBox.Size = new Size(227, 27);
            SurnametextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(518, 111);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 35;
            label4.Text = "Фамилия";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(562, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 61);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin_Workers_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 531);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}