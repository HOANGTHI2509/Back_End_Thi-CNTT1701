using System;

public class HoiVienCoNguoiYeu : HoiVienCoBan // Kế thừa từ HoiVienCoBan
{
    public string HoTenNguoiYeu { get; set; }
    public string SoDienThoaiNguoiYeu { get; set; }

    // Constructor mặc định
    public HoiVienCoNguoiYeu() : base()
    {
        HoTenNguoiYeu = "Chưa xác định";
        SoDienThoaiNguoiYeu = "Không có";
    }

    // Constructor có tham số (bao gồm cả của lớp cha)
    public HoiVienCoNguoiYeu(string hoTen, string diaChi, string hoTenNY, string sdtNY)
        : base(hoTen, diaChi)
    {
        HoTenNguoiYeu = hoTenNY;
        SoDienThoaiNguoiYeu = sdtNY;
    }

    // Ghi đè phương thức InThongTin() để bổ sung thông tin người yêu
    public override void InThongTin()
    {
        base.InThongTin(); // Gọi phương thức của lớp cha
        Console.WriteLine($"Người yêu: {HoTenNguoiYeu}");
        Console.WriteLine($"SĐT người yêu: {SoDienThoaiNguoiYeu}");
    }
}