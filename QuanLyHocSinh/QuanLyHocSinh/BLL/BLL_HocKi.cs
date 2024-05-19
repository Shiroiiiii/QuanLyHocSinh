using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.BLL
{
    public class BLL_HocKi
    {
        private static BLL_HocKi instance;//ctr + r + e
        public static BLL_HocKi Instance
        {
            get { if (instance == null) instance = new BLL_HocKi(); return instance; }
            private set => instance = value;
        }
        private BLL_HocKi() { }
        public DataTable DanhSach()
        {
            return BLL_HocKi.Instance.DanhSach();
        }
        public bool Them(string mahocki, string tenhocki)
        {
            return BLL_HocKi.Instance.Them(mahocki,tenhocki);
        }
        public bool Sua(string mahocki, string tenhocki)
        {
            return BLL_HocKi.Instance.Sua(mahocki, tenhocki);
        }
        public bool Xoa(string mahocki, string tenhocki)
        {
            return BLL_HocKi.Instance.Xoa(mahocki, tenhocki);
        }
    }
}
