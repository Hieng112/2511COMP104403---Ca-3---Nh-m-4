using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    // Lớp Business Logic xử lý nghiệp vụ cho Dịch Vụ
    public class DichVuBus
    {
        public static List<DichVuDTO> GetListDV() // Lấy danh sách tất cả các dịch vụ từ database
        {
            return DichVuDAO.GetListDV(); // Gọi phương thức từ tầng DAO để lấy dữ liệu
        }
        public static bool themDV(DichVuDTO dvDTO)
        {
            try
            {
                DichVuDAO.themDV(dvDTO); // Thêm một dịch vụ mới vào database

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool suaDV(DichVuDTO dvDTO) // Cập nhật thông tin của một dịch vụ đã có trong database
        {
            try
            {
                DichVuDAO.suaDV(dvDTO);

                return true; // Trả về thành công
            }
            catch // Bắt lỗi nếu có exception xảy ra
            {
                return false; // Trả về thất bại
            }
        }

        public static bool xoaDV(DichVuDTO dvDTO) // Xóa một dịch vụ khỏi database
        {
            try
            {
                DichVuDAO.xoaDV(dvDTO); // Gọi phương thức xóa dịch vụ từ tầng DAO

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
