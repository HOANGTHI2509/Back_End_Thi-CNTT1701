using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nguoi
{
    private string hoTen;
    private int tuoi;
    private int namSinh;
    private string queQuan;
    private string gioiTinh;

    public Nguoi() { }

    public Nguoi(string hoTen, int tuoi, int namSinh, string queQuan, string gioiTinh)
    {
        this.hoTen = hoTen;
        this.tuoi = tuoi;
        this.namSinh = namSinh;
        this.queQuan = queQuan;
        this.gioiTinh = gioiTinh;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap que quan: ");
        queQuan = Console.ReadLine();
        Console.Write("Nhap gioi tinh (Nam/Nu): ");
        gioiTinh = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("Nam sinh: " + namSinh);
        Console.WriteLine("Que quan: " + queQuan);
        Console.WriteLine("Gioi tinh: " + gioiTinh);
    }

    public string GetQueQuan()
    {
        return queQuan;
    }

    public string GetGioiTinh()
    {
        return gioiTinh;
    }

    public int GetNamSinh()
    {
        return namSinh;
    }
}
