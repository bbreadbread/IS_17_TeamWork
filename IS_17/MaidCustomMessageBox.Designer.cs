namespace IS_17
{
    partial class MaidCustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaidCustomMessageBox));
            radioButtonCleaning = new RadioButton();
            radioButtonBreaking = new RadioButton();
            MessageRichTextBox = new RichTextBox();
            buttonSend = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // radioButtonCleaning
            // 
            radioButtonCleaning.AutoSize = true;
            radioButtonCleaning.Font = new Font("Century Gothic", 10.2F);
            radioButtonCleaning.Location = new Point(17, 68);
            radioButtonCleaning.Margin = new Padding(3, 4, 3, 4);
            radioButtonCleaning.Name = "radioButtonCleaning";
            radioButtonCleaning.Size = new Size(146, 23);
            radioButtonCleaning.TabIndex = 0;
            radioButtonCleaning.TabStop = true;
            radioButtonCleaning.Text = "Отметить уборку";
            radioButtonCleaning.UseVisualStyleBackColor = true;
            radioButtonCleaning.CheckedChanged += radioButtonCleaning_CheckedChanged;
            // 
            // radioButtonBreaking
            // 
            radioButtonBreaking.AutoSize = true;
            radioButtonBreaking.Font = new Font("Century Gothic", 10.2F);
            radioButtonBreaking.Location = new Point(17, 99);
            radioButtonBreaking.Margin = new Padding(3, 4, 3, 4);
            radioButtonBreaking.Name = "radioButtonBreaking";
            radioButtonBreaking.Size = new Size(208, 23);
            radioButtonBreaking.TabIndex = 1;
            radioButtonBreaking.TabStop = true;
            radioButtonBreaking.Text = "Сообщить о тех. поломке";
            radioButtonBreaking.UseVisualStyleBackColor = true;
            radioButtonBreaking.CheckedChanged += radioButtonBreaking_CheckedChanged;
            // 
            // MessageRichTextBox
            // 
            MessageRichTextBox.Location = new Point(12, 142);
            MessageRichTextBox.Margin = new Padding(3, 4, 3, 4);
            MessageRichTextBox.Name = "MessageRichTextBox";
            MessageRichTextBox.Size = new Size(435, 205);
            MessageRichTextBox.TabIndex = 2;
            MessageRichTextBox.Text = "";
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.FromArgb(29, 29, 67);
            buttonSend.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSend.ForeColor = Color.White;
            buttonSend.Location = new Point(12, 368);
            buttonSend.Margin = new Padding(3, 4, 3, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(435, 53);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "Подтвердить";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 29, 67);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 45);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(413, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 45);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 18);
            label1.TabIndex = 8;
            label1.Text = "Завершение уборки";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(464, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1182, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 42);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(29, 29, 67);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1240, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 42);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // MaidCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 443);
            Controls.Add(panel1);
            Controls.Add(buttonSend);
            Controls.Add(MessageRichTextBox);
            Controls.Add(radioButtonBreaking);
            Controls.Add(radioButtonCleaning);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MaidCustomMessageBox";
            Text = "MaidCustomMessageBox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonCleaning;
        private RadioButton radioButtonBreaking;
        private RichTextBox MessageRichTextBox;
        private Button buttonSend;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}