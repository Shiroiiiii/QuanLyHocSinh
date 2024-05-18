namespace WinFormsApp1
{
    partial class fBANGDIEM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            bTailai = new Button();
            bSua = new Button();
            bXoa = new Button();
            bThem = new Button();
            txtDiemmon = new TextBox();
            label5 = new Label();
            txtMahk = new TextBox();
            label4 = new Label();
            txtMamon = new TextBox();
            label3 = new Label();
            txtMalop = new TextBox();
            label2 = new Label();
            txtMahs = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            bảngĐiểmToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bTailai);
            panel1.Controls.Add(bSua);
            panel1.Controls.Add(bXoa);
            panel1.Controls.Add(bThem);
            panel1.Controls.Add(txtDiemmon);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMahk);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMamon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMalop);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMahs);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 199);
            panel1.TabIndex = 0;
            // 
            // bTailai
            // 
            bTailai.Location = new Point(735, 143);
            bTailai.Name = "bTailai";
            bTailai.Size = new Size(128, 34);
            bTailai.TabIndex = 13;
            bTailai.TabStop = false;
            bTailai.Text = "Tải lại";
            bTailai.UseVisualStyleBackColor = true;
            // 
            // bSua
            // 
            bSua.Location = new Point(449, 143);
            bSua.Name = "bSua";
            bSua.Size = new Size(112, 34);
            bSua.TabIndex = 12;
            bSua.TabStop = false;
            bSua.Text = "Sửa";
            bSua.UseVisualStyleBackColor = true;
            // 
            // bXoa
            // 
            bXoa.Location = new Point(594, 143);
            bXoa.Name = "bXoa";
            bXoa.Size = new Size(112, 34);
            bXoa.TabIndex = 11;
            bXoa.TabStop = false;
            bXoa.Text = "Xóa";
            bXoa.UseVisualStyleBackColor = true;
            // 
            // bThem
            // 
            bThem.Location = new Point(300, 143);
            bThem.Name = "bThem";
            bThem.Size = new Size(112, 34);
            bThem.TabIndex = 10;
            bThem.TabStop = false;
            bThem.Text = "Thêm";
            bThem.UseVisualStyleBackColor = true;
            // 
            // txtDiemmon
            // 
            txtDiemmon.Location = new Point(449, 83);
            txtDiemmon.Name = "txtDiemmon";
            txtDiemmon.Size = new Size(150, 37);
            txtDiemmon.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 86);
            label5.Name = "label5";
            label5.Size = new Size(124, 29);
            label5.TabIndex = 8;
            label5.Text = "ĐTB môn:";
            // 
            // txtMahk
            // 
            txtMahk.Location = new Point(151, 86);
            txtMahk.MaxLength = 10;
            txtMahk.Name = "txtMahk";
            txtMahk.Size = new Size(150, 37);
            txtMahk.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(126, 29);
            label4.TabIndex = 6;
            label4.Text = "Mã học kì:";
            // 
            // txtMamon
            // 
            txtMamon.Location = new Point(829, 18);
            txtMamon.MaxLength = 10;
            txtMamon.Name = "txtMamon";
            txtMamon.Size = new Size(150, 37);
            txtMamon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(671, 26);
            label3.Name = "label3";
            label3.Size = new Size(152, 29);
            label3.TabIndex = 4;
            label3.Text = "Mã môn học:";
            // 
            // txtMalop
            // 
            txtMalop.Location = new Point(449, 18);
            txtMalop.MaxLength = 10;
            txtMalop.Name = "txtMalop";
            txtMalop.Size = new Size(150, 37);
            txtMalop.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 2;
            label2.Text = "Mã lớp:";
            // 
            // txtMahs
            // 
            txtMahs.Location = new Point(151, 18);
            txtMahs.MaxLength = 10;
            txtMahs.Name = "txtMahs";
            txtMahs.Size = new Size(150, 37);
            txtMahs.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 0;
            label1.Text = "Mã học sinh:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 210);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column3, Column2, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1183, 210);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "MÃ HỌC SINH";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 250;
            // 
            // Column1
            // 
            Column1.HeaderText = "MÃ LỚP";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "MÃ MÔN HỌC";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "MÃ HỌC KÌ";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "ĐIỂM TRUNG BÌNH MÔN";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 350;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, bảngĐiểmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1183, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(89, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            bảngĐiểmToolStripMenuItem.Size = new Size(113, 29);
            bảngĐiểmToolStripMenuItem.Text = "Bảng điểm";
            // 
            // fBANGDIEM
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 442);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fBANGDIEM";
            Text = "Bảng điểm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtMahs;
        private Label label1;
        private TextBox txtDiemmon;
        private Label label5;
        private TextBox txtMahk;
        private Label label4;
        private TextBox txtMamon;
        private Label label3;
        private TextBox txtMalop;
        private Label label2;
        private Button bSua;
        private Button bXoa;
        private Button bThem;
        private Button bTailai;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem bảngĐiểmToolStripMenuItem;
    }
}
