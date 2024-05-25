namespace WinFormsApp1.GUI
{
    partial class fChiTietBangDiem
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            textBox1 = new TextBox();
            lbDiemTBM = new Label();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbHeSo = new Label();
            lbTenLHKT = new Label();
            cmbMaBD = new ComboBox();
            cmbMaHS = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 214);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 240);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1025, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "MÃ BẢNG ĐIỂM";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "MÃ HỌC SINH";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "ĐIỂM TB MÔN";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMaHS);
            panel1.Controls.Add(cmbMaBD);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lbDiemTBM);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(lbHeSo);
            panel1.Controls.Add(lbTenLHKT);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 214);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(725, 35);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 37);
            textBox1.TabIndex = 3;
            // 
            // lbDiemTBM
            // 
            lbDiemTBM.AutoSize = true;
            lbDiemTBM.Location = new Point(460, 43);
            lbDiemTBM.Name = "lbDiemTBM";
            lbDiemTBM.Size = new Size(243, 29);
            lbDiemTBM.TabIndex = 5;
            lbDiemTBM.Text = "Điểm trung bình môn:";
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(870, 139);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(737, 139);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 4;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(601, 139);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(467, 139);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 4;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbHeSo
            // 
            lbHeSo.AutoSize = true;
            lbHeSo.Location = new Point(63, 109);
            lbHeSo.Name = "lbHeSo";
            lbHeSo.Size = new Size(148, 29);
            lbHeSo.TabIndex = 3;
            lbHeSo.Text = "Mã học sinh:";
            // 
            // lbTenLHKT
            // 
            lbTenLHKT.AutoSize = true;
            lbTenLHKT.Location = new Point(42, 43);
            lbTenLHKT.Name = "lbTenLHKT";
            lbTenLHKT.Size = new Size(169, 29);
            lbTenLHKT.TabIndex = 1;
            lbTenLHKT.Text = "Mã bảng điểm:";
            // 
            // cmbMaBD
            // 
            cmbMaBD.FormattingEnabled = true;
            cmbMaBD.Location = new Point(217, 35);
            cmbMaBD.Name = "cmbMaBD";
            cmbMaBD.Size = new Size(182, 37);
            cmbMaBD.TabIndex = 1;
            // 
            // cmbMaHS
            // 
            cmbMaHS.FormattingEnabled = true;
            cmbMaHS.Location = new Point(217, 101);
            cmbMaHS.Name = "cmbMaHS";
            cmbMaHS.Size = new Size(182, 37);
            cmbMaHS.TabIndex = 2;
            // 
            // fChiTietBangDiem
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 454);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fChiTietBangDiem";
            Text = "Chi tiết bảng điểm";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnTaiLai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbHeSo;
        private Label lbTenLHKT;
        private TextBox textBox1;
        private Label lbDiemTBM;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox cmbMaHS;
        private ComboBox cmbMaBD;
    }
}