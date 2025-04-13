using System;

class Program
{
    static void Main(string[] args)
    {
        PhanSo A = new PhanSo();
        PhanSo B = new PhanSo();

        try
        {
            Console.WriteLine("Nhap phan so A:");
            A.NhapPhanSo();
            Console.WriteLine("Nhap phan so B:");
            B.NhapPhanSo();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
            return;
        }

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH XU LY PHAN SO");
            Console.WriteLine("1. Tinh tong hai phan so");
            Console.WriteLine("2. Tinh hieu hai phan so");
            Console.WriteLine("3. Tinh tich hai phan so");
            Console.WriteLine("4. Tinh thuong hai phan so");
            Console.WriteLine("5. Thoat");
            Console.Write("Lua chon: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Vui long nhap so hop le!");
                continue;
            }

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Tong hai phan so: ");
                        PhanSo tong = A.Cong(B);
                        tong.HienThiPhanSo();
                        break;
                    case 2:
                        Console.Write("Hieu hai phan so: ");
                        PhanSo hieu = A.Tru(B);
                        hieu.HienThiPhanSo();
                        break;
                    case 3:
                        Console.Write("Tich hai phan so: ");
                        PhanSo tich = A.Nhan(B);
                        tich.HienThiPhanSo();
                        break;
                    case 4:
                        Console.Write("Thuong hai phan so: ");
                        PhanSo thuong = A.Chia(B);
                        thuong.HienThiPhanSo();
                        break;
                    case 5:
                        Console.WriteLine("Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}