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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passShow).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-10, -79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(907, 717);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(579, 140);
            label1.Name = "label1";
            label1.Size = new Size(213, 75);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTB
            // 
            emailTB.Font = new Font("Century Gothic", 12F);
            emailTB.Location = new Point(545, 251);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(277, 32);
            emailTB.TabIndex = 2;
            emailTB.Enter += emailTB_Enter;
            emailTB.Leave += emailTB_Leave;
            // 
            // passTB
            // 
            passTB.Font = new Font("Century Gothic", 12F);
            passTB.Location = new Point(545, 301);
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
            passShow.Location = new Point(788, 304);
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
            button1.Location = new Point(643, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Authoriz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 561);
            Controls.Add(button1);
            Controls.Add(passShow);
            Controls.Add(passTB);
            Controls.Add(emailTB);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authoriz";
            Text = "Authoriz";
            Shown += Authoriz_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)passShow).EndInit();
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
    }
}