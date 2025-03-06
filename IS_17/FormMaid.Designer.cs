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
            buttonProfile = new Button();
            buttonLogout = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnHum = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
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
            sidebar.Controls.Add(buttonProfile);
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
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.FromArgb(29, 29, 67);
            buttonProfile.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.Image = (Image)resources.GetObject("buttonProfile.Image");
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(3, 76);
            buttonProfile.Margin = new Padding(3, 4, 3, 4);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(293, 64);
            buttonProfile.TabIndex = 4;
            buttonProfile.TabStop = false;
            buttonProfile.Text = "Настройки";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Button buttonProfile;
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