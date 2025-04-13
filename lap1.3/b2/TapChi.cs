using System;

public class TapChi : TaiLieu
{
    private int soPhatHanh;
    private int thangPhatHanh;

    public TapChi() { }

    public TapChi(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, int soPhatHanh, int thangPhatHanh)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        this.soPhatHanh = soPhatHanh;
        this.thangPhatHanh = thangPhatHanh;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap so phat hanh: ");
        soPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang phat hanh: ");
        thangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("So phat hanh: " + soPhatHanh);
        Console.WriteLine("Thang phat hanh: " + thangPhatHanh);
    }
}