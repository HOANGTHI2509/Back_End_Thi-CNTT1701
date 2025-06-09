using System;
using System.Collections.Generic;
using System.Linq; // Cần dùng cho các thao tác với danh sách như OrderByDescending, ThenBy

public class Program
{
    public static void Main(string[] args)
    {
        List<HocSinh> danhSachHocSinh = new List<HocSinh>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU QUẢN LÝ HỌC SINH ---");
            Console.WriteLine("1. Nhập danh sách học sinh");
            Console.WriteLine("2. Hiển thị danh sách học sinh đã sắp xếp");
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
                    NhapDanhSachHocSinh(danhSachHocSinh);
                    break;
                case 2:
                    SapXepVaHienThiDanhSach(danhSachHocSinh);
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

    // Phương thức nhập danh sách N học sinh
    public static void NhapDanhSachHocSinh(List<HocSinh> danhSach)
    {
        Console.Write("Nhập số lượng học sinh (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Số lượng không hợp lệ. Vui lòng nhập số nguyên dương: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin học sinh thứ {i + 1} ---");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh;
            while (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh < 1900 || namSinh > DateTime.Now.Year)
            {
                Console.Write($"Năm sinh không hợp lệ. Vui lòng nhập năm sinh (ví dụ: 2005): ");
            }

            Console.Write("Tổng điểm: ");
            double tongDiem;
            while (!double.TryParse(Console.ReadLine(), out tongDiem) || tongDiem < 0)
            {
                Console.Write("Tổng điểm không hợp lệ. Vui lòng nhập số không âm: ");
            }

            danhSach.Add(new HocSinh(hoTen, namSinh, tongDiem));
            Console.WriteLine("Đã thêm học sinh thành công!");
        }
    }

    // Phương thức sắp xếp và hiển thị danh sách học sinh
    public static void SapXepVaHienThiDanhSach(List<HocSinh> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("\nDanh sách học sinh rỗng. Vui lòng nhập dữ liệu trước.");
            return;
        }

        Console.WriteLine("\n--- DANH SÁCH HỌC SINH ĐÃ SẮP XẾP ---");
        Console.WriteLine(new string('-', 70));
        Console.WriteLine($"{"Họ tên",-25} | {"Năm sinh",-8} | {"Tổng điểm",-8}");
        Console.WriteLine(new string('-', 70));

        // Sắp xếp:
        // 1. Giảm dần theo Tổng điểm
        // 2. Nếu Tổng điểm như nhau, thì tăng dần theo Năm sinh (năm sinh nhỏ hơn đứng trước)
        var danhSachSapXep = danhSach
            .OrderByDescending(hs => hs.TongDiem)
            .ThenBy(hs => hs.NamSinh) // Năm sinh nhỏ hơn đứng trước -> tăng dần
            .ToList();

        foreach (var hs in danhSachSapXep)
        {
            hs.InThongTin();
        }
        Console.WriteLine(new string('-', 70));
    }
}