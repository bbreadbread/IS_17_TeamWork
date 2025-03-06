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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZavhoz));
            dataGridView1 = new DataGridView();
            sidebar = new FlowLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(439, 406);
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
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button3);
            sidebar.Location = new Point(0, 73);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(70, 522);
            sidebar.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(29, 29, 67);
            button7.Font = new Font("Century Gothic", 13.8F);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 4);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(293, 64);
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
            button8.Location = new Point(3, 76);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(293, 64);
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
            button1.Location = new Point(3, 148);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(293, 64);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "            Отчёты";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(29, 29, 67);
            button2.Font = new Font("Century Gothic", 13.8F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 220);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(293, 64);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "Настройки";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 29, 67);
            button3.Font = new Font("Century Gothic", 13.8F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 292);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(293, 64);
            button3.TabIndex = 8;
            button3.TabStop = false;
            button3.Text = "            Выход";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(537, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 406);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 29, 67);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnHum);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 73);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(76, 15);
            label1.Name = "label1";
            label1.Size = new Size(150, 40);
            label1.TabIndex = 2;
            label1.Text = "ЗАВХОЗ";
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
            // FormZavhoz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 595);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormZavhoz";
            Text = "FormZavhoz";
            Load += FormZavhoz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel sidebar;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox btnHum;
    }
}