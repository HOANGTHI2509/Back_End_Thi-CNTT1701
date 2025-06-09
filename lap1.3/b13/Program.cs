using System;

class Program
{
    static void Main(string[] args)
    {
        QLPTGT quanLy = new QLPTGT();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY PHUONG TIEN GIAO THONG");
            Console.WriteLine("1. Nhap dang ky phuong tien");
            Console.WriteLine("2. Tim phuong tien theo mau");
            Console.WriteLine("3. Tim phuong tien theo nam san xuat");
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
                    quanLy.NhapDangKyPhuongTien();
                    break;
                case 2:
                    quanLy.TimTheoMau();
                    break;
                case 3:
                    quanLy.TimTheoNamSanXuat();
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