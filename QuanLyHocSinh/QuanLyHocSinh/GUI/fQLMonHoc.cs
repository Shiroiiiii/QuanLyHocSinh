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
    public partial class fQLMonHoc : Form
    {
        public fQLMonHoc()
        {
            InitializeComponent();
        }

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text;
            string tenmonhoc = txbTenMonHoc.Text;
            int heso = (int)numHeSo.Value;

            if (mamonhoc.Length > 0 && tenmonhoc.Length > 0)
            {
                try
                {
                    if (BLL_MonHoc.Instance.Them(mamonhoc,tenmonhoc, heso) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaMonHoc.Text = dgvMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            numHeSo.Value = (int)dgvMonHoc.CurrentRow.Cells[2].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text;
            string tenmonhoc = txbTenMonHoc.Text;
            int heso = (int)numHeSo.Value;

            if (MessageBox.Show("Bạn có muốn xóa môn học" + tenmonhoc + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_MonHoc.Instance.Xoa(mamonhoc, tenmonhoc, heso) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Môn học đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mamonhoc = txbMaMonHoc.Text;
            string tenmonhoc = txbTenMonHoc.Text;
            int heso = (int)numHeSo.Value;

            if (mamonhoc.Length > 0 && tenmonhoc.Length > 0)
            {
                try
                {
                    if (BLL_MonHoc.Instance.Sua(mamonhoc, tenmonhoc, heso) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
