using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace LTUD_FinalTermProject
{
    class DataUtil
    {
        static string cnString;
        static SqlConnection cn;
        static DataUtil()
        {
            cnString = "Data Source=DESKTOP-FHDO5A5\\SQLEXPRESS;database=QLKhachSan;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cn = new SqlConnection(cnString);

        }
        static SqlCommand CreateCommand()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            var cm = new SqlCommand();
            cm.Connection = cn;
            return cm;
        }

        public static List<Phong> DSPhong()
        {
            var lp = new List<Phong>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM PHONG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lp.Add(Phong.Read(reader));
            }
            cn.Close();
            return lp;
        }

        public static List<LoaiPhong> DSLoaiPhong()
        {
            var llp = new List<LoaiPhong>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM LOAIPHONG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                llp.Add(LoaiPhong.Read(reader));
            }
            cn.Close();
            return llp;
        }

        public static List<HoaDon> DSHoaDon()
        {
            var lhd = new List<HoaDon>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM HOADON";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lhd.Add(HoaDon.Read(reader));
            }
            cn.Close();
            return lhd;
        }

        public static List<PhieuThue> DSPhieuThue()
        {
            var lpt = new List<PhieuThue>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM PHIEUTHUE";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lpt.Add(PhieuThue.Read(reader));
            }
            cn.Close();
            return lpt;
        }

        public static List<KhachHang> DSKhachHang()
        {
            var lkh = new List<KhachHang>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM KHACHHANG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lkh.Add(KhachHang.Read(reader));
            }
            cn.Close();
            return lkh;
        }

        public static List<LoaiKhachHang> DSLoaiKhachHang()
        {
            var llkh = new List<LoaiKhachHang>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM LOAIKHACHHANG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                llkh.Add(LoaiKhachHang.Read(reader));
            }
            cn.Close();
            return llkh;
        }

        public static List<CT_PhieuThue> DSCT_PhieuThue()
        {
            var lctpt = new List<CT_PhieuThue>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM CT_PHIEUTHUE";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lctpt.Add(CT_PhieuThue.Read(reader));
            }
            cn.Close();
            return lctpt;
        }

        public static List<QuyDinh> DSQuyDinh()
        {
            var lqd = new List<QuyDinh>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM QUYDINH";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lqd.Add(QuyDinh.Read(reader));
            }
            cn.Close();
            return lqd;
        }

        public static List<MD_SuDungPhong> DSMD_SuDungPhong()
        {
            var lmdsdp = new List<MD_SuDungPhong>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM MD_SUDUNGPHONG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lmdsdp.Add(MD_SuDungPhong.Read(reader));
            }
            cn.Close();
            return lmdsdp;
        }

        public static List<DT_TheoLoaiPhong> DSDT_TheoLoaiPhong()
        {
            var ldttlp = new List<DT_TheoLoaiPhong>();
            var cm = CreateCommand();
            cm.CommandText = @"SELECT * FROM DT_THEOLOAIPHONG";
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                ldttlp.Add(DT_TheoLoaiPhong.Read(reader));
            }
            cn.Close();
            return ldttlp;
        }

        // INSERT
        public static bool ThemPhong(Phong p)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_Phong @ID, @LoaiPhong, @GhiChu";
            cm.Parameters.Add(new SqlParameter("@ID", p.ID));
            cm.Parameters.Add(new SqlParameter("@LoaiPhong", p.LoaiPhong));
            cm.Parameters.Add(new SqlParameter("@GhiChu", p.GhiChu));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemLoaiPhong(LoaiPhong lp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_LoaiPhong @ID, @DonGia";
            cm.Parameters.Add(new SqlParameter("@ID", lp.ID));
            cm.Parameters.Add(new SqlParameter("@DonGia", lp.DonGia));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemPhieuThue(PhieuThue pt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_PhieuThue @ID, @MaPhong, @NgayBatDau";
            cm.Parameters.Add(new SqlParameter("@ID", pt.ID));
            cm.Parameters.Add(new SqlParameter("@MaPhong", pt.MaPhong));
            cm.Parameters.Add(new SqlParameter("@NgayBatDau", pt.NgayBatDau));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemKhachHang(KhachHang kh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_KhachHang @ID, @HoTen, @LoaiKhachHang,@CMND,@DiaChi";
            cm.Parameters.Add(new SqlParameter("@ID", kh.ID));
            cm.Parameters.Add(new SqlParameter("@HoTen", kh.HoTen));
            cm.Parameters.Add(new SqlParameter("@LoaiKhachHang", kh.LoaiKhachHang));
            cm.Parameters.Add(new SqlParameter("@CMND", kh.CMND));
            cm.Parameters.Add(new SqlParameter("@DiaChi", kh.DiaChi));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemLoaiKhachHang(LoaiKhachHang lkh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_LoaiKhachHang @ID, @TenLoai";
            cm.Parameters.Add(new SqlParameter("@ID", lkh.ID));
            cm.Parameters.Add(new SqlParameter("@TenLoai", lkh.TenLoai));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemCT_PhieuThue(CT_PhieuThue ctpt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_CT_PhieuThue @ID, @MaPhieuThue, @MaKhachHang";
            cm.Parameters.Add(new SqlParameter("@ID", ctpt.ID));
            cm.Parameters.Add(new SqlParameter("@MaPhieuThue", ctpt.MaPhieuThue));
            cm.Parameters.Add(new SqlParameter("@MaKhachHang", ctpt.MaKhachHang));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemHoaDon(HoaDon hd)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_HoaDon @MaPhieuThue, @MaKhachHang, @NgayThanhToan, @GiaTri";
            cm.Parameters.Add(new SqlParameter("@MaPhieuThue", hd.MaPhieuThue));
            cm.Parameters.Add(new SqlParameter("@MaKhachHang", hd.MaKhachHang));
            cm.Parameters.Add(new SqlParameter("@NgayThanhToan", hd.NgayThanhToan));
            cm.Parameters.Add(new SqlParameter("@GiaTri", hd.GiaTri));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemMD_SuDungPhong(MD_SuDungPhong mdsdp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_MD_SuDungPhong @ID, @MaPhong, @NgayBatDau, @NgayKetThuc, @MatDo";
            cm.Parameters.Add(new SqlParameter("@ID", mdsdp.ID));
            cm.Parameters.Add(new SqlParameter("@MaPhong", mdsdp.MaPhong));
            cm.Parameters.Add(new SqlParameter("@NgayBatDau", mdsdp.NgayBatDau));
            cm.Parameters.Add(new SqlParameter("@NgayKetThuc", mdsdp.NgayKetThuc));
            cm.Parameters.Add(new SqlParameter("@MatDo", mdsdp.MatDo));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool ThemDT_TheoLoaiPhong(DT_TheoLoaiPhong dttlp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec add_row_DT_THEOLOAIPHONG @ID, @MaLoaiPhong, @NgayBatDau, @NgayKetThuc, @DoanhThu";
            cm.Parameters.Add(new SqlParameter("@ID", dttlp.ID));
            cm.Parameters.Add(new SqlParameter("@MaLoaiPhong", dttlp.MaLoaiPhong));
            cm.Parameters.Add(new SqlParameter("@NgayBatDau", dttlp.NgayBatDau));
            cm.Parameters.Add(new SqlParameter("@NgayKetThuc", dttlp.NgayKetThuc));
            cm.Parameters.Add(new SqlParameter("@DoanhThu", dttlp.DoanhThu));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }


        // UPDATE
        public static bool UpdatePhong(Phong p)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_Phong @ID, @LP, @GC";
            cm.Parameters.Add(new SqlParameter("@ID", p.ID));
            cm.Parameters.Add(new SqlParameter("@LP", p.LoaiPhong));
            cm.Parameters.Add(new SqlParameter("@GC", p.GhiChu));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateLoaiPhong(LoaiPhong lp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_LoaiPhong @ID, @DG";
            cm.Parameters.Add(new SqlParameter("@ID", lp.ID));
            cm.Parameters.Add(new SqlParameter("@DG", lp.DonGia));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdatePhieuThue(PhieuThue pt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_PhieuThue @ID, @MP, @NBD";
            cm.Parameters.Add(new SqlParameter("@ID", pt.ID));
            cm.Parameters.Add(new SqlParameter("@MP", pt.MaPhong));
            cm.Parameters.Add(new SqlParameter("@NBD", pt.NgayBatDau));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateKhachHang(KhachHang kh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_KhachHang @ID, @HT, @LKH,@CMND,@DC";
            cm.Parameters.Add(new SqlParameter("@ID", kh.ID));
            cm.Parameters.Add(new SqlParameter("@HT", kh.HoTen));
            cm.Parameters.Add(new SqlParameter("@LKH", kh.LoaiKhachHang));
            cm.Parameters.Add(new SqlParameter("@CMND", kh.CMND));
            cm.Parameters.Add(new SqlParameter("@DC", kh.DiaChi));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateLoaiKhachHang(LoaiKhachHang lkh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_LoaiKhachHang @ID, @TL";
            cm.Parameters.Add(new SqlParameter("@ID", lkh.ID));
            cm.Parameters.Add(new SqlParameter("@TL", lkh.TenLoai));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateCT_PhieuThue(CT_PhieuThue ctpt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_CT_PhieuThue @ID, @MPT, @MKH";
            cm.Parameters.Add(new SqlParameter("@ID", ctpt.ID));
            cm.Parameters.Add(new SqlParameter("@MPT", ctpt.MaPhieuThue));
            cm.Parameters.Add(new SqlParameter("@MKH", ctpt.MaKhachHang));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateHoaDon(HoaDon hd)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_HoaDon @NTT, @MPT, @MKH, @GT";
            cm.Parameters.Add(new SqlParameter("@NTT", hd.NgayThanhToan));
            cm.Parameters.Add(new SqlParameter("@MPT", hd.MaPhieuThue));
            cm.Parameters.Add(new SqlParameter("@MKH", hd.MaKhachHang));
            cm.Parameters.Add(new SqlParameter("@GT", hd.GiaTri));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateQuyDinh(QuyDinh qd)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_QuyDinh @ID, @MT, @GT, @DV";
            cm.Parameters.Add(new SqlParameter("@ID", qd.ID));
            cm.Parameters.Add(new SqlParameter("@MT", qd.MoTa));
            cm.Parameters.Add(new SqlParameter("@GT", qd.GiaTri));
            cm.Parameters.Add(new SqlParameter("@DV", qd.DonVi));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateMD_SuDungPhong(MD_SuDungPhong mdsdp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_MD_SuDungPhong @ID, @MP, @NBD, @NKT, @MD";
            cm.Parameters.Add(new SqlParameter("@ID", mdsdp.ID));
            cm.Parameters.Add(new SqlParameter("@MP", mdsdp.MaPhong));
            cm.Parameters.Add(new SqlParameter("@NBD", mdsdp.NgayBatDau));
            cm.Parameters.Add(new SqlParameter("@NKT", mdsdp.NgayKetThuc));
            cm.Parameters.Add(new SqlParameter("@MD", mdsdp.MatDo));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool UpdateDT_TheoLoaiPhong(DT_TheoLoaiPhong dttlp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_DT_THEOLOAIPHONG @ID, @MLP, @NBD, @NKT, @DT";
            cm.Parameters.Add(new SqlParameter("@ID", dttlp.ID));
            cm.Parameters.Add(new SqlParameter("@MLP", dttlp.MaLoaiPhong));
            cm.Parameters.Add(new SqlParameter("@NBD", dttlp.NgayBatDau));
            cm.Parameters.Add(new SqlParameter("@NKT", dttlp.NgayKetThuc));
            cm.Parameters.Add(new SqlParameter("@DT", dttlp.DoanhThu));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        // DELETE
        public static bool DeletePhong(Phong p)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_Phong @ID, @LP, @GC";
            cm.Parameters.Add(new SqlParameter("@ID", p.ID));
            cm.Parameters.Add(new SqlParameter("@LP", p.LoaiPhong));
            cm.Parameters.Add(new SqlParameter("@GC", p.GhiChu));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteLoaiPhong(LoaiPhong lp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_LoaiPhong @ID";
            cm.Parameters.Add(new SqlParameter("@ID", lp.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeletePhieuThue(PhieuThue pt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_PhieuThue @ID";
            cm.Parameters.Add(new SqlParameter("@ID", pt.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteKhachHang(KhachHang kh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_KhachHang @ID";
            cm.Parameters.Add(new SqlParameter("@ID", kh.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteLoaiKhachHang(LoaiKhachHang lkh)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_LoaiKhachHang @ID";
            cm.Parameters.Add(new SqlParameter("@ID", lkh.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteCT_PhieuThue(CT_PhieuThue ctpt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_CT_PhieuThue @ID";
            cm.Parameters.Add(new SqlParameter("@ID", ctpt.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteHoaDon(HoaDon hd)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_HoaDon @MPT";
            cm.Parameters.Add(new SqlParameter("@MPT", hd.MaPhieuThue));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteMD_SuDungPhong(MD_SuDungPhong mdsdp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec update_row_MD_SuDungPhong @ID";
            cm.Parameters.Add(new SqlParameter("@ID", mdsdp.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool DeleteDT_TheoLoaiPhong(DT_TheoLoaiPhong dttlp)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec delete_row_DT_THEOLOAIPHONG @ID";
            cm.Parameters.Add(new SqlParameter("@ID", dttlp.ID));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        //FUNCTION
        public static bool BaoCaoMatDo(DateTime nbd, DateTime nkt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec BaoCaoMatDo @NBD, @NKT";
            cm.Parameters.Add(new SqlParameter("@NBD", nbd));
            cm.Parameters.Add(new SqlParameter("@NKT", nkt));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }

        public static bool BaoCaoDoanhThu(DateTime nbd, DateTime nkt)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Exec BaoCaoDoanhThu @NBD, @NKT";
            cm.Parameters.Add(new SqlParameter("@NBD", nbd));
            cm.Parameters.Add(new SqlParameter("@NKT", nkt));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs > 0;
        }
    }
}
