using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nguoi
{
    private string soCMND;
    private string hoTen;
    private int tuoi;
    private int namSinh;
    private string ngheNghiep;

    public Nguoi() { }

    public Nguoi(string soCMND, string hoTen, int tuoi, int namSinh, string ngheNghiep)
    {
        this.soCMND = soCMND;
        this.hoTen = hoTen;
        this.tuoi = tuoi;
        this.namSinh = namSinh;
        this.ngheNghiep = ngheNghiep;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap so CMND: ");
        soCMND = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap nghe nghiep: ");
        ngheNghiep = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("So CMND: " + soCMND);
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Nghe nghiep: " + ngheNghiep);
    }

    public string GetHoTen()
    {
        return hoTen;
    }
}
