using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Hinh> danhSachHinh = new List<Hinh>
        {
            new HinhTron(5),
            new HinhVuong(4),
            new HinhChuNhat(6, 3),
            new HinhTamGiac(3, 4, 5)
        };

        double tongChuVi = 0, tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.TinhChuVi();
            tongDienTich += hinh.TinhDienTich();
        }

        Console.WriteLine($"Tong chu vi: {tongChuVi}");
        Console.WriteLine($"Tong dien tich: {tongDienTich}");
    }
}
