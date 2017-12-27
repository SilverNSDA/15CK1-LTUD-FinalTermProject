using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Tuan2
{
    class DataUtil
    {
        static string cnString;
        static string nameCS = "sqlPC_QLSV";
        static SqlConnection cn;
        static DataUtil()
        {
            cnString = ConfigurationManager.ConnectionStrings[nameCS].ConnectionString;
            cn = new SqlConnection(cnString);

        }
        static SqlCommand CreateCommand()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            var cm = new SqlCommand();
            cm.Connection = cn;
            return cm;
        }
        public static List<QueQuan> DSQueQuan()
        {
            var lqq = new List<QueQuan>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM QueQuan";
            var reader = cm.ExecuteReader();
            while(reader.Read())
            {
                lqq.Add(QueQuan.ReadQueQuan(reader));
            }
            cn.Close();
            return lqq;
        }
        public static List<SinhVien> DSSinhvien()
        {
            var lsv = new List<SinhVien>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM SinhVIen";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lsv.Add(SinhVien.ReadSinhVien(reader));
            }
            cn.Close();
            return lsv;

        }
        public static bool ThemSinhVien(SinhVien sv)
        {
            var cm = CreateCommand();
            cm.CommandText = @"INSERT INTO SinhVien (MSSV, HoTen, NgaySinh, QueQuanID, GioiTinh) VALUES (@MSSV, @HoTen, @NgaySinh, @QueQuanID, @GioiTinh)";
            cm.Parameters.Add(new SqlParameter("@MSSV", sv.MSSV));
            cm.Parameters.Add(new SqlParameter("@HoTen", sv.HoTen));
            cm.Parameters.Add(new SqlParameter("@NgaySinh", sv.NgaySinh));
            cm.Parameters.Add(new SqlParameter("@QueQuanID", sv.QueQuanID));
            cm.Parameters.Add(new SqlParameter("@GioiTinh", sv.GioiTinh));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }
        public static bool CapNhapSinhVien(SinhVien sv)
        {
            var cm = CreateCommand();
            cm.CommandText = @"UPDATE SinhVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, QueQuanID=@QueQuanID, GioiTinh=@GioiTinh WHERE MSSV=@MSSV";
            cm.Parameters.Add(new SqlParameter("@MSSV", sv.MSSV));
            cm.Parameters.Add(new SqlParameter("@HoTen", sv.HoTen));
            cm.Parameters.Add(new SqlParameter("@NgaySinh", sv.NgaySinh));
            cm.Parameters.Add(new SqlParameter("@QueQuanID", sv.QueQuanID));
            cm.Parameters.Add(new SqlParameter("@GioiTinh", sv.GioiTinh));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }
        public static bool XoaSinhVien(SinhVien sv)
        {
            var cm = CreateCommand();
            cm.CommandText = @"DELETE FROM SinhVien WHERE MSSV=@MSSV";
            cm.Parameters.Add(new SqlParameter("@MSSV", sv.MSSV));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }
    }
}
