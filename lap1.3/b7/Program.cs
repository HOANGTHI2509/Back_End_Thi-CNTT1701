using System;

class Program
{
    static void Main(string[] args)
    {
        KhoaCNTT khoa = new KhoaCNTT();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY KHOA CNTT");
            Console.WriteLine("1. Nhap thong tin cac can bo giao vien");
            Console.WriteLine("2. Hien thi can bo giao vien co luong thuc linh tren 5 trieu");
            Console.WriteLine("3. Tim kiem can bo giao vien theo que quan");
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
                    khoa.NhapDanhSachCBGV();
                    break;
                case 2:
                    khoa.HienThiCBGVLuongTren5Trieu();
                    break;
                case 3:
                    khoa.TimKiemTheoQueQuan();
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