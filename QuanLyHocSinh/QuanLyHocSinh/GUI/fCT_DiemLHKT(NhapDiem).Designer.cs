namespace WinFormsApp1.GUI
{
    partial class fNhapDiem
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
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbMaBD = new Label();
            lbMaHS = new Label();
            panel1 = new Panel();
            txbDiem = new TextBox();
            lbDiem = new Label();
            txbLan = new TextBox();
            lbLan = new Label();
            lbMaLHKT = new Label();
            cmbMaBD = new ComboBox();
            cmbMaHS = new ComboBox();
            cmbMaLHKT = new ComboBox();
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
            panel2.Location = new Point(0, 220);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 351);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
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
            dataGridView1.Size = new Size(1225, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            Column3.HeaderText = "MÃ LHKT";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "LẦN";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "ĐIỂM ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(1079, 156);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 6;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(946, 156);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 6;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(810, 156);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 6;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(676, 156);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 6;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbMaBD
            // 
            lbMaBD.AutoSize = true;
            lbMaBD.Location = new Point(27, 41);
            lbMaBD.Name = "lbMaBD";
            lbMaBD.Size = new Size(169, 29);
            lbMaBD.TabIndex = 7;
            lbMaBD.Text = "Mã bảng điểm:";
            // 
            // lbMaHS
            // 
            lbMaHS.AutoSize = true;
            lbMaHS.Location = new Point(397, 41);
            lbMaHS.Name = "lbMaHS";
            lbMaHS.Size = new Size(148, 29);
            lbMaHS.TabIndex = 1;
            lbMaHS.Text = "Mã học sinh:";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMaLHKT);
            panel1.Controls.Add(cmbMaHS);
            panel1.Controls.Add(cmbMaBD);
            panel1.Controls.Add(txbDiem);
            panel1.Controls.Add(lbDiem);
            panel1.Controls.Add(txbLan);
            panel1.Controls.Add(lbLan);
            panel1.Controls.Add(lbMaLHKT);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(lbMaBD);
            panel1.Controls.Add(lbMaHS);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 220);
            panel1.TabIndex = 2;
            // 
            // txbDiem
            // 
            txbDiem.Location = new Point(551, 98);
            txbDiem.Name = "txbDiem";
            txbDiem.Size = new Size(150, 37);
            txbDiem.TabIndex = 5;
            // 
            // lbDiem
            // 
            lbDiem.AutoSize = true;
            lbDiem.Location = new Point(469, 106);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(76, 29);
            lbDiem.TabIndex = 20;
            lbDiem.Text = "Điểm:";
            // 
            // txbLan
            // 
            txbLan.Location = new Point(202, 103);
            txbLan.Name = "txbLan";
            txbLan.Size = new Size(150, 37);
            txbLan.TabIndex = 4;
            // 
            // lbLan
            // 
            lbLan.AutoSize = true;
            lbLan.Location = new Point(137, 111);
            lbLan.Name = "lbLan";
            lbLan.Size = new Size(59, 29);
            lbLan.TabIndex = 18;
            lbLan.Text = "Lần:";
            // 
            // lbMaLHKT
            // 
            lbMaLHKT.AutoSize = true;
            lbMaLHKT.Location = new Point(753, 41);
            lbMaLHKT.Name = "lbMaLHKT";
            lbMaLHKT.Size = new Size(244, 29);
            lbMaLHKT.TabIndex = 16;
            lbMaLHKT.Text = "Mã loại hình kiểm tra:";
            // 
            // cmbMaBD
            // 
            cmbMaBD.FormattingEnabled = true;
            cmbMaBD.Location = new Point(202, 33);
            cmbMaBD.Name = "cmbMaBD";
            cmbMaBD.Size = new Size(182, 37);
            cmbMaBD.TabIndex = 1;
            // 
            // cmbMaHS
            // 
            cmbMaHS.FormattingEnabled = true;
            cmbMaHS.Location = new Point(551, 33);
            cmbMaHS.Name = "cmbMaHS";
            cmbMaHS.Size = new Size(182, 37);
            cmbMaHS.TabIndex = 2;
            // 
            // cmbMaLHKT
            // 
            cmbMaLHKT.FormattingEnabled = true;
            cmbMaLHKT.Location = new Point(1003, 33);
            cmbMaLHKT.Name = "cmbMaLHKT";
            cmbMaLHKT.Size = new Size(182, 37);
            cmbMaLHKT.TabIndex = 3;
            // 
            // fNhapDiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 571);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fNhapDiem";
            Text = "Nhập điểm";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnTaiLai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label lbMaBD;
        private Label lbMaHS;
        private Panel panel1;
        private Label lbMaLHKT;
        private TextBox txbDiem;
        private Label lbDiem;
        private TextBox txbLan;
        private Label lbLan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox cmbMaHS;
        private ComboBox cmbMaBD;
        private ComboBox cmbMaLHKT;
    }
}