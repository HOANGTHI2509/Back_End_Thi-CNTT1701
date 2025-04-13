using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CBGV
{
    private double luongCung;
    private double thuong;
    private double phat;
    private double luongThucLinh;
    private Nguoi thongTinCaNhan;

    public CBGV()
    {
        thongTinCaNhan = new Nguoi();
    }

    public CBGV(double luongCung, double thuong, double phat, Nguoi thongTinCaNhan)
    {
        this.luongCung = luongCung;
        this.thuong = thuong;
        this.phat = phat;
        this.thongTinCaNhan = thongTinCaNhan;
        TinhLuongThucLinh();
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhap thong tin ca nhan:");
        thongTinCaNhan.NhapThongTin();
        Console.Write("Nhap luong cung: ");
        luongCung = double.Parse(Console.ReadLine());
        Console.Write("Nhap tien thuong: ");
        thuong = double.Parse(Console.ReadLine());
        Console.Write("Nhap tien phat: ");
        phat = double.Parse(Console.ReadLine());
        TinhLuongThucLinh();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Thong tin ca nhan:");
        thongTinCaNhan.HienThiThongTin();
        Console.WriteLine("Luong cung: " + luongCung);
        Console.WriteLine("Tien thuong: " + thuong);
        Console.WriteLine("Tien phat: " + phat);
        Console.WriteLine("Luong thuc linh: " + luongThucLinh);
    }

    public void TinhLuongThucLinh()
    {
        luongThucLinh = luongCung + thuong - phat;
    }

    public double GetLuongThucLinh()
    {
        return luongThucLinh;
    }

    public string GetQueQuan()
    {
        return thongTinCaNhan.GetQueQuan();
    }
}
