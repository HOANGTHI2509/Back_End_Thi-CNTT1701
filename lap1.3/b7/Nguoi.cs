using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nguoi
{
    private string hoTen;
    private int namSinh;
    private string queQuan;
    private string soCMND;

    public Nguoi() { }

    public Nguoi(string hoTen, int namSinh, string queQuan, string soCMND)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.queQuan = queQuan;
        this.soCMND = soCMND;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap que quan: ");
        queQuan = Console.ReadLine();
        Console.Write("Nhap so CMND: ");
        soCMND = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Que quan: " + queQuan);
        Console.WriteLine("So CMND: " + soCMND);
    }

    public string GetQueQuan()
    {
        return queQuan;
    }
}
