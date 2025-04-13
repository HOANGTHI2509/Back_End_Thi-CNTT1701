using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class XeMay : PTGT
{
    private double congSuat;

    public XeMay() { }

    public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, double congSuat)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        this.congSuat = congSuat;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap cong suat: ");
        congSuat = double.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Cong suat: " + congSuat);
    }
}
