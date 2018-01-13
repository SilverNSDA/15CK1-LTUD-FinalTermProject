using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class CT_PhieuThue
    {
        public string ID { get; set; }
        public string MaPhieuThue { get; set; }
        public string MaKhachHang { get; set; }
        public static int iID = 0, iMaPhieuThue = 1, iMaKhachHang = 2;

        public static CT_PhieuThue Read(SqlDataReader reader)
        {
            var ctpt = new CT_PhieuThue()
            {
                ID = reader.GetString(iID),
                MaPhieuThue = reader.GetString(iMaPhieuThue),
                MaKhachHang = reader.GetString(iMaKhachHang)
            };
            return ctpt;
        }
    }
}
