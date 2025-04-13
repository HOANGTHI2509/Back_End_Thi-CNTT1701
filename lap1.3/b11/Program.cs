using System;

class Program
{
    static void Main(string[] args)
    {
        SoPhuc A = new SoPhuc();
        SoPhuc B = new SoPhuc();

        Console.WriteLine("Nhap so phuc A:");
        A.NhapSoPhuc();
        Console.WriteLine("Nhap so phuc B:");
        B.NhapSoPhuc();

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH XU LY SO PHUC");
            Console.WriteLine("1. Tinh tong hai so phuc");
            Console.WriteLine("2. Tinh hieu hai so phuc");
            Console.WriteLine("3. Tinh tich hai so phuc");
            Console.WriteLine("4. Tinh thuong hai so phuc");
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
                        Console.Write("Tong hai so phuc: ");
                        SoPhuc tong = A.Cong(B);
                        tong.HienThiSoPhuc();
                        break;
                    case 2:
                        Console.Write("Hieu hai so phuc: ");
                        SoPhuc hieu = A.Tru(B);
                        hieu.HienThiSoPhuc();
                        break;
                    case 3:
                        Console.Write("Tich hai so phuc: ");
                        SoPhuc tich = A.Nhan(B);
                        tich.HienThiSoPhuc();
                        break;
                    case 4:
                        Console.Write("Thuong hai so phuc: ");
                        SoPhuc thuong = A.Chia(B);
                        thuong.HienThiSoPhuc();
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