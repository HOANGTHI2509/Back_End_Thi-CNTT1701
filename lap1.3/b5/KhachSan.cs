using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhachSan
{
    private List<KhachTro> danhSachKhachTro;

    public KhachSan()
    {
        danhSachKhachTro = new List<KhachTro>();
    }

    public void NhapDanhSachKhachTro()
    {
        Console.Write("Nhap so luong khach tro: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin khach tro thu {i + 1}:");
            KhachTro khachTro = new KhachTro();
            khachTro.NhapThongTin();
            danhSachKhachTro.Add(khachTro);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiDanhSachKhachTro()
    {
        if (danhSachKhachTro.Count == 0)
        {
            Console.WriteLine("Khong co khach tro nao trong khach san!");
            return;
        }

        Console.WriteLine("Danh sach khach tro trong khach san:");
        for (int i = 0; i < danhSachKhachTro.Count; i++)
        {
            Console.WriteLine($"Khach tro thu {i + 1}:");
            danhSachKhachTro[i].HienThiThongTin();
            Console.WriteLine("===================");
        }
    }

    public void TimKiemTheoHoTen()
    {
        Console.Write("Nhap ho ten can tim: ");
        string hoTen = Console.ReadLine();
        bool found = false;

        foreach (var khachTro in danhSachKhachTro)
        {
            if (khachTro.GetHoTen().Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin khach tro co ho ten " + hoTen + ":");
                khachTro.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay khach tro co ho ten: " + hoTen);
        }
    }

    public void TinhTienThanhToan()
    {
        Console.Write("Nhap ho ten khach tro can thanh toan: ");
        string hoTen = Console.ReadLine();
        bool found = false;

        foreach (var khachTro in danhSachKhachTro)
        {
            if (khachTro.GetHoTen().Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                double tienPhong = khachTro.TinhTienPhong();
                Console.WriteLine("Thong tin khach tro:");
                khachTro.HienThiThongTin();
                Console.WriteLine("Tong tien thanh toan: " + tienPhong);
                Console.WriteLine("===================");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay khach tro co ho ten: " + hoTen);
        }
    }
}
