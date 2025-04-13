using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QLPTGT
{
    private List<PTGT> danhSachPhuongTien;

    public QLPTGT()
    {
        danhSachPhuongTien = new List<PTGT>();
    }

    public void NhapDangKyPhuongTien()
    {
        Console.WriteLine("Chon loai phuong tien muon dang ky:");
        Console.WriteLine("1. O to");
        Console.WriteLine("2. Xe may");
        Console.WriteLine("3. Xe tai");
        Console.Write("Lua chon: ");
        int choice = int.Parse(Console.ReadLine());

        PTGT phuongTien = null;
        switch (choice)
        {
            case 1:
                phuongTien = new OTo();
                break;
            case 2:
                phuongTien = new XeMay();
                break;
            case 3:
                phuongTien = new XeTai();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        phuongTien.NhapThongTin();
        danhSachPhuongTien.Add(phuongTien);
        Console.WriteLine("Dang ky phuong tien thanh cong!");
    }

    public void TimTheoMau()
    {
        Console.Write("Nhap mau can tim: ");
        string mau = Console.ReadLine();
        bool found = false;

        foreach (var phuongTien in danhSachPhuongTien)
        {
            if (phuongTien.GetMau().Equals(mau, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin phuong tien co mau " + mau + ":");
                phuongTien.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay phuong tien co mau: " + mau);
        }
    }

    public void TimTheoNamSanXuat()
    {
        Console.Write("Nhap nam san xuat can tim: ");
        int namSanXuat = int.Parse(Console.ReadLine());
        bool found = false;

        foreach (var phuongTien in danhSachPhuongTien)
        {
            if (phuongTien.GetNamSanXuat() == namSanXuat)
            {
                Console.WriteLine("Thong tin phuong tien san xuat nam " + namSanXuat + ":");
                phuongTien.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay phuong tien san xuat nam: " + namSanXuat);
        }
    }
}
