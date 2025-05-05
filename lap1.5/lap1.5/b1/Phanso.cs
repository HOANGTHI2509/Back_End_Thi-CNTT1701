using System;
using System.Collections.Generic;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tuSo, int mauSo)
    {
        TuSo = tuSo;
        MauSo = mauSo != 0 ? mauSo : 1; // Đảm bảo mẫu số khác 0
    }

    public void NhapPhanSo()
    {
        Console.Write("Nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        MauSo = int.Parse(Console.ReadLine());
        if (MauSo == 0) MauSo = 1; // Tránh chia cho 0
    }

    public static PhanSo CongPhanSo(PhanSo p1, PhanSo p2)
    {
        int tuMoi = p1.TuSo * p2.MauSo + p2.TuSo * p1.MauSo;
        int mauMoi = p1.MauSo * p2.MauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public void XuatPhanSo()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }
}
