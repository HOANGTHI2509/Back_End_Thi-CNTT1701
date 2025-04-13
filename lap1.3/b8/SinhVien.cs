using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SinhVien
{
    private string hoTen;
    private int namSinh;
    private string lop;
    private string maSoSV;

    public SinhVien() { }

    public SinhVien(string hoTen, int namSinh, string lop, string maSoSV)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.lop = lop;
        this.maSoSV = maSoSV;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap lop: ");
        lop = Console.ReadLine();
        Console.Write("Nhap ma so sinh vien: ");
        maSoSV = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Lop: " + lop);
        Console.WriteLine("Ma so sinh vien: " + maSoSV);
    }

    public string GetMaSoSV()
    {
        return maSoSV;
    }
}