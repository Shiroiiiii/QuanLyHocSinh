using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAL;

namespace WindowsFormsApp3.BLL
{
    public class BLL_KhoiLop
    {
        private static BLL_KhoiLop instance;//ctr + r + e
        public static BLL_KhoiLop Instance
        {
            get { if (instance == null) instance = new BLL_KhoiLop(); return instance; }
            private set => instance = value;
        }
        private BLL_KhoiLop() { }
        public DataTable DanhSach()
        {
            return BLL_KhoiLop.Instance.DanhSach();
        }
        public bool Them(string makhoilop, string tenkhoilop)
        {
            return BLL_KhoiLop.Instance.Them(makhoilop, tenkhoilop);
        }
        public bool Sua(string makhoilop, string tenkhoilop)
        {
            return BLL_KhoiLop.Instance.Sua(makhoilop, tenkhoilop);
        }
        public bool Xoa(string makhoilop, string tenkhoilop)
        {
            return BLL_KhoiLop.Instance.Xoa(makhoilop, tenkhoilop);
        }
    }
}
