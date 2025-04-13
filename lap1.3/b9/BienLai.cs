using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BienLai
{
    private KhachHang thongTinKhachHang;
    private double chiSoCu;
    private double chiSoMoi;
    private double soTienPhaiTra;

    public BienLai()
    {
        thongTinKhachHang = new KhachHang();
    }

    public BienLai(KhachHang thongTinKhachHang, double chiSoCu, double chiSoMoi)
    {
        this.thongTinKhachHang = thongTinKhachHang;
        this.chiSoCu = chiSoCu;
        this.chiSoMoi = chiSoMoi;
        TinhTienPhaiTra();
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhap thong tin khach hang:");
        thongTinKhachHang.NhapThongTin();
        Console.Write("Nhap chi so cu: ");
        chiSoCu = double.Parse(Console.ReadLine());
        Console.Write("Nhap chi so moi: ");
        chiSoMoi = double.Parse(Console.ReadLine());
        TinhTienPhaiTra();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Thong tin khach hang:");
        thongTinKhachHang.HienThiThongTin();
        Console.WriteLine("Chi so cu: " + chiSoCu);
        Console.WriteLine("Chi so moi: " + chiSoMoi);
        Console.WriteLine("So tien phai tra: " + soTienPhaiTra + " VND");
    }

    public void TinhTienPhaiTra()
    {
        double soDienTieuThu = chiSoMoi - chiSoCu;

        if (soDienTieuThu < 50)
        {
            soTienPhaiTra = soDienTieuThu * 1250;
        }
        else if (soDienTieuThu < 100)
        {
            soTienPhaiTra = soDienTieuThu * 1500;
        }
        else
        {
            soTienPhaiTra = soDienTieuThu * 2000;
        }
    }
}
