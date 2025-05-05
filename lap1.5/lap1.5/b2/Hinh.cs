using System;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }
    public HinhTron(double r) { BanKinh = r; }

    public override double TinhChuVi() => 2 * Math.PI * BanKinh;
    public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }
    public HinhVuong(double c) { Canh = c; }

    public override double TinhChuVi() => 4 * Canh;
    public override double TinhDienTich() => Canh * Canh;
}

class HinhChuNhat : Hinh
{
    public double ChieuDai { get; set; }
    public double ChieuRong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        ChieuDai = dai;
        ChieuRong = rong;
    }

    public override double TinhChuVi() => 2 * (ChieuDai + ChieuRong);
    public override double TinhDienTich() => ChieuDai * ChieuRong;
}

class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double TinhChuVi() => A + B + C;

    public override double TinhDienTich()
    {
        double p = TinhChuVi() / 2; // Nua chu vi
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Cong thuc Heron
    }
}
