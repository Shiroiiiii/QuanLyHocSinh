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
    public partial class fQLKhoiLop : Form
    {
        public fQLKhoiLop()
        {
            InitializeComponent();
        }

        private void fQuanLyKhoiLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhoiLop.DataSource = BLL_KhoiLop.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoilop = txbMaKhoiLop.Text;
            string tenkhoilop = txbTenKhoiLop.Text;

            if(makhoilop.Length == 0 && tenkhoilop.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(BLL_KhoiLop.Instance.Them(makhoilop, tenkhoilop)==true )
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã khối lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhoiLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaKhoiLop.Text = dgvKhoiLop.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenKhoiLop.Text = dgvKhoiLop.CurrentRow.Cells[1].Value.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makhoilop = txbMaKhoiLop.Text;
            string tenkhoilop = txbTenKhoiLop.Text;

            if (makhoilop.Length == 0 && tenkhoilop.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_KhoiLop.Instance.Sua(makhoilop, tenkhoilop) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã khối lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makhoilop = txbMaKhoiLop.Text;
            string tenkhoilop = txbTenKhoiLop.Text;
            if(MessageBox.Show("Bạn có muốn xóa khối lớp" + tenkhoilop +"không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                try
                {
                    if (BLL_KhoiLop.Instance.Xoa(makhoilop, tenkhoilop) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã khối lớp đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }
        }
}
