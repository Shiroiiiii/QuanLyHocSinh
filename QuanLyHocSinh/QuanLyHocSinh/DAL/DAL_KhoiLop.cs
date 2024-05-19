using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_KhoiLop
    {
        private static DAL_KhoiLop instance;//ctr + r + e
        public static DAL_KhoiLop Instance
        {
            get { if (instance == null) instance = new DAL_KhoiLop(); return instance; }
            private set => instance = value;
        }
        private DAL_KhoiLop() { }
        public bool Them(string makhoilop, string tenkhoilop)
        {
            string sql = "insert into KhoiLop(MaKhoiLop, TenKhoiLop) values(@MaKhoiLop, @TenKhoiLop)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { makhoilop, tenkhoilop });
        }
        public bool Sua(string makhoilop, string tenkhoilop)
        {
            string sql = "update KhoiLop set MaKhoiLop = @MaKhoiLop, TenKhoiLop = @TenKhoiLop";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] {makhoilop, tenkhoilop  });
        }
        public bool Xoa(string makhoilop,  string tenkhoilop)
        {
            string sql = "delete from KhoiLop where MaKhoiLop = @MaKhoiLop, TenKhoiLop = @TenKhoiLop";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] {makhoilop, tenkhoilop });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from KhoiLop");
        }

    }
}
