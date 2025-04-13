using System;

class Program
{
    static void Main(string[] args)
    {
        KhachSan khachSan = new KhachSan();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY KHACH SAN");
            Console.WriteLine("1. Nhap thong tin cac khach tro");
            Console.WriteLine("2. Hien thi thong tin tat ca khach tro");
            Console.WriteLine("3. Tim kiem khach tro theo ho ten");
            Console.WriteLine("4. Tinh tien thanh toan cho khach tro");
            Console.WriteLine("5. Thoat");
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
                    khachSan.NhapDanhSachKhachTro();
                    break;
                case 2:
                    khachSan.HienThiDanhSachKhachTro();
                    break;
                case 3:
                    khachSan.TimKiemTheoHoTen();
                    break;
                case 4:
                    khachSan.TinhTienThanhToan();
                    break;
                case 5:
                    Console.WriteLine("Tam biet!");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}