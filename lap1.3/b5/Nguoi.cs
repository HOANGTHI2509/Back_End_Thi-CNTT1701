using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nguoi
{
    private string hoTen;
    private int namSinh;
    private string soCMND;

    public Nguoi() { }

    public Nguoi(string hoTen, int namSinh, string soCMND)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.soCMND = soCMND;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap so CMND: ");
        soCMND = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("So CMND: " + soCMND);
    }

    public string GetHoTen()
    {
        return hoTen;
    }
}
