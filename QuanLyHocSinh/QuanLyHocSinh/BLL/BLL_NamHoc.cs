using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.BLL
{
    public class BLL_NamHoc
    {
        private static BLL_NamHoc instance;//ctr + r + e
        public static BLL_NamHoc Instance
        {
            get { if (instance == null) instance = new BLL_NamHoc(); return instance; }
            private set => instance = value;
        }
        private BLL_NamHoc() { }
        public DataTable DanhSach()
        {
            return BLL_NamHoc.Instance.DanhSach();
        }
        public bool Them(string manamhoc, string tennamhoc)
        {
            return BLL_NamHoc.Instance.Them(manamhoc, tennamhoc);
        }
        public bool Sua(string manamhoc, string tennamhoc)
        {
            return BLL_NamHoc.Instance.Sua(manamhoc,tennamhoc);
        }
        public bool Xoa(string manamhoc, string tennamhoc)
        {
            return BLL_NamHoc.Instance.Xoa(manamhoc,tennamhoc);
        }
    }
}
