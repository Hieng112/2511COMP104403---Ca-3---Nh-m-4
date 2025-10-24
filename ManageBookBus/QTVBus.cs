using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class QTVBus // Lớp Business Logic xử lý nghiệp vụ cho Quản Trị Viên (QTV/Admin)
    {
        public static bool SignInEmployee(QTVDTO emp) // Xác thực đăng nhập cho quản trị viên
        {
            try
            {
                string result = QTVDAO.SignInEmployee(emp);  // Gọi phương thức đăng nhập từ tầng DAO
                if (result != null) return true; // Kiểm tra kết quả đăng nhập
                else return false;
            }
            catch { return false; }
        }
        public static List<QTVDTO> GetListNV()
        {
            return QTVDAO.GetListNV(); // Gọi phương thức lấy danh sách từ tầng DAO
        }
        public static bool updateNV(QTVDTO nvDTO)
        {
            try
            {
                QTVDAO.updateNV(nvDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
}
