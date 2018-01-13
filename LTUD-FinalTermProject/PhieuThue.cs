using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class PhieuThue
    {
        public string ID { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        static int iID = 0, iMaPhong = 1, iNgayBatDau = 2;

        public static PhieuThue Read(SqlDataReader reader)
        {
            var pt = new PhieuThue()
            {
                ID = reader.GetString(iID),
                MaPhong =reader.GetString(iMaPhong),
                NgayBatDau = reader.GetDateTime(iNgayBatDau)
            };
            return pt;
        }
    }
}
