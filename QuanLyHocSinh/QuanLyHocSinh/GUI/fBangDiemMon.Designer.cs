namespace WinFormsApp1.GUI
{
    partial class fBangDiem
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lbMaMH = new Label();
            lbMaHK = new Label();
            lbMaLop = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cmbMaLop = new ComboBox();
            cmbMaHK = new ComboBox();
            cmbMaMH = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbMaMH);
            panel1.Controls.Add(cmbMaHK);
            panel1.Controls.Add(cmbMaLop);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(lbMaMH);
            panel1.Controls.Add(lbMaHK);
            panel1.Controls.Add(lbMaLop);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 220);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(214, 38);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 37);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 13;
            label1.Text = "Mã bảng điểm:";
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(860, 145);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 5;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(727, 145);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 5;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(591, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(457, 145);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 5;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbMaMH
            // 
            lbMaMH.AutoSize = true;
            lbMaMH.Location = new Point(56, 108);
            lbMaMH.Name = "lbMaMH";
            lbMaMH.Size = new Size(152, 29);
            lbMaMH.TabIndex = 11;
            lbMaMH.Text = "Mã môn học:";
            // 
            // lbMaHK
            // 
            lbMaHK.AutoSize = true;
            lbMaHK.Location = new Point(690, 46);
            lbMaHK.Name = "lbMaHK";
            lbMaHK.Size = new Size(126, 29);
            lbMaHK.TabIndex = 7;
            lbMaHK.Text = "Mã học kì:";
            // 
            // lbMaLop
            // 
            lbMaLop.AutoSize = true;
            lbMaLop.Location = new Point(399, 46);
            lbMaLop.Name = "lbMaLop";
            lbMaLop.Size = new Size(94, 29);
            lbMaLop.TabIndex = 5;
            lbMaLop.Text = "Mã lớp:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 220);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 234);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
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
            dataGridView1.Size = new Size(1025, 234);
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
            Column2.HeaderText = "MÃ LỚP";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "MÃ HỌC KÌ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "MÃ MÔN HỌC";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // cmbMaLop
            // 
            cmbMaLop.FormattingEnabled = true;
            cmbMaLop.Location = new Point(499, 38);
            cmbMaLop.Name = "cmbMaLop";
            cmbMaLop.Size = new Size(182, 37);
            cmbMaLop.TabIndex = 2;
            // 
            // cmbMaHK
            // 
            cmbMaHK.FormattingEnabled = true;
            cmbMaHK.Location = new Point(822, 38);
            cmbMaHK.Name = "cmbMaHK";
            cmbMaHK.Size = new Size(182, 37);
            cmbMaHK.TabIndex = 3;
            // 
            // cmbMaMH
            // 
            cmbMaMH.FormattingEnabled = true;
            cmbMaMH.Location = new Point(214, 100);
            cmbMaMH.Name = "cmbMaMH";
            cmbMaMH.Size = new Size(182, 37);
            cmbMaMH.TabIndex = 4;
            // 
            // fBangDiem
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 454);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fBangDiem";
            Text = "Bảng điểm môn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lbMaLop;
        private Label lbMaHK;
        private Label lbMaMH;
        private Button btnThem;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnSua;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbMaMH;
        private ComboBox cmbMaHK;
        private ComboBox cmbMaLop;
    }
}