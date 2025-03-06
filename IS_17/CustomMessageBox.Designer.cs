namespace IS_17
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            listBoxReservation = new ListBox();
            buttonReservation = new Button();
            buttonUnassign = new Button();
            labelName = new Label();
            labelSurname = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBoxReservation
            // 
            listBoxReservation.Font = new Font("Century Gothic", 10.2F);
            listBoxReservation.FormattingEnabled = true;
            listBoxReservation.ItemHeight = 19;
            listBoxReservation.Location = new Point(12, 142);
            listBoxReservation.Margin = new Padding(4);
            listBoxReservation.Name = "listBoxReservation";
            listBoxReservation.Size = new Size(435, 194);
            listBoxReservation.TabIndex = 0;
            // 
            // buttonReservation
            // 
            buttonReservation.AccessibleRole = AccessibleRole.OutlineButton;
            buttonReservation.BackColor = Color.FromArgb(29, 29, 67);
            buttonReservation.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonReservation.ForeColor = Color.White;
            buttonReservation.Location = new Point(12, 368);
            buttonReservation.Margin = new Padding(4);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(435, 53);
            buttonReservation.TabIndex = 1;
            buttonReservation.Text = "Закрепить за комнатой";
            buttonReservation.UseVisualStyleBackColor = false;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonUnassign
            // 
            buttonUnassign.BackColor = Color.FromArgb(29, 29, 67);
            buttonUnassign.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonUnassign.ForeColor = Color.White;
            buttonUnassign.Location = new Point(275, 68);
            buttonUnassign.Margin = new Padding(4);
            buttonUnassign.Name = "buttonUnassign";
            buttonUnassign.Size = new Size(166, 53);
            buttonUnassign.TabIndex = 2;
            buttonUnassign.Text = "Открепить";
            buttonUnassign.UseVisualStyleBackColor = false;
            buttonUnassign.Click += buttonUnassign_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Century Gothic", 10.2F);
            labelName.Location = new Point(18, 78);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 19);
            labelName.TabIndex = 3;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Century Gothic", 10.2F);
            labelSurname.Location = new Point(122, 78);
            labelSurname.Margin = new Padding(4, 0, 4, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(0, 19);
            labelSurname.TabIndex = 4;
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
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 18);
            label1.TabIndex = 8;
            label1.Text = "Закрепление горничных";
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
            pictureBox1.Click += pictureBox1_Click;
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
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 443);
            Controls.Add(panel1);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(buttonUnassign);
            Controls.Add(buttonReservation);
            Controls.Add(listBoxReservation);
            Font = new Font("Century Gothic", 10.2F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CustomMessageBox";
            Text = "Закрепление комнаты";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReservation;
        private Button buttonReservation;
        private Button buttonUnassign;
        private Label labelName;
        private Label labelSurname;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}