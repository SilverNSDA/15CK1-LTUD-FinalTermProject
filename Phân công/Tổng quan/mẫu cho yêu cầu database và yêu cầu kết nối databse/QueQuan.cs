using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tuan2
{
    class QueQuan
    {
        public int ID { get; set; }
        public string TenDiaPhuong { get; set; }
        static int iID = 0, iTenDiaPhuong = 1;
        public static QueQuan ReadQueQuan(SqlDataReader reader)
        {
            var qq = new QueQuan()
            {
                ID = reader.GetInt32(iID),
                TenDiaPhuong = reader.GetString(iTenDiaPhuong)
            };
            return qq;
        }
    }
}
