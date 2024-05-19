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
    public partial class fQLHocKi : Form
    {
        public fQLHocKi()
        {
            InitializeComponent();
        }

        private void fQuanLyHocKi_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvHocKi.DataSource = BLL_HocKi.Instance.DanhSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahocki = txbMaHocKi.Text;
            string tenhocki = txbTenHocKi.Text;

            if (mahocki.Length == 0 && tenhocki.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_HocKi.Instance.Them(mahocki, tenhocki) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã học kì đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dgvHocKi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaHocKi.Text = dgvHocKi.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenHocKi.Text = dgvHocKi.CurrentRow.Cells[1].Value.ToString().Trim();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahocki = txbMaHocKi.Text;
            string tenhocki = txbTenHocKi.Text;

            if (mahocki.Length == 0 && tenhocki.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_HocKi.Instance.Sua(mahocki, tenhocki) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã học kì đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahocki = txbMaHocKi.Text;
            string tenhocki = txbTenHocKi.Text;
            if (MessageBox.Show("Bạn có muốn xóa học kì" + tenhocki + "không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_HocKi.Instance.Xoa(mahocki, tenhocki) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("học kì đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
