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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(439, 406);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.MidnightBlue;
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(button8);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(328, 595);
            sidebar.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 4);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(293, 64);
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
            button8.Location = new Point(3, 76);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(293, 64);
            button8.TabIndex = 5;
            button8.TabStop = false;
            button8.Text = "Поставщики";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(789, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 406);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // FormZavhoz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 595);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
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
    }
}