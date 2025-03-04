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
            listBoxReservation = new ListBox();
            buttonReservation = new Button();
            button1 = new Button();
            labelName = new Label();
            labelSurname = new Label();
            SuspendLayout();
            // 
            // listBoxReservation
            // 
            listBoxReservation.FormattingEnabled = true;
            listBoxReservation.ItemHeight = 15;
            listBoxReservation.Location = new Point(12, 42);
            listBoxReservation.Name = "listBoxReservation";
            listBoxReservation.Size = new Size(297, 259);
            listBoxReservation.TabIndex = 0;
            // 
            // buttonReservation
            // 
            buttonReservation.Location = new Point(12, 315);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(143, 31);
            buttonReservation.TabIndex = 1;
            buttonReservation.Text = "Закрепить за комнатой";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // button1
            // 
            button1.Location = new Point(161, 315);
            button1.Name = "button1";
            button1.Size = new Size(148, 31);
            button1.TabIndex = 2;
            button1.Text = "Открепить от комнаты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 13);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 15);
            labelName.TabIndex = 3;
            labelName.Text = "label1";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(92, 13);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(38, 15);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "label2";
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 358);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(button1);
            Controls.Add(buttonReservation);
            Controls.Add(listBoxReservation);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CustomMessageBox";
            Text = "Закрепление комнаты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReservation;
        private Button buttonReservation;
        private Button button1;
        private Label labelName;
        private Label labelSurname;
    }
}