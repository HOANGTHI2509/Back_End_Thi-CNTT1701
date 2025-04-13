using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OTo : PTGT
{
    private int soChoNgoi;
    private string kieuDongCo;

    public OTo() { }

    public OTo(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soChoNgoi, string kieuDongCo)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        this.soChoNgoi = soChoNgoi;
        this.kieuDongCo = kieuDongCo;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap so cho ngoi: ");
        soChoNgoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap kieu dong co: ");
        kieuDongCo = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("So cho ngoi: " + soChoNgoi);
        Console.WriteLine("Kieu dong co: " + kieuDongCo);
    }
}
