using System;

public class TaiLieu
{
    protected string maTaiLieu;
    protected string tenNhaXuatBan;
    protected int soBanPhatHanh;

    public TaiLieu() { }

    public TaiLieu(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh)
    {
        this.maTaiLieu = maTaiLieu;
        this.tenNhaXuatBan = tenNhaXuatBan;
        this.soBanPhatHanh = soBanPhatHanh;
    }

    public virtual void NhapThongTin()
    {
        Console.Write("Nhap ma tai lieu: ");
        maTaiLieu = Console.ReadLine();
        Console.Write("Nhap ten nha xuat ban: ");
        tenNhaXuatBan = Console.ReadLine();
        Console.Write("Nhap so ban phat hanh: ");
        soBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine("Ma tai lieu: " + maTaiLieu);
        Console.WriteLine("Ten nha xuat ban: " + tenNhaXuatBan);
        Console.WriteLine("So ban phat hanh: " + soBanPhatHanh);
    }

    public string GetLoaiTaiLieu()
    {
        return this.GetType().Name;
    }
}