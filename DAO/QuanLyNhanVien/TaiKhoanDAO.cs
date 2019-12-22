using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace DAO.QuanLyNhanVien
{
    public static class TaiKhoanDAO
    {
        // Tạo tài khoản mới
        public static bool TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            try
            {
                karaokeDataContext.TAIKHOANs.InsertOnSubmit(new TAIKHOAN()
                {
                    TENTK = taiKhoan.TenTaiKhoan,
                    MATKHAU = MaHoaMatKhau.maHoa(taiKhoan.MatKhau)
                });
                ChangeSet cs = karaokeDataContext.GetChangeSet();
                if (cs.Inserts.Count() == 1)
                {
                    karaokeDataContext.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return false;
        }

        // Kiểm tra tài khoản
        public static bool KiemTraTaiKhoan(string tenTaiKhoan)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            try
            {
                return karaokeDataContext.TAIKHOANs.Select(tk => tk).Count() > 0;
            }
            catch (Exception ex)
            {
                Utility.Log(ex.Message);
            }
            return false;
        }


        // Xóa tài khoản
        public static bool XoaTaiKhoan(string tentk)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            try
            {
                karaokeDataContext.TAIKHOANs.DeleteOnSubmit(new TAIKHOAN()
                {
                    TENTK = tentk
                });
                ChangeSet cs = karaokeDataContext.GetChangeSet();
                if (cs.Deletes.Count() == 1)
                {
                    karaokeDataContext.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return false;
        }

        public static bool CapNhatTaiKhoan(TaiKhoan taiKhoan)
        {
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    karaokeDataContext.TAIKHOANs.FirstOrDefault(tk => tk.TENTK == taiKhoan.TenTaiKhoan).MATKHAU = MaHoaMatKhau.maHoa(taiKhoan.MatKhau);
                    ChangeSet cs = karaokeDataContext.GetChangeSet();
                    if (cs.Updates.Count() == 1)
                    {
                        karaokeDataContext.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }
    }
}
