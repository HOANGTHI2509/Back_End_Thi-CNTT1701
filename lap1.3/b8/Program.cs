using System;

class Program
{
    static void Main(string[] args)
    {
        ThuVien thuVien = new ThuVien();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY THU VIEN");
            Console.WriteLine("1. Nhap thong tin cac the muon");
            Console.WriteLine("2. Hien thi sinh vien den han tra sach");
            Console.WriteLine("3. Tim kiem sinh vien theo ma so sinh vien");
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
                    thuVien.NhapDanhSachTheMuon();
                    break;
                case 2:
                    thuVien.HienThiSinhVienDenHanTra();
                    break;
                case 3:
                    thuVien.TimKiemTheoMaSoSV();
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