using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class KhachHang
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string LoaiKhachHang { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public static int iID = 0, iHoTen = 1, iLoaKhachHang = 2, iCMND = 3, iDiaChi = 4;

        public static KhachHang Read(SqlDataReader reader)
        {
            var kh = new KhachHang()
            {
                ID = reader.GetString(iID),
                HoTen = reader.GetString(iHoTen),
                LoaiKhachHang = reader.GetString(iLoaKhachHang),
                CMND = reader.GetString(iCMND),
                DiaChi = reader.GetString(iDiaChi)
            };
            //var bytes = Encoding.Default.GetBytes(kh.HoTen);
            //kh.HoTen = Encoding.UTF8.GetString(bytes);
            //bytes = Encoding.Default.GetBytes(kh.DiaChi);
            //kh.DiaChi = Encoding.UTF8.GetString(bytes);
            return kh;
        }
    }
}
