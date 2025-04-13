using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HSHocSinh
{
    private string lop;
    private string khoaHoc;
    private string kyHoc;
    private Nguoi thongTinCaNhan;

    public HSHocSinh()
    {
        thongTinCaNhan = new Nguoi();
    }

    public HSHocSinh(string lop, string khoaHoc, string kyHoc, Nguoi thongTinCaNhan)
    {
        this.lop = lop;
        this.khoaHoc = khoaHoc;
        this.kyHoc = kyHoc;
        this.thongTinCaNhan = thongTinCaNhan;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap lop: ");
        lop = Console.ReadLine();
        Console.Write("Nhap khoa hoc: ");
        khoaHoc = Console.ReadLine();
        Console.Write("Nhap ky hoc: ");
        kyHoc = Console.ReadLine();
        Console.WriteLine("Nhap thong tin ca nhan:");
        thongTinCaNhan.NhapThongTin();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Lop: " + lop);
        Console.WriteLine("Khoa hoc: " + khoaHoc);
        Console.WriteLine("Ky hoc: " + kyHoc);
        Console.WriteLine("Thong tin ca nhan:");
        thongTinCaNhan.HienThiThongTin();
    }

    public string GetQueQuan()
    {
        return thongTinCaNhan.GetQueQuan();
    }

    public string GetGioiTinh()
    {
        return thongTinCaNhan.GetGioiTinh();
    }

    public int GetNamSinh()
    {
        return thongTinCaNhan.GetNamSinh();
    }
}
