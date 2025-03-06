namespace IS_17
{
    partial class FormMaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaid));
            sidebar = new FlowLayoutPanel();
            buttonCheckRooms = new Button();
            menuConteiner = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel4 = new Panel();
            button_CreateWorkers = new Button();
            panel5 = new Panel();
            button_EditWorkers = new Button();
            buttonLogout = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            menuConteiner.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(29, 29, 67);
            sidebar.Controls.Add(buttonCheckRooms);
            sidebar.Controls.Add(menuConteiner);
            sidebar.Controls.Add(buttonLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 73);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(343, 716);
            sidebar.TabIndex = 4;
            // 
            // buttonCheckRooms
            // 
            buttonCheckRooms.BackColor = Color.FromArgb(29, 29, 67);
            buttonCheckRooms.Font = new Font("Century Gothic", 14F);
            buttonCheckRooms.ForeColor = Color.White;
            buttonCheckRooms.Image = (Image)resources.GetObject("buttonCheckRooms.Image");
            buttonCheckRooms.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCheckRooms.Location = new Point(3, 4);
            buttonCheckRooms.Margin = new Padding(3, 4, 3, 4);
            buttonCheckRooms.Name = "buttonCheckRooms";
            buttonCheckRooms.Size = new Size(293, 64);
            buttonCheckRooms.TabIndex = 6;
            buttonCheckRooms.TabStop = false;
            buttonCheckRooms.Text = "           Уборка";
            buttonCheckRooms.TextAlign = ContentAlignment.MiddleLeft;
            buttonCheckRooms.UseVisualStyleBackColor = false;
            buttonCheckRooms.Click += buttonCheckRooms_Click;
            // 
            // menuConteiner
            // 
            menuConteiner.Controls.Add(panel3);
            menuConteiner.Controls.Add(panel4);
            menuConteiner.Controls.Add(panel5);
            menuConteiner.Location = new Point(3, 57);
            menuConteiner.Name = "menuConteiner";
            menuConteiner.Size = new Size(256, 48);
            menuConteiner.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 48);
            panel3.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.Lavender;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(256, 48);
            menu.TabIndex = 2;
            menu.TabStop = false;
            menu.Text = "Управление аккаунтом";
            menu.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_CreateWorkers);
            panel4.Location = new Point(3, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 48);
            panel4.TabIndex = 4;
            // 
            // button_CreateWorkers
            // 
            button_CreateWorkers.Dock = DockStyle.Fill;
            button_CreateWorkers.Image = (Image)resources.GetObject("button_CreateWorkers.Image");
            button_CreateWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            button_CreateWorkers.Location = new Point(0, 0);
            button_CreateWorkers.Name = "button_CreateWorkers";
            button_CreateWorkers.Size = new Size(256, 48);
            button_CreateWorkers.TabIndex = 2;
            button_CreateWorkers.TabStop = false;
            button_CreateWorkers.Text = "Изменить данные";
            button_CreateWorkers.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button_EditWorkers);
            panel5.Location = new Point(3, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 48);
            panel5.TabIndex = 5;
            // 
            // button_EditWorkers
            // 
            button_EditWorkers.Dock = DockStyle.Fill;
            button_EditWorkers.Image = (Image)resources.GetObject("button_EditWorkers.Image");
            button_EditWorkers.ImageAlign = ContentAlignment.MiddleLeft;
            button_EditWorkers.Location = new Point(0, 0);
            button_EditWorkers.Name = "button_EditWorkers";
            button_EditWorkers.Size = new Size(256, 48);
            button_EditWorkers.TabIndex = 2;
            button_EditWorkers.TabStop = false;
            button_EditWorkers.Text = "Изменить пароль";
            button_EditWorkers.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(29, 29, 67);
            buttonLogout.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(3, 148);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(293, 64);
            buttonLogout.TabIndex = 5;
            buttonLogout.TabStop = false;
            buttonLogout.Text = "             Выход";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
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
            panel1.TabIndex = 3;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(960, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 40);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(919, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 40);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 15);
            label1.Name = "label1";
            label1.Size = new Size(216, 40);
            label1.TabIndex = 2;
            label1.Text = "ГОРНИЧНАЯ";
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
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // FormMaid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 789);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMaid";
            Text = "FormMaid";
            sidebar.ResumeLayout(false);
            menuConteiner.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Button buttonLogout;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox btnHum;
        private Button buttonCheckRooms;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}