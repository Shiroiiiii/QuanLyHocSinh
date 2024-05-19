using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_CTDSLop
    {
        private static DAL_CTDSLop instance;//ctr + r + e
        public static DAL_CTDSLop Instance
        {
            get { if (instance == null) instance = new DAL_CTDSLop(); return instance; }
            private set => instance = value;
        }
        private DAL_CTDSLop() { }
        public bool Them(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            string sql = "insert into CTDSLop(MaCTDSLop,MaLop,MaHocKi,MaHocSinh,DTBHocKi) values(@MaCTDSLop,@MaLop,@MaHocKi,@MaHocSinh,@DTBHocKi)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mactdslop,malop,mahocki, mahocsinh, dtbhocki });
        }
        public bool Sua(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            string sql = "update CTDSLop set MaCTDSLop = @MaCTDSLop, MaLop = @MaLop,MaHocKi=@MaHocKi,MaHocSinh = @MaHocSinh, DTBHocKi = @DTBHocKi";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { mactdslop, malop, mahocki, mahocsinh, dtbhocki });
        }
        public bool Xoa(string mactdslop, string malop, string mahocki, string mahocsinh, decimal dtbhocki)
        {
            string sql = "delete from CTDSLop where MaCTDSLop = @MaCTDSLop, MaLop = @MaLop,MaHocKi=@MaHocKi,MaHocSinh = @MaHocSinh, DTBHocKi = @DTBHocKi ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] {mactdslop, malop, mahocki, mahocsinh, dtbhocki });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from CTDSLop");
        }
    }
}
