using System;

class Program
{
    static void Main(string[] args)
    {
        VanBan vanBan = new VanBan();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH XU LY VAN BAN");
            Console.WriteLine("1. Nhap xau ky tu");
            Console.WriteLine("2. Dem so tu");
            Console.WriteLine("3. Dem so ky tu H");
            Console.WriteLine("4. Chuan hoa xau");
            Console.WriteLine("5. Hien thi xau");
            Console.WriteLine("6. Thoat");
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
                    vanBan.NhapXau();
                    break;
                case 2:
                    Console.WriteLine("So tu trong xau: " + vanBan.DemSoTu());
                    break;
                case 3:
                    Console.WriteLine("So ky tu H trong xau: " + vanBan.DemKyTuH());
                    break;
                case 4:
                    vanBan.ChuanHoa();
                    Console.WriteLine("Xau sau khi chuan hoa:");
                    vanBan.HienThiXau();
                    break;
                case 5:
                    vanBan.HienThiXau();
                    break;
                case 6:
                    Console.WriteLine("Tam biet!");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }
}