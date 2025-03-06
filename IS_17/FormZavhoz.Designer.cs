namespace IS_17
{
    partial class FormZavhoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZavhoz));
            dataGridView1 = new DataGridView();
            sidebar = new FlowLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 64);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(384, 304);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.MidnightBlue;
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(button1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(265, 446);
            sidebar.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(256, 48);
            button7.TabIndex = 4;
            button7.TabStop = false;
            button7.Text = "Инвентарь";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 57);
            button8.Name = "button8";
            button8.Size = new Size(256, 48);
            button8.TabIndex = 5;
            button8.TabStop = false;
            button8.Text = "Поставщики";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 111);
            button1.Name = "button1";
            button1.Size = new Size(256, 48);
            button1.TabIndex = 6;
            button1.TabStop = false;
            button1.Text = "Отчёты";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(690, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 304);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // FormZavhoz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 446);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormZavhoz";
            Text = "FormZavhoz";
            Load += FormZavhoz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel sidebar;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Button button1;
    }
}