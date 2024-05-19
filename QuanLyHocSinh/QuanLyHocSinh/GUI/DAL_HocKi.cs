using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_HocKi
    {
        private static DAL_HocKi instance;//ctr + r + e
        public static DAL_HocKi Instance
        {
            get { if (instance == null) instance = new DAL_HocKi(); return instance; }
            private set => instance = value;
        }
        private DAL_HocKi() { }
        public bool Them(string mahocki, string tenhocki)
        {
            string sql = "insert into HocKi(MaHocKi,TenHocKi) values(@MaHocKi, @TenHocKi)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mahocki,tenhocki });
        }
        public bool Sua(string mahocki, string tenhocki)
        {
            string sql = "update HocKi set MaHocKi = @MaHocKi, TenHocKi = @TenHocKi";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] {mahocki,tenhocki});
        }
        public bool Xoa(string mahocki, string tenhocki)
        {
            string sql = "delete from HocKi where MaHocKi = @MaHocKi, TenHocKi = @TenHocKi";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mahocki,tenhocki});
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from HocKi");
        }
    }
}
