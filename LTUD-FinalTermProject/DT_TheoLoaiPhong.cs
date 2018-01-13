using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class DT_TheoLoaiPhong
    {
        public string ID { get; set; }
        public string MaLoaiPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int DoanhThu { get; set; }
        public static int iID = 0, iMaLoaiPhong = 1, iNgayBatDau = 2, iNgayKetThuc = 3, iDoanhThu = 4;

        public static DT_TheoLoaiPhong Read(SqlDataReader reader)
        {
            var bc = new DT_TheoLoaiPhong()
            {
                ID = reader.GetString(iID),
                MaLoaiPhong = reader.GetString(iMaLoaiPhong),
                NgayBatDau = reader.GetDateTime(iNgayBatDau),
                NgayKetThuc = reader.GetDateTime(iNgayKetThuc),
                DoanhThu = reader.GetInt32(iDoanhThu)
            };
            return bc;
        }
    }
}
