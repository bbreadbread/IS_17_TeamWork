namespace IS_17
{
    partial class FormZavhoz
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZavhoz));
            dataGridView1 = new DataGridView();
            sidebar = new FlowLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            menuConteiner = new FlowLayoutPanel();
            panel5 = new Panel();
            menu = new Button();
            panel6 = new Panel();
            button_EditPassword = new Button();
            panel7 = new Panel();
            button_EditData = new Button();
            button3 = new Button();
            panel9 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label = new Label();
            btnHum = new PictureBox();
            button4 = new Button();
            textBox1 = new TextBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            labell = new Label();
            pictureBox6 = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pictureBox7 = new PictureBox();
            menuTransition1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            menuConteiner.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 117);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(514, 470);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(29, 29, 67);
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(button1);
            sidebar.Controls.Add(menuConteiner);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel3);
            sidebar.Location = new Point(0, 55);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(62, 535);
            sidebar.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(29, 29, 67);
            button7.Font = new Font("Century Gothic", 13.8F);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(256, 48);
            button7.TabIndex = 4;
            button7.TabStop = false;
            button7.Text = "          Инвентарь";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(29, 29, 67);
            button8.Font = new Font("Century Gothic", 13.8F);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 57);
            button8.Name = "button8";
            button8.Size = new Size(256, 48);
            button8.TabIndex = 5;
            button8.TabStop = false;
            button8.Text = "Поставщики";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 29, 67);
            button1.Font = new Font("Century Gothic", 13.8F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 111);
            button1.Name = "button1";
            button1.Size = new Size(256, 48);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "            Отчёты";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuConteiner
            // 
            menuConteiner.BackColor = Color.FromArgb(29, 29, 67);
            menuConteiner.Controls.Add(panel5);
            menuConteiner.Controls.Add(panel6);
            menuConteiner.Controls.Add(panel7);
            menuConteiner.Location = new Point(3, 165);
            menuConteiner.Name = "menuConteiner";
            menuConteiner.Size = new Size(256, 48);
            menuConteiner.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(menu);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 48);
            panel5.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(29, 29, 67);
            menu.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(256, 48);
            menu.TabIndex = 2;
            menu.TabStop = false;
            menu.Text = "            Настройки";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button_EditPassword);
            panel6.Location = new Point(3, 57);
            panel6.Name = "panel6";
            panel6.Size = new Size(256, 48);
            panel6.TabIndex = 4;
            // 
            // button_EditPassword
            // 
            button_EditPassword.BackColor = Color.FromArgb(29, 29, 67);
            button_EditPassword.Dock = DockStyle.Fill;
            button_EditPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_EditPassword.ForeColor = Color.White;
            button_EditPassword.ImageAlign = ContentAlignment.MiddleLeft;
            button_EditPassword.Location = new Point(0, 0);
            button_EditPassword.Name = "button_EditPassword";
            button_EditPassword.Size = new Size(256, 48);
            button_EditPassword.TabIndex = 2;
            button_EditPassword.TabStop = false;
            button_EditPassword.Text = "Изменить пароль";
            button_EditPassword.UseVisualStyleBackColor = false;
            button_EditPassword.Click += button_EditPassword_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_EditData);
            panel7.Location = new Point(3, 111);
            panel7.Name = "panel7";
            panel7.Size = new Size(256, 48);
            panel7.TabIndex = 5;
            // 
            // button_EditData
            // 
            button_EditData.BackColor = Color.FromArgb(29, 29, 67);
            button_EditData.Dock = DockStyle.Fill;
            button_EditData.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_EditData.ForeColor = Color.White;
            button_EditData.ImageAlign = ContentAlignment.MiddleLeft;
            button_EditData.Location = new Point(0, 0);
            button_EditData.Name = "button_EditData";
            button_EditData.Size = new Size(256, 48);
            button_EditData.TabIndex = 2;
            button_EditData.TabStop = false;
            button_EditData.Text = "Изменить данные";
            button_EditData.UseVisualStyleBackColor = false;
            button_EditData.Click += button_EditData_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 29, 67);
            button3.Font = new Font("Century Gothic", 13.8F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 219);
            button3.Name = "button3";
            button3.Size = new Size(256, 48);
            button3.TabIndex = 8;
            button3.TabStop = false;
            button3.Text = "            Выход";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 272);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(247, 182);
            panel9.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 458);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 75);
            panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(38, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 77);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(585, 58);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 530);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 29, 67);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label);
            panel2.Controls.Add(btnHum);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 73);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(959, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 43);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(916, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 40);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.FromArgb(244, 244, 244);
            label.Location = new Point(76, 15);
            label.Name = "label";
            label.Size = new Size(119, 32);
            label.TabIndex = 2;
            label.Text = "ЗАВХОЗ";
            // 
            // btnHum
            // 
            btnHum.Image = (Image)resources.GetObject("btnHum.Image");
            btnHum.Location = new Point(7, 4);
            btnHum.Margin = new Padding(3, 4, 3, 4);
            btnHum.Name = "btnHum";
            btnHum.Size = new Size(63, 67);
            btnHum.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHum.TabIndex = 1;
            btnHum.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(29, 29, 67);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.CausesValidation = false;
            button4.Font = new Font("Century Gothic", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(544, 65);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(38, 39);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.TextChanged += button4_TextChanged;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(143, 70);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 27);
            textBox1.TabIndex = 9;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 29, 67);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(labell);
            panel4.Controls.Add(pictureBox6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(882, 55);
            panel4.TabIndex = 10;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            panel4.MouseUp += panel4_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(839, 9);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(802, 11);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 30);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labell.ForeColor = Color.FromArgb(244, 244, 244);
            labell.Location = new Point(66, 11);
            labell.Name = "labell";
            labell.Size = new Size(405, 32);
            labell.TabIndex = 2;
            labell.Text = "ЗАВЕДУЮЩИЙ ХОЗЯЙСТВОМ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(6, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(87, 70);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 27);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // menuTransition1
            // 
            menuTransition1.Interval = 10;
            menuTransition1.Tick += menuTransition1_Tick;
            // 
            // FormZavhoz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 590);
            Controls.Add(panel4);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormZavhoz";
            Text = "FormZavhoz";
            Load += FormZavhoz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidebar.ResumeLayout(false);
            menuConteiner.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel sidebar;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label;
        private PictureBox btnHum;
        private Panel panel9;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button4;
        private TextBox textBox1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label labell;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox7;
        private FlowLayoutPanel menuConteiner;
        private Panel panel5;
        private Button menu;
        private Panel panel6;
        private Button button_EditPassword;
        private Panel panel7;
        private Button button_EditData;
        private System.Windows.Forms.Timer menuTransition1;
    }
}