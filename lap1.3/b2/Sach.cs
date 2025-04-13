using System;

public class Sach : TaiLieu
{
    private string tenTacGia;
    private int soTrang;

    public Sach() { }

    public Sach(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string tenTacGia, int soTrang)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        this.tenTacGia = tenTacGia;
        this.soTrang = soTrang;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap ten tac gia: ");
        tenTacGia = Console.ReadLine();
        Console.Write("Nhap so trang: ");
        soTrang = int.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Ten tac gia: " + tenTacGia);
        Console.WriteLine("So trang: " + soTrang);
    }
}