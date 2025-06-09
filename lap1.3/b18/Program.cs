using System;
using System.Collections.Generic;
using System.Linq; // Cần thiết để sử dụng LINQ cho tìm kiếm/lọc

public class Program
{
    public static void Main(string[] args)
    {
        List<CoQuan> danhSachCoQuan = new List<CoQuan>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU QUẢN LÝ CÁ NHÂN TRONG CƠ QUAN ---");
            Console.WriteLine("1. Nhập thông tin cá nhân mới");
            Console.WriteLine("2. Hiển thị thông tin cá nhân thuộc 'Phòng tài chính'");
            Console.WriteLine("3. Tìm kiếm thông tin cá nhân theo họ tên");
            Console.WriteLine("0. Thoát khỏi chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            // Đảm bảo người dùng nhập số hợp lệ
            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập một số.");
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    NhapThongTinCaNhan(danhSachCoQuan);
                    break;
                case 2:
                    HienThiPhongTaiChinh(danhSachCoQuan);
                    break;
                case 3:
                    TimKiemTheoHoTen(danhSachCoQuan);
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

    // Phương thức nhập thông tin cá nhân mới
    public static void NhapThongTinCaNhan(List<CoQuan> danhSachCoQuan)
    {
        Console.WriteLine("\n--- NHẬP THÔNG TIN CÁ NHÂN MỚI ---");

        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();

        Console.Write("Nhập giới tính (Nam/Nu): ");
        bool gioiTinh = Console.ReadLine().ToLower() == "nam"; // Chuyển về chữ thường để so sánh

        Console.Write("Nhập tuổi: ");
        int tuoi;
        while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi < 0)
        {
            Console.Write("Tuổi không hợp lệ. Vui lòng nhập số nguyên dương: ");
        }

        Console.Write("Nhập đơn vị công tác (ví dụ: Phòng tài chính, Bộ môn CNTT): ");
        string donViCongTac = Console.ReadLine();

        Console.Write("Nhập hệ số lương: ");
        double heSoLuong;
        while (!double.TryParse(Console.ReadLine(), out heSoLuong) || heSoLuong < 0)
        {
            Console.Write("Hệ số lương không hợp lệ. Vui lòng nhập số dương: ");
        }

        CoQuan caNhanMoi = new CoQuan(hoTen, gioiTinh, tuoi, donViCongTac, heSoLuong);
        danhSachCoQuan.Add(caNhanMoi);
        Console.WriteLine("Đã thêm cá nhân thành công!");
    }

    // Phương thức hiển thị thông tin cho cá nhân có đơn vị là Phòng tài chính
    public static void HienThiPhongTaiChinh(List<CoQuan> danhSachCoQuan)
    {
        Console.WriteLine("\n--- THÔNG TIN CÁ NHÂN THUỘC 'PHÒNG TÀI CHÍNH' ---");
        bool timThay = false;
        foreach (CoQuan caNhan in danhSachCoQuan)
        {
            if (caNhan.DonViCongTac.Equals("Phòng tài chính", StringComparison.OrdinalIgnoreCase))
            {
                caNhan.InThongTin();
                Console.WriteLine("--------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy cá nhân nào thuộc 'Phòng tài chính'.");
        }
    }

    // Phương thức tìm kiếm thông tin theo họ tên
    public static void TimKiemTheoHoTen(List<CoQuan> danhSachCoQuan)
    {
        Console.WriteLine("\n--- TÌM KIẾM THÔNG TIN THEO HỌ TÊN ---");
        Console.Write("Nhập họ tên cần tìm: ");
        string tenCanTim = Console.ReadLine();

        List<CoQuan> ketQuaTimKiem = danhSachCoQuan
            .Where(cn => cn.HoTen.IndexOf(tenCanTim, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

        if (ketQuaTimKiem.Any()) // Kiểm tra nếu có kết quả
        {
            Console.WriteLine($"Tìm thấy {ketQuaTimKiem.Count} cá nhân với tên '{tenCanTim}':");
            foreach (CoQuan caNhan in ketQuaTimKiem)
            {
                caNhan.InThongTin();
                Console.WriteLine("--------------------");
            }
        }
        else
        {
            Console.WriteLine($"Không tìm thấy cá nhân nào có họ tên chứa '{tenCanTim}'.");
        }
    }
}