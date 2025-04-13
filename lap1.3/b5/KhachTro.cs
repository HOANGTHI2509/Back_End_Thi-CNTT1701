using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KhachTro
{
    private int soNgayTro;
    private string loaiPhong;
    private double giaPhong;
    private Nguoi thongTinCaNhan;

    public KhachTro()
    {
        thongTinCaNhan = new Nguoi();
    }

    public KhachTro(int soNgayTro, string loaiPhong, double giaPhong, Nguoi thongTinCaNhan)
    {
        this.soNgayTro = soNgayTro;
        this.loaiPhong = loaiPhong;
        this.giaPhong = giaPhong;
        this.thongTinCaNhan = thongTinCaNhan;
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhap thong tin ca nhan:");
        thongTinCaNhan.NhapThongTin();
        Console.Write("Nhap so ngay tro: ");
        soNgayTro = int.Parse(Console.ReadLine());
        Console.Write("Nhap loai phong: ");
        loaiPhong = Console.ReadLine();
        Console.Write("Nhap gia phong: ");
        giaPhong = double.Parse(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Thong tin ca nhan:");
        thongTinCaNhan.HienThiThongTin();
        Console.WriteLine("So ngay tro: " + soNgayTro);
        Console.WriteLine("Loai phong: " + loaiPhong);
        Console.WriteLine("Gia phong: " + giaPhong);
    }

    public double TinhTienPhong()
    {
        return soNgayTro * giaPhong;
    }

    public string GetHoTen()
    {
        return thongTinCaNhan.GetHoTen();
    }
}
