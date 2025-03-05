namespace IS_17
{
    partial class Authoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authoriz));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            emailTB = new TextBox();
            passTB = new TextBox();
            passShow = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passShow).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-10, -59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(941, 831);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(597, 189);
            label1.Name = "label1";
            label1.Size = new Size(213, 75);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTB
            // 
            emailTB.Font = new Font("Century Gothic", 12F);
            emailTB.Location = new Point(561, 309);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(277, 32);
            emailTB.TabIndex = 2;
            emailTB.Enter += emailTB_Enter;
            emailTB.Leave += emailTB_Leave;
            // 
            // passTB
            // 
            passTB.Font = new Font("Century Gothic", 12F);
            passTB.Location = new Point(561, 387);
            passTB.Name = "passTB";
            passTB.Size = new Size(277, 32);
            passTB.TabIndex = 3;
            passTB.Enter += passTB_Enter;
            passTB.Leave += passTB_Leave;
            // 
            // passShow
            // 
            passShow.BackColor = Color.White;
            passShow.BackgroundImage = (Image)resources.GetObject("passShow.BackgroundImage");
            passShow.BackgroundImageLayout = ImageLayout.Zoom;
            passShow.Location = new Point(807, 397);
            passShow.Name = "passShow";
            passShow.Size = new Size(32, 25);
            passShow.TabIndex = 4;
            passShow.TabStop = false;
            passShow.MouseDown += passShow_MouseDown;
            passShow.MouseUp += passShow_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 214, 233);
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(622, 457);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 43);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(841, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 40);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(882, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 40);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Authoriz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 708);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(passShow);
            Controls.Add(passTB);
            Controls.Add(emailTB);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authoriz";
            Text = "Authoriz";
            Shown += Authoriz_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)passShow).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox emailTB;
        private TextBox passTB;
        private PictureBox passShow;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}