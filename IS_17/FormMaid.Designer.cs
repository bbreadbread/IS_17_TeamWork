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
            button7 = new Button();
            menuConteiner = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel4 = new Panel();
            button_EditPassword = new Button();
            panel5 = new Panel();
            button_EditData = new Button();
            buttonLogout = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            menuTransition1 = new System.Windows.Forms.Timer(components);
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
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(menuConteiner);
            sidebar.Controls.Add(buttonLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 55);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(62, 537);
            sidebar.TabIndex = 4;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(29, 29, 67);
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Font = new Font("Century Gothic", 13.8F);
            button7.ForeColor = Color.White;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(256, 48);
            button7.TabIndex = 8;
            button7.TabStop = false;
            button7.Text = "Учет комнат";
            button7.UseVisualStyleBackColor = false;
            // 
            // menuConteiner
            // 
            menuConteiner.BackColor = Color.FromArgb(29, 29, 67);
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
            // panel4
            // 
            panel4.Controls.Add(button_EditPassword);
            panel4.Location = new Point(3, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 48);
            panel4.TabIndex = 4;
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
            // panel5
            // 
            panel5.Controls.Add(button_EditData);
            panel5.Location = new Point(3, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 48);
            panel5.TabIndex = 5;
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
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(29, 29, 67);
            buttonLogout.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(3, 111);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(256, 48);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 55);
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
            pictureBox2.Location = new Point(840, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(804, 11);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 11);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 2;
            label1.Text = "ГОРНИЧНАЯ";
            // 
            // btnHum
            // 
            btnHum.Image = (Image)resources.GetObject("btnHum.Image");
            btnHum.Location = new Point(6, 3);
            btnHum.Name = "btnHum";
            btnHum.Size = new Size(55, 50);
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
            // menuTransition1
            // 
            menuTransition1.Interval = 10;
            menuTransition1.Tick += menuTransition1_Tick;
            // 
            // FormMaid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 592);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormMaid";
            Text = "FormMaid";
            Load += FormMaid_Load;
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
        private FlowLayoutPanel menuConteiner;
        private Panel panel3;
        private Button menu;
        private Panel panel4;
        private Button button_EditPassword;
        private Panel panel5;
        private Button button_EditData;
        private Button button7;
        private System.Windows.Forms.Timer menuTransition1;
    }
}