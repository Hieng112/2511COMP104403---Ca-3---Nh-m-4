using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class KhachHangBus // Lớp Business Logic xử lý nghiệp vụ cho Khách Hàng
    {
        private KhachHangDAO khachHangDAO = new KhachHangDAO();  // Khởi tạo đối tượng DAO để sử dụng cho các phương thức non-static

        public static bool AddCustomer(KhachHangDTO cus)
        {
            try      // Gọi phương thức thêm khách hàng từ tầng DAO
            {
                KhachHangDAO.AddCustomer(cus);
                return true;
            }
            catch { return false; }
        }

        public KhachHangDTO GetThongTinKhachHang(string MaKH)
        {
            return khachHangDAO.GetThongTinKhachHang(MaKH);
        }
        public static bool SignInCustomer(KhachHangDTO cus)
        {
            try
            {
                string result = KhachHangDAO.SignIn(cus);
                if(result != null) return true;
                else return false;
            }
            catch { return false; }
        }
        public static List<KhachHangDTO> GetListKH()
        {
            return KhachHangDAO.GetListKH();
        }

        public static bool suaKH(KhachHangDTO KHDTO)
        {
            try
            {
                KhachHangDAO.suaKH(KHDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }
        public static bool xoaKH(KhachHangDTO KHDTO)
        {
            try
            {
                KhachHangDAO.xoaKH(KHDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }
// Tìm kiếm khách hàng theo tên
        public static List<KhachHangDTO> TimKiemKHTheoTen(string tenKH)
        {
            return KhachHangDAO.TimKiemKHTheoTen(tenKH);   // Gọi phương thức tìm kiếm từ tầng DAO

        }

    }
}
