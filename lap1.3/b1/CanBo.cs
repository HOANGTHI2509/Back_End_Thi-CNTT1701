using System;

public class CanBo
{
    protected string hoTen;
    protected int namSinh;
    protected string gioiTinh;
    protected string diaChi;

    public CanBo() { }

    public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.gioiTinh = gioiTinh;
        this.diaChi = diaChi;
    }

    public virtual void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap gioi tinh: ");
        gioiTinh = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        diaChi = Console.ReadLine();
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Gioi tinh: " + gioiTinh);
        Console.WriteLine("Dia chi: " + diaChi);
    }

    public string GetHoTen()
    {
        return hoTen;
    }
}