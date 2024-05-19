using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BLL;

namespace WindowsFormsApp3.GUI
{
    public partial class fQLNamHoc : Form
    {
        public fQLNamHoc()
        {
            InitializeComponent();
        }

        private void fQuanLyNamHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNamHoc.DataSource = BLL_NamHoc.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manamhoc = txbMaNamHoc.Text;
            string tennamhoc = txbTenNamHoc.Text;

            if (manamhoc.Length == 0 && tennamhoc.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_NamHoc.Instance.Them(manamhoc, tennamhoc) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã năm học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNamHoc.Text = dgvNamHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenNamHoc.Text = dgvNamHoc.CurrentRow.Cells[1].Value.ToString().Trim();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string manamhoc = txbMaNamHoc.Text;
            string tennamhoc = txbTenNamHoc.Text;

            if (manamhoc.Length == 0 && tennamhoc.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_NamHoc.Instance.Sua(manamhoc, tennamhoc) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã năm học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manamhoc = txbMaNamHoc.Text;
            string tennamhoc = txbTenNamHoc.Text;
            if (MessageBox.Show("Bạn có muốn xóa năm học" + tennamhoc + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_NamHoc.Instance.Xoa(manamhoc, tennamhoc) == true)
                        btnLamMoi.PerformClick();
                }

                catch
                {
                    MessageBox.Show("Năm học đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


    }
}
