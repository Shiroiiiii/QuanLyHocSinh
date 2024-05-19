using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BLL;

namespace WindowsFormsApp3.GUI
{
    public partial class fQuanLyLop : Form
    {

        public fQuanLyLop()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            fQLCTDSLop f = new fQLCTDSLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoiLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoiLop.DisplayMember = "TenKhoiLop";
            cmbMaKhoiLop.ValueMember = "MaKhoiLop";
            if(BLL_KhoiLop.Instance.DanhSach().Rows.Count > 0)
                cmbMaKhoiLop.SelectedIndex = 0;
            cmbMaNamHoc.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaNamHoc.DisplayMember = "TenNamHoc";
            cmbMaNamHoc.ValueMember = "MaNamHoc";
            if (BLL_NamHoc.Instance.DanhSach().Rows.Count > 0)
                cmbMaNamHoc.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoilop = cmbMaKhoiLop.SelectedValue .ToString().Trim();
            string manamhoc = cmbMaNamHoc.SelectedValue.ToString().Trim();
            int siso = (int)numSoLuong.Value;
            if(malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, siso, makhoilop, manamhoc) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaLop.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim() ;
            txbTenLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            numSoLuong.Value = (int)dgvLop.CurrentRow.Cells[2].Value;
            cmbMaKhoiLop.SelectedValue = dgvLop.CurrentRow.Cells[3].Value.ToString().Trim();
            cmbMaNamHoc.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoilop = cmbMaKhoiLop.SelectedValue.ToString().Trim();
            string manamhoc = cmbMaNamHoc.SelectedValue.ToString().Trim();
            int siso = (int)numSoLuong.Value;
            if (MessageBox.Show("Bạn có muốn xóa lớp" + tenlop + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try 
                {
                    if (BLL_Lop.Instance.Xoa(malop, tenlop, siso, makhoilop, manamhoc) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Lớp đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoilop = cmbMaKhoiLop.SelectedValue.ToString().Trim();
            string manamhoc = cmbMaNamHoc.SelectedValue.ToString().Trim();
            int siso = (int)numSoLuong.Value;
            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Sua(malop, tenlop, siso, makhoilop, manamhoc) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
