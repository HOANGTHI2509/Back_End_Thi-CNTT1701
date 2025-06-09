using System;
using System.Globalization; // Cần dùng cho TextInfo để chuyển chữ hoa

public class HocSinh
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public double TongDiem { get; set; }

    // Constructor mặc định
    public HocSinh()
    {
        HoTen = "Chưa xác định";
        NamSinh = 2000;
        TongDiem = 0.0;
    }

    // Constructor có tham số
    public HocSinh(string hoTen, int namSinh, double tongDiem)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        TongDiem = tongDiem;
    }

    // Phương thức để in thông tin học sinh
    public void InThongTin()
    {
        // Chuyển đổi họ tên sang dạng viết hoa chữ cái đầu mỗi từ
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        string hoTenFormatted = ti.ToTitleCase(HoTen.ToLower()); // Chuyển về chữ thường rồi mới in hoa chữ cái đầu

        Console.WriteLine($"Họ tên: {hoTenFormatted,-25} | Năm sinh: {NamSinh,-8} | Tổng điểm: {TongDiem:F2,-8}");
    }
}