using ManageBookDTO;
using ManageStuDAO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class NhanVienBus // Lớp Business Logic xử lý nghiệp vụ cho Nhân Viên
    {
        private static NhanVienDAO nhanVienDAO = new NhanVienDAO(); // Khởi tạo đối tượng DAO static để sử dụng chung


        public static bool AddEmployee(NhanVienDTO nv) // Thay AddCustomer bằng AddEmployee, KhachHangDTO bằng NhanVienDTO
        {
            try
            {
                NhanVienDAO.AddEmployee(nv); // Thay KhachHangDAO.AddCustomer bằng NhanVienDAO.AddEmployee
                return true;
            }
            catch { return false; }
        }
        public static bool UpdateEmployee(NhanVienDTO nv) { /* Logic sửa */ return true; }
        public static bool xoaNV(NhanVienDTO nvDTO)
        {
            try
            {
                NhanVienDAO.DeleteEmployee(nvDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SignInEmployee(NhanVienDTO emp)
        {
            try
            {
                string result = NhanVienDAO.SignInEmployee(emp);
                if (result != null) return true;
                else return false;
            }
            catch { return false; }
        }
        public static List<NhanVienDTO> GetListNV()
        {
            return NhanVienDAO.GetListNV();
        }
        public static bool updateNV(NhanVienDTO nvDTO)
        {
            try
            {
                NhanVienDAO.updateNV(nvDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static int CapNhatNhanVien(NhanVienDTO nv)
        {
            if (nv == null || string.IsNullOrEmpty(nv.MaNV))
                throw new ArgumentException("Mã Nhân Viên không hợp lệ!"); // Kiểm tra đối tượng null và mã nhân viên
            if (string.IsNullOrEmpty(nv.TenNV))
                throw new ArgumentException("Tên Nhân Viên không được để trống!"); //Kiểm tra tên nhân viên không được để trống
            if (!string.IsNullOrEmpty(nv.SDT) && nv.SDT.Length < 10)
                throw new ArgumentException("Số điện thoại phải có ít nhất 10 chữ số!"); //Kiểm tra số điện thoại phải có ít nhất 10 chữ số

            return NhanVienDAO.SuaNV(nv); // Sau khi thành công, gọi DAO để cập nhật
        }
// Lấy danh sách nhân viên dưới dạng DataTable (dùng cho hiển thị lưới dữ liệu)
        public DataTable LoadDanhSachNhanVien()
        {
            return nhanVienDAO.LayDanhSachNhanVien(); // Gọi phương thức từ đối tượng DAO instance
        }
    }
}
