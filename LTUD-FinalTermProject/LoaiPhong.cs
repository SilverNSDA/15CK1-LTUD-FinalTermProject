using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class LoaiPhong
    {
        public string ID { get; set; }
        public float DonGia { get; set; }
        static int iID = 0, iDonGia = 1;

        public static LoaiPhong Read(SqlDataReader reader)
        {
            var lp = new LoaiPhong()
            {
                ID = reader.GetString(iID),
                DonGia = reader.GetInt32(iDonGia)
            };
            return lp;
            
        }
    }
}
