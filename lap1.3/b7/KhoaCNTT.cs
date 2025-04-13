using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhoaCNTT
{
    private List<CBGV> danhSachCBGV;

    public KhoaCNTT()
    {
        danhSachCBGV = new List<CBGV>();
    }

    public void NhapDanhSachCBGV()
    {
        Console.Write("Nhap so luong can bo giao vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin can bo giao vien thu {i + 1}:");
            CBGV cbgv = new CBGV();
            cbgv.NhapThongTin();
            danhSachCBGV.Add(cbgv);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiCBGVLuongTren5Trieu()
    {
        if (danhSachCBGV.Count == 0)
        {
            Console.WriteLine("Danh sach can bo giao vien trong!");
            return;
        }

        bool found = false;
        Console.WriteLine("Danh sach can bo giao vien co luong thuc linh tren 5 trieu:");
        foreach (var cbgv in danhSachCBGV)
        {
            if (cbgv.GetLuongThucLinh() > 5000000)
            {
                cbgv.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong co can bo giao vien nao co luong thuc linh tren 5 trieu!");
        }
    }

    public void TimKiemTheoQueQuan()
    {
        Console.Write("Nhap que quan can tim: ");
        string queQuan = Console.ReadLine();
        bool found = false;

        foreach (var cbgv in danhSachCBGV)
        {
            if (cbgv.GetQueQuan().Equals(queQuan, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin can bo giao vien co que quan " + queQuan + ":");
                cbgv.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay can bo giao vien co que quan: " + queQuan);
        }
    }
}
