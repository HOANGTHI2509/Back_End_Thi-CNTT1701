using System;

class Program
{
    static void Main(string[] args)
    {
        TruongTHPT truong = new TruongTHPT();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY HO SO HOC SINH");
            Console.WriteLine("1. Nhap thong tin cac hoc sinh");
            Console.WriteLine("2. Hien thi hoc sinh nu sinh nam 1985");
            Console.WriteLine("3. Tim kiem hoc sinh theo que quan");
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
                    truong.NhapDanhSachHocSinh();
                    break;
                case 2:
                    truong.HienThiHocSinhNu1985();
                    break;
                case 3:
                    truong.TimKiemTheoQueQuan();
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