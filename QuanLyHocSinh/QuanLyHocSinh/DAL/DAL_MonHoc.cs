using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_MonHoc
    {
        private static DAL_MonHoc instance;//ctr + r + e
        public static DAL_MonHoc Instance
        {
            get { if (instance == null) instance = new DAL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private DAL_MonHoc() { }
        public bool Them(string mamonhoc, string tenmonhoc, int heso)
        {
            string sql = "insert into MonHoc (MaMonHoc,TenMonHoc,HeSo) values(@MaMonHoc,@TenMonHoc,@HeSo)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] {mamonhoc, tenmonhoc, heso});
        }
        public bool Sua(string mamonhoc, string tenmonhoc, int heso)
        {
            string sql = "update MonHoc set MaMonHoc = @MaMonHoc, TenMonHoc = @TenMonHoc, HeSo=@HeSo ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mamonhoc, tenmonhoc, heso });
        }
        public bool Xoa(string mamonhoc, string tenmonhoc, int heso)
        {
            string sql = "delete from MonHoc where MaMonHoc = @MaMonHoc, TenMonHoc = @TenMonHoc, HeSo=@HeSo";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mamonhoc, tenmonhoc, heso });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from MonHoc");
        }
    }
}
