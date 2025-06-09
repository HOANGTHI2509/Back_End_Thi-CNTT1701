using System;
using System.Collections.Generic;
using System.Linq; // Để sử dụng LINQ

public class Program
{
    public static void Main(string[] args)
    {
        List<HoiVienCoBan> danhSachHoiVien = new List<HoiVienCoBan>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU QUẢN LÝ HỘI VIÊN ---");
            Console.WriteLine("1. Nhập thông tin N hội viên");
            Console.WriteLine("2. Hiển thị tất cả hội viên");
            Console.WriteLine("3. Tìm kiếm hội viên có ngày cưới 11/11/2011");
            Console.WriteLine("4. Hiển thị hội viên có người yêu nhưng chưa kết hôn");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập một số.");
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    NhapDanhSachHoiVien(danhSachHoiVien);
                    break;
                case 2:
                    HienThiTatCaHoiVien(danhSachHoiVien);
                    break;
                case 3:
                    TimHoiVienTheoNgayCuoi(danhSachHoiVien, new DateTime(2011, 11, 11));
                    break;
                case 4:
                    HienThiHoiVienCoNguoiYeuChuaCuoi(danhSachHoiVien);
                    break;
                case 0:
                    Console.WriteLine("Đang thoát chương trình. Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không tồn tại. Vui lòng thử lại.");
                    break;
            }
        } while (luaChon != 0);
    }

    // Phương thức nhập thông tin N hội viên
    public static void NhapDanhSachHoiVien(List<HoiVienCoBan> danhSach)
    {
        Console.Write("Nhập số lượng hội viên muốn thêm: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Số lượng không hợp lệ. Vui lòng nhập số nguyên dương: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin hội viên thứ {i + 1} ---");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();

            Console.Write("Bạn đã kết hôn? (Y/N): ");
            bool daKetHon = Console.ReadLine().ToUpper() == "Y";

            if (daKetHon)
            {
                Console.Write("Họ tên người yêu (vợ/chồng): ");
                string hoTenNY_VC = Console.ReadLine(); // Đối với người kết hôn, tên người yêu cũng là tên vợ/chồng

                Console.Write("Số điện thoại người yêu: ");
                string sdtNY = Console.ReadLine();

                Console.Write("Họ tên vợ/chồng: ");
                string hoTenVC = Console.ReadLine();

                Console.Write("Ngày cưới (dd/MM/yyyy): ");
                DateTime ngayCuoi;
                while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayCuoi))
                {
                    Console.Write("Ngày cưới không hợp lệ. Vui lòng nhập lại (dd/MM/yyyy): ");
                }
                danhSach.Add(new HoiVienDaKetHon(hoTen, diaChi, hoTenNY_VC, sdtNY, hoTenVC, ngayCuoi));
            }
            else
            {
                Console.Write("Bạn đã có người yêu? (Y/N): ");
                bool coNguoiYeu = Console.ReadLine().ToUpper() == "Y";
                if (coNguoiYeu)
                {
                    Console.Write("Họ tên người yêu: ");
                    string hoTenNY = Console.ReadLine();
                    Console.Write("Số điện thoại người yêu: ");
                    string sdtNY = Console.ReadLine();
                    danhSach.Add(new HoiVienCoNguoiYeu(hoTen, diaChi, hoTenNY, sdtNY));
                }
                else
                {
                    danhSach.Add(new HoiVienCoBan(hoTen, diaChi));
                }
            }
            Console.WriteLine("Đã thêm hội viên thành công!");
        }
    }

    // Phương thức hiển thị tất cả hội viên
    public static void HienThiTatCaHoiVien(List<HoiVienCoBan> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("\nDanh sách hội viên rỗng.");
            return;
        }

        Console.WriteLine("\n--- DANH SÁCH TẤT CẢ HỘI VIÊN ---");
        int count = 1;
        foreach (var hv in danhSach)
        {
            Console.WriteLine($"\n----- Hội viên số {count} -----");
            hv.InThongTin(); // Tự động gọi phương thức InThongTin phù hợp với kiểu đối tượng
            count++;
        }
    }

    // Phương thức tìm kiếm hội viên theo ngày cưới
    public static void TimHoiVienTheoNgayCuoi(List<HoiVienCoBan> danhSach, DateTime ngayCuoiCanTim)
    {
        Console.WriteLine($"\n--- HỘI VIÊN CÓ NGÀY CƯỚI {ngayCuoiCanTim:dd/MM/yyyy} ---");
        bool timThay = false;

        // Duyệt qua danh sách, chỉ lấy những đối tượng thuộc kiểu HoiVienDaKetHon
        foreach (var hv in danhSach.OfType<HoiVienDaKetHon>())
        {
            if (hv.NgayCuoi.Date == ngayCuoiCanTim.Date) // So sánh chỉ phần ngày tháng năm
            {
                hv.InThongTin();
                Console.WriteLine("--------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine($"Không tìm thấy hội viên nào có ngày cưới là {ngayCuoiCanTim:dd/MM/yyyy}.");
        }
    }

    // Phương thức hiển thị những người đã có người yêu nhưng chưa lập gia đình
    public static void HienThiHoiVienCoNguoiYeuChuaCuoi(List<HoiVienCoBan> danhSach)
    {
        Console.WriteLine("\n--- HỘI VIÊN CÓ NGƯỜI YÊU NHƯNG CHƯA KẾT HÔN ---");
        bool timThay = false;

        // Duyệt qua danh sách, chỉ lấy những đối tượng là HoiVienCoNguoiYeu
        // VÀ KHÔNG phải là HoiVienDaKetHon (vì HoiVienDaKetHon cũng là HoiVienCoNguoiYeu)
        foreach (var hv in danhSach)
        {
            if (hv is HoiVienCoNguoiYeu && !(hv is HoiVienDaKetHon))
            {
                hv.InThongTin();
                Console.WriteLine("--------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy hội viên nào có người yêu nhưng chưa kết hôn.");
        }
    }
}