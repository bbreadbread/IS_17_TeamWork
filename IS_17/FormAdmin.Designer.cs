namespace IS_17
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuConteiner = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel4 = new Panel();
            button_CreateWorkers = new Button();
            panel5 = new Panel();
            button_EditWorkers = new Button();
            menuConteiner2 = new FlowLayoutPanel();
            panel6 = new Panel();
            menu2 = new Button();
            panel7 = new Panel();
            button_CreateRooms = new Button();
            panel8 = new Panel();
            button_EditRooms = new Button();
            button7 = new Button();
            button8 = new Button();
            menuTransition1 = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            menuTransition2 = new System.Windows.Forms.Timer(components);
            panel9 = new Panel();
            panel10 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            sidebar.SuspendLayout();
            menuConteiner.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            menuConteiner2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 67);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHum);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 73);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
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
            label1.Size = new Size(315, 40);
            label1.TabIndex = 2;
            label1.Text = "АДМИНИСТРАТОР";
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
            btnHum.Click += btnHum_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(29, 29, 67);
            sidebar.Controls.Add(menuConteiner);
            sidebar.Controls.Add(menuConteiner2);
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel10);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 73);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(319, 713);
            sidebar.TabIndex = 2;
            // 
            // menuConteiner
            // 
            menuConteiner.BackColor = Color.FromArgb(29, 29, 67);
            menuConteiner.Controls.Add(panel3);
            menuConteiner.Controls.Add(panel4);
            menuConteiner.Controls.Add(panel5);
            menuConteiner.Location = new Point(3, 4);
            menuConteiner.Margin = new Padding(3, 4, 3, 4);
            menuConteiner.Name = "menuConteiner";
            menuConteiner.Size = new Size(293, 64);
            menuConteiner.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 64);
            panel3.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(29, 29, 67);
            menu.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(293, 64);
            menu.TabIndex = 2;
            menu.TabStop = false;
            menu.Text = "Cотрудники";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_CreateWorkers);
            panel4.Location = new Point(3, 76);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 64);
            panel4.TabIndex = 4;
            // 
            // button_CreateWorkers
            // 
            button_CreateWorkers.BackColor = Color.FromArgb(29, 29, 67);
            button_CreateWorkers.Dock = DockStyle.Fill;
            button_CreateWorkers.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_CreateWorkers.ForeColor = Color.White;
            button_CreateWorkers.Image = (Image)resources.GetObject("button_CreateWorkers.Image");
            button_CreateWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            button_CreateWorkers.Location = new Point(0, 0);
            button_CreateWorkers.Margin = new Padding(3, 4, 3, 4);
            button_CreateWorkers.Name = "button_CreateWorkers";
            button_CreateWorkers.Size = new Size(293, 64);
            button_CreateWorkers.TabIndex = 2;
            button_CreateWorkers.TabStop = false;
            button_CreateWorkers.Text = "Создание";
            button_CreateWorkers.UseVisualStyleBackColor = false;
            button_CreateWorkers.Click += button_CreateWorkers_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_EditWorkers);
            panel5.Location = new Point(3, 148);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 64);
            panel5.TabIndex = 5;
            // 
            // button_EditWorkers
            // 
            button_EditWorkers.BackColor = Color.FromArgb(29, 29, 67);
            button_EditWorkers.Dock = DockStyle.Fill;
            button_EditWorkers.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_EditWorkers.ForeColor = Color.White;
            button_EditWorkers.Image = (Image)resources.GetObject("button_EditWorkers.Image");
            button_EditWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            button_EditWorkers.Location = new Point(0, 0);
            button_EditWorkers.Margin = new Padding(3, 4, 3, 4);
            button_EditWorkers.Name = "button_EditWorkers";
            button_EditWorkers.Size = new Size(293, 64);
            button_EditWorkers.TabIndex = 2;
            button_EditWorkers.TabStop = false;
            button_EditWorkers.Text = "         Редактирование";
            button_EditWorkers.UseVisualStyleBackColor = false;
            button_EditWorkers.Click += button_EditWorkers_Click;
            // 
            // menuConteiner2
            // 
            menuConteiner2.BackColor = Color.FromArgb(29, 29, 67);
            menuConteiner2.Controls.Add(panel6);
            menuConteiner2.Controls.Add(panel7);
            menuConteiner2.Controls.Add(panel8);
            menuConteiner2.Location = new Point(3, 76);
            menuConteiner2.Margin = new Padding(3, 4, 3, 4);
            menuConteiner2.Name = "menuConteiner2";
            menuConteiner2.Size = new Size(293, 64);
            menuConteiner2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(menu2);
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 64);
            panel6.TabIndex = 4;
            // 
            // menu2
            // 
            menu2.BackColor = Color.FromArgb(29, 29, 67);
            menu2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menu2.ForeColor = Color.White;
            menu2.Image = (Image)resources.GetObject("menu2.Image");
            menu2.ImageAlign = ContentAlignment.MiddleLeft;
            menu2.Location = new Point(0, 0);
            menu2.Margin = new Padding(3, 4, 3, 4);
            menu2.Name = "menu2";
            menu2.Size = new Size(293, 64);
            menu2.TabIndex = 2;
            menu2.TabStop = false;
            menu2.Text = "           Номера";
            menu2.TextAlign = ContentAlignment.MiddleLeft;
            menu2.UseVisualStyleBackColor = false;
            menu2.Click += menu2_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_CreateRooms);
            panel7.Location = new Point(3, 76);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(293, 64);
            panel7.TabIndex = 4;
            // 
            // button_CreateRooms
            // 
            button_CreateRooms.BackColor = Color.FromArgb(29, 29, 67);
            button_CreateRooms.Dock = DockStyle.Fill;
            button_CreateRooms.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_CreateRooms.ForeColor = Color.White;
            button_CreateRooms.Image = (Image)resources.GetObject("button_CreateRooms.Image");
            button_CreateRooms.ImageAlign = ContentAlignment.MiddleLeft;
            button_CreateRooms.Location = new Point(0, 0);
            button_CreateRooms.Margin = new Padding(3, 4, 3, 4);
            button_CreateRooms.Name = "button_CreateRooms";
            button_CreateRooms.Size = new Size(293, 64);
            button_CreateRooms.TabIndex = 2;
            button_CreateRooms.TabStop = false;
            button_CreateRooms.Text = "           Создание";
            button_CreateRooms.TextAlign = ContentAlignment.MiddleLeft;
            button_CreateRooms.UseVisualStyleBackColor = false;
            button_CreateRooms.Click += button_CreateRooms_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button_EditRooms);
            panel8.Location = new Point(3, 148);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(293, 64);
            panel8.TabIndex = 5;
            // 
            // button_EditRooms
            // 
            button_EditRooms.BackColor = Color.FromArgb(29, 29, 67);
            button_EditRooms.Dock = DockStyle.Fill;
            button_EditRooms.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_EditRooms.ForeColor = Color.White;
            button_EditRooms.Image = (Image)resources.GetObject("button_EditRooms.Image");
            button_EditRooms.ImageAlign = ContentAlignment.MiddleLeft;
            button_EditRooms.Location = new Point(0, 0);
            button_EditRooms.Margin = new Padding(3, 4, 3, 4);
            button_EditRooms.Name = "button_EditRooms";
            button_EditRooms.Size = new Size(293, 64);
            button_EditRooms.TabIndex = 2;
            button_EditRooms.TabStop = false;
            button_EditRooms.Text = "         Редактирование";
            button_EditRooms.UseVisualStyleBackColor = false;
            button_EditRooms.Click += button_EditRooms_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(29, 29, 67);
            button7.Font = new Font("Century Gothic", 13.8F);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 148);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(293, 64);
            button7.TabIndex = 4;
            button7.TabStop = false;
            button7.Text = "Назначение";
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
            button8.Location = new Point(3, 220);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(293, 64);
            button8.TabIndex = 5;
            button8.TabStop = false;
            button8.Text = "           Выход";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // menuTransition1
            // 
            menuTransition1.Interval = 10;
            menuTransition1.Tick += menuTransition1_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // menuTransition2
            // 
            menuTransition2.Interval = 10;
            menuTransition2.Tick += menuTransition2_Tick;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 291);
            panel9.Name = "panel9";
            panel9.Size = new Size(282, 313);
            panel9.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Controls.Add(pictureBox1);
            panel10.Location = new Point(3, 610);
            panel10.Name = "panel10";
            panel10.Size = new Size(316, 106);
            panel10.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(32, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 786);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            sidebar.ResumeLayout(false);
            menuConteiner.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            menuConteiner2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnHum;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button button_CreateWorkers;
        private FlowLayoutPanel menuConteiner;
        private Panel panel3;
        private Button menu;
        private Panel panel4;
        private Panel panel5;
        private Button button_EditWorkers;
        private Button button6;
        private System.Windows.Forms.Timer menuTransition1;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer menuTransition2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private FlowLayoutPanel menuConteiner2;
        private Panel panel6;
        private Button menu2;
        private Panel panel7;
        private Button button_CreateRooms;
        private Panel panel8;
        private Button button_EditRooms;
        private Button button7;
        private Button button8;
        private Panel panel9;
        private Panel panel10;
        private PictureBox pictureBox1;
    }
}