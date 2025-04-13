using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PTGT
{
    protected string hangSanXuat;
    protected int namSanXuat;
    protected double giaBan;
    protected string mau;

    public PTGT() { }

    public PTGT(string hangSanXuat, int namSanXuat, double giaBan, string mau)
    {
        this.hangSanXuat = hangSanXuat;
        this.namSanXuat = namSanXuat;
        this.giaBan = giaBan;
        this.mau = mau;
    }

    public virtual void NhapThongTin()
    {
        Console.Write("Nhap hang san xuat: ");
        hangSanXuat = Console.ReadLine();
        Console.Write("Nhap nam san xuat: ");
        namSanXuat = int.Parse(Console.ReadLine());
        Console.Write("Nhap gia ban: ");
        giaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhap mau: ");
        mau = Console.ReadLine();
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine("Hang san xuat: " + hangSanXuat);
        Console.WriteLine("Nam san xuat: " + namSanXuat);
        Console.WriteLine("Gia ban: " + giaBan);
        Console.WriteLine("Mau: " + mau);
    }

    public string GetMau()
    {
        return mau;
    }

    public int GetNamSanXuat()
    {
        return namSanXuat;
    }

    public string GetLoaiPhuongTien()
    {
        return this.GetType().Name;
    }
}
