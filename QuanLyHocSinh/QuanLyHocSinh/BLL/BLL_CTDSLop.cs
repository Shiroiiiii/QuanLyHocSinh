using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.BLL
{
    public class BLL_CTDSLop
    {
        private static BLL_CTDSLop instance;//ctr + r + e
        public static BLL_CTDSLop Instance
        {
            get { if (instance == null) instance = new BLL_CTDSLop(); return instance; }
            private set => instance = value;
        }
        private BLL_CTDSLop() { }
        public DataTable DanhSach()
        {
            return BLL_CTDSLop.Instance.DanhSach();
        }
        public bool Them(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            return BLL_CTDSLop.Instance.Them(mactdslop,malop,mahocki,mahocsinh,dtbhocki);
        }
        public bool Sua(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            return BLL_CTDSLop.Instance.Sua(mactdslop, malop, mahocki, mahocsinh, dtbhocki);
        }
        public bool Xoa(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            return BLL_CTDSLop.Instance.Xoa( mactdslop, malop, mahocki, mahocsinh, dtbhocki);
        }
    }
}
