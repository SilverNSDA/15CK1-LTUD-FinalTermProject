using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class Phong
    {
        public string ID { get; set; }
        public string LoaiPhong { get; set; }
        public string GhiChu { get; set; }
        static int iID = 0, iLoaiPhong = 1, iGhiChu = 2;

        public static Phong Read(SqlDataReader reader)
        {
            var p = new Phong()
            {
                ID = reader.GetString(iID),
                LoaiPhong = reader.GetString(iLoaiPhong),
                GhiChu = reader.GetString(iGhiChu)
            };
            //byte[] bytes = Encoding.Default.GetBytes(p.GhiChu);
            //p.GhiChu = Encoding.UTF8.GetString(bytes);
            return p;

        }
    }
}
