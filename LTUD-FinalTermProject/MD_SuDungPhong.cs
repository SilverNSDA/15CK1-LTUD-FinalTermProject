using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class MD_SuDungPhong
    {
        public string ID { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int MatDo { get; set; }
        public static int iID = 0, iMaPhong = 1, iNgayBatDau = 2, iNgayKetThuc = 3, iMatDo = 4;

        public static MD_SuDungPhong Read(SqlDataReader reader)
        {
            var bc = new MD_SuDungPhong()
            {
                ID = reader.GetString(iID),
                MaPhong = reader.GetString(iMaPhong),
                NgayBatDau = reader.GetDateTime(iNgayBatDau),
                NgayKetThuc = reader.GetDateTime(iNgayKetThuc),
                MatDo = reader.GetInt32(iMatDo)
            };
            return bc;
        }
    }
}
