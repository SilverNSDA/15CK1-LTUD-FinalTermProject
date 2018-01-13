using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class HoaDon
    {
        public string MaPhieuThue { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public static int iMaPhieuThue = 0, iMaKhachHang = 1, iNgayThanhToan = 2;

        public static HoaDon Read(SqlDataReader reader)
        {
            var ctpt = new HoaDon()
            {
                MaPhieuThue = reader.GetString(iMaPhieuThue),
                MaKhachHang = reader.GetString(iMaKhachHang),
                NgayThanhToan=reader.GetDateTime(iNgayThanhToan)
            };
            return ctpt;
        }
    }
}
