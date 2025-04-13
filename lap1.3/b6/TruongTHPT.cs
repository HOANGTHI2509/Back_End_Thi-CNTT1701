using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TruongTHPT
{
    private List<HSHocSinh> danhSachHocSinh;

    public TruongTHPT()
    {
        danhSachHocSinh = new List<HSHocSinh>();
    }

    public void NhapDanhSachHocSinh()
    {
        Console.Write("Nhap so luong hoc sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin hoc sinh thu {i + 1}:");
            HSHocSinh hocSinh = new HSHocSinh();
            hocSinh.NhapThongTin();
            danhSachHocSinh.Add(hocSinh);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiHocSinhNu1985()
    {
        if (danhSachHocSinh.Count == 0)
        {
            Console.WriteLine("Danh sach hoc sinh trong!");
            return;
        }

        bool found = false;
        Console.WriteLine("Danh sach hoc sinh nu sinh nam 1985:");
        foreach (var hocSinh in danhSachHocSinh)
        {
            if (hocSinh.GetGioiTinh().Equals("Nu", StringComparison.OrdinalIgnoreCase) && hocSinh.GetNamSinh() == 1985)
            {
                hocSinh.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong co hoc sinh nu nao sinh nam 1985!");
        }
    }

    public void TimKiemTheoQueQuan()
    {
        Console.Write("Nhap que quan can tim: ");
        string queQuan = Console.ReadLine();
        bool found = false;

        foreach (var hocSinh in danhSachHocSinh)
        {
            if (hocSinh.GetQueQuan().Equals(queQuan, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin hoc sinh co que quan " + queQuan + ":");
                hocSinh.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay hoc sinh co que quan: " + queQuan);
        }
    }
}
