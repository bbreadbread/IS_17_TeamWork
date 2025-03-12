namespace IS_17
{
    partial class Form_Profiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Profiles));
            labelWHO = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonConfirm = new Button();
            buttonSendCode = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelWHO
            // 
            labelWHO.Font = new Font("Century Gothic", 12F);
            labelWHO.Location = new Point(77, 98);
            labelWHO.Name = "labelWHO";
            labelWHO.Size = new Size(300, 23);
            labelWHO.TabIndex = 17;
            labelWHO.Text = "???";
            labelWHO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 67);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 45);
            panel1.TabIndex = 16;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            panel1.MouseUp += panel1_MouseUp_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 18);
            label1.TabIndex = 8;
            label1.Text = "Изменение данных";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(413, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 45);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1051, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1102, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(77, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 29);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(77, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 29);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(77, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 13;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.FromArgb(29, 29, 67);
            buttonConfirm.Font = new Font("Century Gothic", 10F);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(77, 331);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(300, 47);
            buttonConfirm.TabIndex = 12;
            buttonConfirm.Text = "Подтвердить и завершить";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click_1;
            // 
            // buttonSendCode
            // 
            buttonSendCode.BackColor = Color.FromArgb(29, 29, 67);
            buttonSendCode.Font = new Font("Century Gothic", 10F);
            buttonSendCode.ForeColor = Color.White;
            buttonSendCode.Location = new Point(77, 216);
            buttonSendCode.Name = "buttonSendCode";
            buttonSendCode.Size = new Size(300, 47);
            buttonSendCode.TabIndex = 11;
            buttonSendCode.Text = "Отправить код подтверждения на почту";
            buttonSendCode.UseVisualStyleBackColor = false;
            buttonSendCode.Click += buttonSendCode_Click_1;
            // 
            // Form_Profiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 443);
            Controls.Add(labelWHO);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonSendCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Profiles";
            Text = "Form_Profiles";
            Load += Form_Profiles_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWHO;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonConfirm;
        private Button buttonSendCode;
    }
}