using System;

public class CongNhan : CanBo
{
    private string bac;

    public CongNhan() { }

    public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        this.bac = bac;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap bac (vi du: 3/7): ");
        bac = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Bac: " + bac);
    }
}