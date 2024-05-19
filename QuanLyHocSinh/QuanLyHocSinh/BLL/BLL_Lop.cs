using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.BLL
{
    public class BLL_Lop
    {
        private static readonly Lazy<BLL_Lop> lazyInstance = new Lazy<BLL_Lop>(() => new BLL_Lop());
        public static BLL_Lop Instance
        {
            get { return lazyInstance.Value; }
        }

        /*private static BLL_Lop instance;//ctr + r + e
        public static BLL_Lop Instance
        {
            get { if (instance == null) instance = new BLL_Lop(); return instance; }
            private set => instance = value;
        }*/
        private BLL_Lop() { }
        public DataTable DanhSach()
        {
            return BLL_Lop.Instance.DanhSach();
        }
        public bool Them(string malop, string tenlop, int siso, string makhoilop, string manamhoc)
        {
            return BLL_Lop.Instance.Them(malop, tenlop, siso,makhoilop, manamhoc);
        }
        public bool Sua(string malop, string tenlop, int siso, string makhoilop, string manamhoc)
        {
            return BLL_Lop.Instance.Sua(malop, tenlop, siso, makhoilop, manamhoc);
        }
        public bool Xoa(string malop, string tenlop, int siso, string makhoilop, string manamhoc)
        {
            return BLL_Lop.Instance.Xoa(malop, tenlop, siso, makhoilop, manamhoc);
        }
    }
}
