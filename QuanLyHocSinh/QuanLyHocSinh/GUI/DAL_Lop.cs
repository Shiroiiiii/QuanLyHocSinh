using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAL
{
    public class DAL_Lop
    {
            private static DAL_Lop instance;//ctr + r + e
            public static DAL_Lop Instance
            {
                get { if (instance == null) instance = new DAL_Lop(); return instance; }
                private set => instance = value;
            }
            private DAL_Lop() { }
            public bool Them(string malop, string tenlop, int SiSo, string MaKhoiLop, string MaNamHoc)
            {
                string sql = "insert into Lop(MaLop,TenLop,SiSo,MaKhoiLop,MaNamHoc) values(@MaLop,@TenLop,@SiSo,@MaKhoiLop,@MaNamHoc)";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { malop, tenlop, SiSo, MaKhoiLop, MaNamHoc });
            }
            public bool Sua(string malop, string tenlop,int SiSo, string MaKhoiLop, string MaNamHoc)
            {
                string sql = "update Lop set MaLop = @MaLop, TenLop = @TenLop, SiSo=@SiSo, MaKhoiLop=@MaKhoiLop, MaNamHoc=@MaNamHoc ";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { malop, tenlop, SiSo, MaKhoiLop, MaNamHoc });
            }
            public bool Xoa(string malop, string tenlop, int SiSo, string MaKhoiLop, string MaNamHoc)
            {
                string sql = "delete from Lop where MaLop = @MaLop, TenLop = @TenLop, SiSo=@SiSo, MaKhoiLop=@MaKhoiLop, MaNamHoc=@MaNamHoc ";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { malop, tenlop, SiSo, MaKhoiLop, MaNamHoc });
            }
            public DataTable DanhSach()
            {
                return KetNoi.Instance.ExcuteQuery("select * from Lop");
            }
    }
}
