using System;
class Program
{
    static void Main(string[] args)
    {
        KhuPho khuPho = new KhuPho();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY KHU PHO");
            Console.WriteLine("1. Nhap thong tin cac ho dan");
            Console.WriteLine("2. Hien thi thong tin tat ca ho dan");
            Console.WriteLine("3. Tim kiem ho dan theo ho ten");
            Console.WriteLine("4. Tim kiem ho dan theo so nha");
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
                    khuPho.NhapDanhSachHoDan();
                    break;
                case 2:
                    khuPho.HienThiDanhSachHoDan();
                    break;
                case 3:
                    khuPho.TimKiemTheoHoTen();
                    break;
                case 4:
                    khuPho.TimKiemTheoSoNha();
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