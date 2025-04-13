using System;

class Program
{
    static void Main(string[] args)
    {
        QuanLyBienLai quanLy = new QuanLyBienLai();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY BIEN LAI TIEN DIEN");
            Console.WriteLine("1. Nhap thong tin cac bien lai");
            Console.WriteLine("2. Hien thi thong tin tat ca bien lai");
            Console.WriteLine("3. Thoat");
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
                    quanLy.NhapDanhSachBienLai();
                    break;
                case 2:
                    quanLy.HienThiDanhSachBienLai();
                    break;
                case 3:
                    Console.WriteLine("Tam biet!");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}