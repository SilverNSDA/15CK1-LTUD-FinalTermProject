using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTUD_FinalTermProject
{
    class QuyDinh
    {
        public string ID { get; set; }
        public string MoTa { get; set; }
        public float GiaTri { get; set; }
        public string DonVi { get; set; }
        public static int iID = 0, iMoTa = 1, iGiaTri = 2, iDonVi = 3;

        public static QuyDinh Read(SqlDataReader reader)
        {
            var qd = new QuyDinh()
            {
                ID = reader.GetString(iID),
                MoTa = reader.GetString(iMoTa),
                GiaTri = reader.GetFloat(iGiaTri),
                DonVi = reader.GetString(iDonVi)
            };
            byte[] bytes = Encoding.Default.GetBytes(qd.MoTa);
            qd.MoTa = Encoding.UTF8.GetString(bytes);
            return qd;
        }
    }
}
