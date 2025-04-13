using System;

class Program
{
    static void Main(string[] args)
    {
        MaTran A = new MaTran();
        MaTran B = new MaTran();

        Console.WriteLine("Nhap ma tran A:");
        A.NhapMaTran();
        Console.WriteLine("Nhap ma tran B:");
        B.NhapMaTran();

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH XU LY MA TRAN");
            Console.WriteLine("1. Tinh tong hai ma tran");
            Console.WriteLine("2. Tinh hieu hai ma tran");
            Console.WriteLine("3. Tinh tich hai ma tran");
            Console.WriteLine("4. Tinh thuong hai ma tran");
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
                        Console.WriteLine("Tong hai ma tran:");
                        MaTran tong = A.Cong(B);
                        tong.HienThiMaTran();
                        break;
                    case 2:
                        Console.WriteLine("Hieu hai ma tran:");
                        MaTran hieu = A.Tru(B);
                        hieu.HienThiMaTran();
                        break;
                    case 3:
                        Console.WriteLine("Tich hai ma tran:");
                        MaTran tich = A.Nhan(B);
                        tich.HienThiMaTran();
                        break;
                    case 4:
                        Console.WriteLine("Thuong hai ma tran:");
                        MaTran thuong = A.Chia(B);
                        thuong.HienThiMaTran();
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