using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TheMuon
{
    private string soPhieuMuon;
    private DateTime ngayMuon;
    private DateTime hanTra;
    private string soHieuSach;
    private SinhVien thongTinSinhVien;

    public TheMuon()
    {
        thongTinSinhVien = new SinhVien();
    }

    public TheMuon(string soPhieuMuon, DateTime ngayMuon, DateTime hanTra, string soHieuSach, SinhVien thongTinSinhVien)
    {
        this.soPhieuMuon = soPhieuMuon;
        this.ngayMuon = ngayMuon;
        this.hanTra = hanTra;
        this.soHieuSach = soHieuSach;
        this.thongTinSinhVien = thongTinSinhVien;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhap so phieu muon: ");
        soPhieuMuon = Console.ReadLine();
        Console.Write("Nhap ngay muon (dd/MM/yyyy): ");
        ngayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Nhap han tra (dd/MM/yyyy): ");
        hanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Nhap so hieu sach: ");
        soHieuSach = Console.ReadLine();
        Console.WriteLine("Nhap thong tin sinh vien:");
        thongTinSinhVien.NhapThongTin();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("So phieu muon: " + soPhieuMuon);
        Console.WriteLine("Ngay muon: " + ngayMuon.ToString("dd/MM/yyyy"));
        Console.WriteLine("Han tra: " + hanTra.ToString("dd/MM/yyyy"));
        Console.WriteLine("So hieu sach: " + soHieuSach);
        Console.WriteLine("Thong tin sinh vien:");
        thongTinSinhVien.HienThiThongTin();
    }

    public string GetMaSoSV()
    {
        return thongTinSinhVien.GetMaSoSV();
    }

    public DateTime GetHanTra()
    {
        return hanTra;
    }
}
