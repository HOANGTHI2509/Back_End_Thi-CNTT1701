using System;

public class HoiVienCoBan
{
    public string HoTen { get; set; }
    public string DiaChi { get; set; }

    // Constructor mặc định
    public HoiVienCoBan()
    {
        HoTen = "Chưa xác định";
        DiaChi = "Chưa xác định";
    }

    // Constructor có tham số
    public HoiVienCoBan(string hoTen, string diaChi)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
    }

    // Phương thức ảo (virtual) để in thông tin cơ bản
    public virtual void InThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
    }
}