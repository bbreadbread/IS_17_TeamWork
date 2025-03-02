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
            textBox1 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(528, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.Location = new Point(528, 399);
            button2.Name = "button2";
            button2.Size = new Size(227, 40);
            button2.TabIndex = 22;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(528, 324);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 21;
            label5.Text = "Роль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(528, 264);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 20;
            label4.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(528, 203);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 19;
            label3.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(528, 140);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Почта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(528, 81);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 17;
            label1.Text = "Фамилия Имя";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 347);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox4.Location = new Point(528, 287);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 26);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox3.Location = new Point(528, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 26);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox2.Location = new Point(528, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 26);
            textBox2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 527);
            dataGridView1.TabIndex = 33;
            // 
            // FormAdmin_Workers_Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 527);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_Workers_Create";
            Text = "FormAdmin_Workers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}