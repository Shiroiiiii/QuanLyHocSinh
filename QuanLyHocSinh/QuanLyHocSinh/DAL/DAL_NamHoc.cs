using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_NamHoc
    {
        private static DAL_NamHoc instance;//ctr + r + e
        public static DAL_NamHoc Instance
        {
            get { if (instance == null) instance = new DAL_NamHoc(); return instance; }
            private set => instance = value;
        }
        private DAL_NamHoc() { }
        public bool Them(string manamhoc, string tennamhoc)
        {
            string sql = "insert into NamHoc(MaNamHoc, TenNamHoc) values(@MaNamHoc, @TenNamHoc)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { manamhoc, tennamhoc });
        }
        public bool Sua(string manamhoc, string tennamhoc)
        {
            string sql = "update NamHoc set MaNamHoc = @MaNamHoc, TenNamHoc = @TenNamHoc";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { manamhoc, tennamhoc });
        }
        public bool Xoa(string manamhoc, string tennamhoc)
        {
            string sql = "delete from NamHoc where MaNamHoc = @MaNamHoc, TenNamHoc = @TenNamHoc";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { manamhoc, tennamhoc });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from NamHoc");
        }
    }
}
