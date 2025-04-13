using System;

public class Bao : TaiLieu
{
    private string ngayPhatHanh;

    public Bao() { }

    public Bao(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string ngayPhatHanh)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        this.ngayPhatHanh = ngayPhatHanh;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap ngay phat hanh (dd/mm/yyyy): ");
        ngayPhatHanh = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Ngay phat hanh: " + ngayPhatHanh);
    }
}