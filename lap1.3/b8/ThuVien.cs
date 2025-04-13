using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThuVien
{
    private List<TheMuon> danhSachTheMuon;

    public ThuVien()
    {
        danhSachTheMuon = new List<TheMuon>();
    }

    public void NhapDanhSachTheMuon()
    {
        Console.Write("Nhap so luong the muon: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin the muon thu {i + 1}:");
            TheMuon theMuon = new TheMuon();
            theMuon.NhapThongTin();
            danhSachTheMuon.Add(theMuon);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiSinhVienDenHanTra()
    {
        if (danhSachTheMuon.Count == 0)
        {
            Console.WriteLine("Danh sach the muon trong!");
            return;
        }

        DateTime ngayHienTai = DateTime.Now;
        bool found = false;
        Console.WriteLine("Danh sach sinh vien den han tra sach (tinh den ngay " + ngayHienTai.ToString("dd/MM/yyyy") + "):");
        foreach (var theMuon in danhSachTheMuon)
        {
            if (theMuon.GetHanTra() <= ngayHienTai)
            {
                theMuon.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong co sinh vien nao den han tra sach!");
        }
    }

    public void TimKiemTheoMaSoSV()
    {
        Console.Write("Nhap ma so sinh vien can tim: ");
        string maSoSV = Console.ReadLine();
        bool found = false;

        foreach (var theMuon in danhSachTheMuon)
        {
            if (theMuon.GetMaSoSV().Equals(maSoSV, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thong tin the muon cua sinh vien co ma so " + maSoSV + ":");
                theMuon.HienThiThongTin();
                Console.WriteLine("===================");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay sinh vien co ma so: " + maSoSV);
        }
    }
}
