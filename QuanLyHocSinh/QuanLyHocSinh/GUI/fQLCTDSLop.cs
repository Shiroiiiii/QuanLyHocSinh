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
    public partial class fQuanLyCTDSLop : Form
    {
        public fQuanLyCTDSLop()
        {
            InitializeComponent();
        }

        private void txbDTBHocKi_TextChanged(object sender, EventArgs e)
        {

        }

        private void fQuanLyCTDSLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSLop.DataSource = BLL_CTDSLop.Instance.DanhSach();
            cmbMaLop.DataSource = BLL_CTDSLop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            if (BLL_CTDSLop.Instance.DanhSach().Rows.Count > 0)
                cmbMaLop.SelectedIndex = 0;
            cmbMaHocKi.DataSource = BLL_CTDSLop.Instance.DanhSach();
            cmbMaHocKi.DisplayMember = "TenHocKi";
            cmbMaHocKi.ValueMember = "MaHocKi";
            if (BLL_CTDSLop.Instance.DanhSach().Rows.Count > 0)
                cmbMaHocKi.SelectedIndex = 0;
            cmbMaHocSinh.DataSource = BLL_CTDSLop.Instance.DanhSach();
            cmbMaHocSinh.DisplayMember = "TenHocSinh";
            cmbMaHocSinh.ValueMember = "MaHocSinh";
            if (BLL_CTDSLop.Instance.DanhSach().Rows.Count > 0)
                cmbMaHocSinh.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mactdslop = txbMaCTDSLop.Text.Trim(); // Chuyển đổi từ TextBox
            string malop = cmbMaLop.SelectedValue.ToString().Trim();
            string mahocki = cmbMaHocKi.SelectedValue.ToString().Trim();
            string mahocsinh = cmbMaHocSinh.SelectedValue.ToString().Trim();
            string dtbhockiText = txbDTBHocKi.Text.Trim();
            decimal dtbhocki;

            if (mactdslop.Length > 0 && decimal.TryParse(dtbhockiText, out dtbhocki))
            {
                try
                {
                    if (BLL_CTDSLop.Instance.Them(mactdslop,malop,mahocki,mahocsinh,dtbhocki))
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã chi tiết danh sách lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống và nhập đúng giá trị cho điểm trung bình học kì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvDSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaCTDSLop.Text = dgvDSLop.CurrentRow.Cells[0].Value.ToString().Trim();
            cmbMaLop.SelectedValue = dgvDSLop.CurrentRow.Cells[1].Value.ToString().Trim();
            cmbMaHocKi.SelectedValue = dgvDSLop.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbMaHocSinh.SelectedValue = dgvDSLop.CurrentRow.Cells[3].Value.ToString().Trim();
            if (decimal.TryParse(dgvDSLop.CurrentRow.Cells[4].Value.ToString(), out decimal dtbhocKiValue))
            {
                txbDTBHocKi.Text = dtbhocKiValue.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mactdslop = txbMaCTDSLop.Text.Trim(); // Chuyển đổi từ TextBox
            string malop = cmbMaLop.SelectedValue.ToString().Trim();
            string mahocki = cmbMaHocKi.SelectedValue.ToString().Trim();
            string mahocsinh = cmbMaHocSinh.SelectedValue.ToString().Trim();
            string dtbhockiText = txbDTBHocKi.Text.Trim();
            decimal dtbhocki;
            if (!decimal.TryParse(dtbhockiText, out dtbhocki))
            {
                MessageBox.Show("Giá trị điểm trung bình học kỳ không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa chi tiết danh sách lớp " + mactdslop + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_CTDSLop.Instance.Xoa(mactdslop, malop, mahocki, mahocsinh, dtbhocki))
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lớp đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mactdslop = txbMaCTDSLop.Text.Trim(); // Chuyển đổi từ TextBox
            string malop = cmbMaLop.SelectedValue.ToString().Trim();
            string mahocki = cmbMaHocKi.SelectedValue.ToString().Trim();
            string mahocsinh = cmbMaHocSinh.SelectedValue.ToString().Trim();
            string dtbhockiText = txbDTBHocKi.Text.Trim();
            decimal dtbhocki;

            if (mactdslop.Length > 0 && decimal.TryParse(dtbhockiText, out dtbhocki))
            {
                try
                {
                    if (BLL_CTDSLop.Instance.Sua(mactdslop, malop, mahocki, mahocsinh, dtbhocki))
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã chi tiết danh sách lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống và nhập đúng giá trị cho điểm trung bình học kì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
