using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThiSinhKhoiC : ThiSinh
{
    private double diemVan;
    private double diemSu;
    private double diemDia;

    public ThiSinhKhoiC() { }

    public ThiSinhKhoiC(string soBaoDanh, string hoTen, string diaChi, string uuTien, double diemVan, double diemSu, double diemDia)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        this.diemVan = diemVan;
        this.diemSu = diemSu;
        this.diemDia = diemDia;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap diem Van: ");
        diemVan = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Su: ");
        diemSu = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Dia: ");
        diemDia = double.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Diem Van: " + diemVan);
        Console.WriteLine("Diem Su: " + diemSu);
        Console.WriteLine("Diem Dia: " + diemDia);
        Console.WriteLine("Tong diem: " + TinhTongDiem());
    }

    public override double TinhTongDiem()
    {
        return diemVan + diemSu + diemDia;
    }
}
