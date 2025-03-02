namespace IS_17
{
    partial class FormAdmin_Rooms_Edit
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 259);
            label1.Name = "label1";
            label1.Size = new Size(362, 15);
            label1.TabIndex = 2;
            label1.Text = "На этой форме функционал редактирования и удаления комнат";
            // 
            // FormAdmin_Rooms_Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 527);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_Rooms_Edit";
            Text = "FormAdmin_Rooms_Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}