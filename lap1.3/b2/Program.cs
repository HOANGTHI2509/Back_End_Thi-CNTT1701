using System;

class Program
{
    static void Main(string[] args)
    {
        QuanLyTaiLieu quanLy = new QuanLyTaiLieu();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY TAI LIEU");
            Console.WriteLine("1. Nhap thong tin moi cho tai lieu");
            Console.WriteLine("2. Hien thi danh sach tai lieu");
            Console.WriteLine("3. Tim kiem tai lieu theo loai");
            Console.WriteLine("4. Thoat");
            Console.Write("Lua chon: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Vui long nhap so hop le!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    quanLy.NhapThongTinMoi();
                    break;
                case 2:
                    quanLy.HienThiDanhSach();
                    break;
                case 3:
                    quanLy.TimKiemTheoLoai();
                    break;
                case 4:
                    Console.WriteLine("Tam biet!");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}