using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;

namespace ManageBookBus
{
    public class LichSuMuaHangBus // Lớp Business Logic xử lý nghiệp vụ cho Lịch Sử Mua Hàng
    {
        private LichSuMuaHangDAO dao = new LichSuMuaHangDAO(); // Khởi tạo đối tượng DAO để truy xuất dữ liệu
// Lấy lịch sử mua hàng của một khách hàng cụ thể
        public List<LichSuMuaHangDTO> GetLichSuMuaHang(string maKH)
        {
            return dao.GetLichSuMuaHang(maKH); // Gọi phương thức từ tầng DAO để lấy lịch sử mua hàng theo mã khách hàng
        }

        public float TinhTongTien(List<LichSuMuaHangDTO> lichSuList)
        {
            float tongTien = 0;
            foreach (var lichSu in lichSuList) // Duyệt qua từng đơn hàng trong danh sách
            {
                tongTien += lichSu.ThanhTien;
            }
            return tongTien;
        }
    }
}
