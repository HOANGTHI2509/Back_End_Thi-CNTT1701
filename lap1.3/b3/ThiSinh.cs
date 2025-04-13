using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThiSinh
{
    protected string soBaoDanh;
    protected string hoTen;
    protected string diaChi;
    protected string uuTien;

    public ThiSinh() { }

    public ThiSinh(string soBaoDanh, string hoTen, string diaChi, string uuTien)
    {
        this.soBaoDanh = soBaoDanh;
        this.hoTen = hoTen;
        this.diaChi = diaChi;
        this.uuTien = uuTien;
    }

    public virtual void NhapThongTin()
    {
        Console.Write("Nhap so bao danh: ");
        soBaoDanh = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        diaChi = Console.ReadLine();
        Console.Write("Nhap uu tien: ");
        uuTien = Console.ReadLine();
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine("So bao danh: " + soBaoDanh);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Dia chi: " + diaChi);
        Console.WriteLine("Uu tien: " + uuTien);
    }

    public string GetSoBaoDanh()
    {
        return soBaoDanh;
    }

    public virtual double TinhTongDiem()
    {
        return 0; // Phương thức này sẽ được ghi đè bởi các lớp con
    }
}