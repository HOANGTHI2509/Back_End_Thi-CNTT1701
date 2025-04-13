using System;

class Program
{
    static void Main(string[] args)
    {
        QLCB qlcb = new QLCB();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY CAN BO");
            Console.WriteLine("1. Nhap thong tin moi cho can bo");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Hien thi danh sach can bo");
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
                    qlcb.NhapThongTinMoi();
                    break;
                case 2:
                    qlcb.TimKiemTheoHoTen();
                    break;
                case 3:
                    qlcb.HienThiDanhSach();
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