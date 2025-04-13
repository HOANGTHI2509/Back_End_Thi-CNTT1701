using System;

class Program
{
    static void Main(string[] args)
    {
        TuyenSinh tuyenSinh = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY TUYEN SINH");
            Console.WriteLine("1. Nhap thong tin moi cho thi sinh");
            Console.WriteLine("2. Hien thi thi sinh trung tuyen");
            Console.WriteLine("3. Tim kiem thi sinh theo so bao danh");
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
                    tuyenSinh.NhapThongTinMoi();
                    break;
                case 2:
                    tuyenSinh.HienThiThiSinhTrungTuyen();
                    break;
                case 3:
                    tuyenSinh.TimKiemTheoSoBaoDanh();
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