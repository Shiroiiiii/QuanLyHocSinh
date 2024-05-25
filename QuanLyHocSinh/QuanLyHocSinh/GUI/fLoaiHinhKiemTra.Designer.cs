namespace WinFormsApp1.GUI
{
    partial class fLoaiHinhKiemTra
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            lbTenLHKT = new Label();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txbHeSo = new TextBox();
            lbHeSo = new Label();
            txbTenLHKT = new TextBox();
            lbMaLHKT = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
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
            panel2.Size = new Size(1025, 234);
            panel2.TabIndex = 3;
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
            dataGridView1.Size = new Size(1025, 234);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txbTenLHKT);
            panel1.Controls.Add(lbTenLHKT);
            panel1.Controls.Add(lbMaLHKT);
            panel1.Controls.Add(btnTaiLai);
            panel1.Controls.Add(lbHeSo);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(txbHeSo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 220);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(788, 40);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 37);
            textBox1.TabIndex = 2;
            // 
            // lbTenLHKT
            // 
            lbTenLHKT.AutoSize = true;
            lbTenLHKT.Location = new Point(523, 48);
            lbTenLHKT.Name = "lbTenLHKT";
            lbTenLHKT.Size = new Size(250, 29);
            lbTenLHKT.TabIndex = 15;
            lbTenLHKT.Text = "Tên loại hình kiểm tra:";
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(882, 149);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.TabStop = false;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(749, 149);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 4;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(613, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(479, 149);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 4;
            btnThem.TabStop = false;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txbHeSo
            // 
            txbHeSo.Location = new Point(293, 106);
            txbHeSo.MaxLength = 10;
            txbHeSo.Name = "txbHeSo";
            txbHeSo.Size = new Size(150, 37);
            txbHeSo.TabIndex = 3;
            // 
            // lbHeSo
            // 
            lbHeSo.AutoSize = true;
            lbHeSo.Location = new Point(102, 114);
            lbHeSo.Name = "lbHeSo";
            lbHeSo.Size = new Size(185, 29);
            lbHeSo.TabIndex = 10;
            lbHeSo.Text = "Hệ số tính điểm:";
            // 
            // txbTenLHKT
            // 
            txbTenLHKT.BackColor = SystemColors.ActiveBorder;
            txbTenLHKT.Location = new Point(293, 40);
            txbTenLHKT.MaxLength = 10;
            txbTenLHKT.Name = "txbTenLHKT";
            txbTenLHKT.Size = new Size(150, 37);
            txbTenLHKT.TabIndex = 1;
            txbTenLHKT.TextChanged += txbTenLHKT_TextChanged;
            // 
            // lbMaLHKT
            // 
            lbMaLHKT.AutoSize = true;
            lbMaLHKT.Location = new Point(43, 48);
            lbMaLHKT.Name = "lbMaLHKT";
            lbMaLHKT.Size = new Size(244, 29);
            lbMaLHKT.TabIndex = 7;
            lbMaLHKT.Text = "Mã loại hình kiểm tra:";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "MÃ LHKT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "TÊN LHKT";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "HỆ SỐ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // fLoaiHinhKiemTra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 454);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLoaiHinhKiemTra";
            Text = "Loại hình kiểm tra";
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
        private TextBox textBox1;
        private TextBox txbTenLHKT;
        private Label lbTenLHKT;
        private Label lbMaLHKT;
        private Button btnTaiLai;
        private Label lbHeSo;
        private Button btnSua;
        private TextBox txbHeSo;
        private Button btnXoa;
        private Button btnThem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}