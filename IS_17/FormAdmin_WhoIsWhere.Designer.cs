namespace IS_17
{
    partial class FormAdmin_WhoIsWhere
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
            refreshTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // refreshTimer
            // 
            refreshTimer.Interval = 4000;
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // FormAdmin_WhoIsWhere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 531);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin_WhoIsWhere";
            Text = "FormAdmin_WhoIsWhere";
            FormClosed += FormAdmin_WhoIsWhere_FormClosed;
            Load += FormAdmin_WhoIsWhere_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer refreshTimer;
    }
}