using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.BLL
{
    public class BLL_MonHoc
    {
        private static BLL_MonHoc instance;//ctr + r + e
        public static BLL_MonHoc Instance
        {
            get { if (instance == null) instance = new BLL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private BLL_MonHoc() { }
        public DataTable DanhSach()
        {
            return BLL_MonHoc.Instance.DanhSach();
        }
        public bool Them(string mamonhoc, string tenmonhoc,int heso)
        {
            return BLL_MonHoc.Instance.Them(mamonhoc, tenmonhoc,heso);
        }
        public bool Sua(string mamonhoc, string tenmonhoc, int heso)
        {
            return BLL_MonHoc.Instance.Sua(mamonhoc, tenmonhoc, heso);
        }
        public bool Xoa(string mamonhoc, string tenmonhoc, int heso)
        {
            return BLL_MonHoc.Instance.Xoa(mamonhoc, tenmonhoc, heso);
        }
    }
}
