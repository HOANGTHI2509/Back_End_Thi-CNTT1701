using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhachHang
{
    private string hoTenChuHo;
    private string soNha;
    private string maSoCongTo;

    public KhachHang() { }

    public KhachHang(string hoTenChuHo, string soNha, string maSoCongTo)
    {
        this.hoTenChuHo = hoTenChuHo;
        this.soNha = soNha;
        this.maSoCongTo = maSoCongTo;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten chu ho: ");
        hoTenChuHo = Console.ReadLine();
        Console.Write("Nhap so nha: ");
        soNha = Console.ReadLine();
        Console.Write("Nhap ma so cong to: ");
        maSoCongTo = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten chu ho: " + hoTenChuHo);
        Console.WriteLine("So nha: " + soNha);
        Console.WriteLine("Ma so cong to: " + maSoCongTo);
    }
}
