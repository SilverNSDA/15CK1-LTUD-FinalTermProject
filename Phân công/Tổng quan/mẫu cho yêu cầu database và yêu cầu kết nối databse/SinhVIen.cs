using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tuan2
{
    class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int QueQuanID { get; set; }
        public bool GioiTinh { get; set; }
        static int iMSSV = 0, iHoTen = 1, iNgaySinh=2, iQueQuanID = 3, iGioiTinh = 4;
        public static SinhVien ReadSinhVien(SqlDataReader reader)
        {
            var sv = new SinhVien
            {
                MSSV = reader.GetString(iMSSV),
                HoTen = reader.GetString(iHoTen),
                NgaySinh = reader.GetDateTime(iNgaySinh),
                QueQuanID = reader.GetInt32(iQueQuanID),
                GioiTinh = reader.GetBoolean(iGioiTinh)

            };
            return sv;
        }
        public static string CreateMSSV()
        {
            var ds = DataUtil.DSSinhvien();
            ds.Sort((sv1, sv2) => -sv2.MSSV.CompareTo(sv2.MSSV));
            long ms = long.Parse(ds[0].MSSV);
            ms++;
            return ms.ToString();
        }
    }
}
