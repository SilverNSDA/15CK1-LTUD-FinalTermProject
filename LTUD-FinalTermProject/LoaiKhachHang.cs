using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class LoaiKhachHang
    {
        public string ID { get; set; }
        public string TenLoai { get; set; }
        public static int iID = 0, iTenLoai = 1;

        public static LoaiKhachHang Read(SqlDataReader reader)
        {
            var lkh = new LoaiKhachHang()
            {
                ID = reader.GetString(iID),
                TenLoai = reader.GetString(iTenLoai)
            };
            //byte[] bytes = Encoding.Default.GetBytes(lkh.TenLoai);
            //lkh.TenLoai = Encoding.UTF8.GetString(bytes);
            return lkh;
        }
    }
}
