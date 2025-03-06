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
            radioButtonCleaning = new RadioButton();
            radioButtonBreaking = new RadioButton();
            MessageRichTextBox = new RichTextBox();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // radioButtonCleaning
            // 
            radioButtonCleaning.AutoSize = true;
            radioButtonCleaning.Location = new Point(12, 23);
            radioButtonCleaning.Name = "radioButtonCleaning";
            radioButtonCleaning.Size = new Size(119, 19);
            radioButtonCleaning.TabIndex = 0;
            radioButtonCleaning.TabStop = true;
            radioButtonCleaning.Text = "Отметить уборку";
            radioButtonCleaning.UseVisualStyleBackColor = true;
            radioButtonCleaning.CheckedChanged += radioButtonCleaning_CheckedChanged;
            // 
            // radioButtonBreaking
            // 
            radioButtonBreaking.AutoSize = true;
            radioButtonBreaking.Location = new Point(12, 60);
            radioButtonBreaking.Name = "radioButtonBreaking";
            radioButtonBreaking.Size = new Size(168, 19);
            radioButtonBreaking.TabIndex = 1;
            radioButtonBreaking.TabStop = true;
            radioButtonBreaking.Text = "Сообщить о тех. поломке";
            radioButtonBreaking.UseVisualStyleBackColor = true;
            radioButtonBreaking.CheckedChanged += radioButtonBreaking_CheckedChanged;
            // 
            // MessageRichTextBox
            // 
            MessageRichTextBox.Location = new Point(12, 101);
            MessageRichTextBox.Name = "MessageRichTextBox";
            MessageRichTextBox.Size = new Size(268, 135);
            MessageRichTextBox.TabIndex = 2;
            MessageRichTextBox.Text = "";
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(12, 251);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(268, 40);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "Отправить/Отметить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // MaidCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 303);
            Controls.Add(buttonSend);
            Controls.Add(MessageRichTextBox);
            Controls.Add(radioButtonBreaking);
            Controls.Add(radioButtonCleaning);
            Name = "MaidCustomMessageBox";
            Text = "MaidCustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonCleaning;
        private RadioButton radioButtonBreaking;
        private RichTextBox MessageRichTextBox;
        private Button buttonSend;
    }
}