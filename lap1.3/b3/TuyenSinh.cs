using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TuyenSinh
{
    private List<ThiSinh> danhSachThiSinh;

    public TuyenSinh()
    {
        danhSachThiSinh = new List<ThiSinh>();
    }

    public void NhapThongTinMoi()
    {
        Console.WriteLine("Chon khoi thi cua thi sinh:");
        Console.WriteLine("1. Khoi A");
        Console.WriteLine("2. Khoi B");
        Console.WriteLine("3. Khoi C");
        Console.Write("Lua chon: ");
        int choice = int.Parse(Console.ReadLine());

        ThiSinh thiSinh = null;
        switch (choice)
        {
            case 1:
                thiSinh = new ThiSinhKhoiA();
                break;
            case 2:
                thiSinh = new ThiSinhKhoiB();
                break;
            case 3:
                thiSinh = new ThiSinhKhoiC();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        thiSinh.NhapThongTin();
        danhSachThiSinh.Add(thiSinh);
        Console.WriteLine("Them thi sinh thanh cong!");
    }

    public void HienThiThiSinhTrungTuyen()
    {
        if (danhSachThiSinh.Count == 0)
        {
            Console.WriteLine("Danh sach thi sinh trong!");
            return;
        }

        Console.WriteLine("Danh sach thi sinh trung tuyen:");
        bool found = false;
        foreach (var thiSinh in danhSachThiSinh)
        {
            double tongDiem = thiSinh.TinhTongDiem();
            bool trungTuyen = false;

            if (thiSinh is ThiSinhKhoiA && tongDiem >= 15)
                trungTuyen = true;
            else if (thiSinh is ThiSinhKhoiB && tongDiem >= 16)
                trungTuyen = true;
            else if (thiSinh is ThiSinhKhoiC && tongDiem >= 13.5)
                trungTuyen = true;

            if (trungTuyen)
            {
                thiSinh.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong co thi sinh nao trung tuyen!");
        }
    }

    public void TimKiemTheoSoBaoDanh()
    {
        Console.Write("Nhap so bao danh can tim: ");
        string soBaoDanh = Console.ReadLine();
        bool found = false;

        foreach (var thiSinh in danhSachThiSinh)
        {
            if (thiSinh.GetSoBaoDanh().Equals(soBaoDanh, StringComparison.OrdinalIgnoreCase))
            {
                thiSinh.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay thi sinh voi so bao danh: " + soBaoDanh);
        }
    }
}
