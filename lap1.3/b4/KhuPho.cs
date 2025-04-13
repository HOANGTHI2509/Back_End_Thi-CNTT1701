using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhuPho
{
    private List<HoDan> danhSachHoDan;

    public KhuPho()
    {
        danhSachHoDan = new List<HoDan>();
    }

    public void NhapDanhSachHoDan()
    {
        Console.Write("Nhap so luong ho dan: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin ho dan thu {i + 1}:");
            HoDan hoDan = new HoDan();
            hoDan.NhapThongTin();
            danhSachHoDan.Add(hoDan);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiDanhSachHoDan()
    {
        if (danhSachHoDan.Count == 0)
        {
            Console.WriteLine("Danh sach ho dan trong!");
            return;
        }

        Console.WriteLine("Danh sach tat ca ho dan trong khu pho:");
        for (int i = 0; i < danhSachHoDan.Count; i++)
        {
            Console.WriteLine($"Ho dan thu {i + 1}:");
            danhSachHoDan[i].HienThiThongTin();
            Console.WriteLine("===================");
        }
    }

    public void TimKiemTheoHoTen()
    {
        Console.Write("Nhap ho ten can tim: ");
        string hoTen = Console.ReadLine();
        bool found = false;

        foreach (var hoDan in danhSachHoDan)
        {
            foreach (var nguoi in hoDan.GetDanhSachThanhVien())
            {
                if (nguoi.GetHoTen().Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thong tin ho dan chua nguoi co ho ten " + hoTen + ":");
                    hoDan.HienThiThongTin();
                    Console.WriteLine("===================");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay nguoi co ho ten: " + hoTen);
        }
    }

    public void TimKiemTheoSoNha()
    {
        Console.Write("Nhap so nha can tim: ");
        string soNha = Console.ReadLine();
        bool found = false;

        foreach (var hoDan in danhSachHoDan)
        {
            if (hoDan.GetSoNha().Equals(soNha, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin ho dan co so nha " + soNha + ":");
                hoDan.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay ho dan co so nha: " + soNha);
        }
    }
}
