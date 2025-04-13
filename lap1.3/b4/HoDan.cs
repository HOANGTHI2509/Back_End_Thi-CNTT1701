using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HoDan
{
    private int soThanhVien;
    private string soNha;
    private List<Nguoi> danhSachThanhVien;

    public HoDan()
    {
        danhSachThanhVien = new List<Nguoi>();
    }

    public HoDan(int soThanhVien, string soNha, List<Nguoi> danhSachThanhVien)
    {
        this.soThanhVien = soThanhVien;
        this.soNha = soNha;
        this.danhSachThanhVien = danhSachThanhVien;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap so nha: ");
        soNha = Console.ReadLine();
        Console.Write("Nhap so thanh vien trong ho: ");
        soThanhVien = int.Parse(Console.ReadLine());

        danhSachThanhVien.Clear();
        for (int i = 0; i < soThanhVien; i++)
        {
            Console.WriteLine($"Nhap thong tin thanh vien thu {i + 1}:");
            Nguoi nguoi = new Nguoi();
            nguoi.NhapThongTin();
            danhSachThanhVien.Add(nguoi);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("So nha: " + soNha);
        Console.WriteLine("So thanh vien: " + soThanhVien);
        Console.WriteLine("Danh sach thanh vien:");
        for (int i = 0; i < danhSachThanhVien.Count; i++)
        {
            Console.WriteLine($"Thanh vien thu {i + 1}:");
            danhSachThanhVien[i].HienThiThongTin();
            Console.WriteLine("-------------------");
        }
    }

    public string GetSoNha()
    {
        return soNha;
    }

    public List<Nguoi> GetDanhSachThanhVien()
    {
        return danhSachThanhVien;
    }
}
