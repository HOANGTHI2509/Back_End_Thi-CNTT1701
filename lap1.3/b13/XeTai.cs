using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class XeTai : PTGT
{
    private double trongTai;

    public XeTai() { }

    public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        this.trongTai = trongTai;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap trong tai: ");
        trongTai = double.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Trong tai: " + trongTai);
    }
}
