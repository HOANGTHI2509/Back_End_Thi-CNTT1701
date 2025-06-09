using System;

public class HoiVienDaKetHon : HoiVienCoNguoiYeu // Kế thừa từ HoiVienCoNguoiYeu
{
    public string HoTenVoChong { get; set; }
    public DateTime NgayCuoi { get; set; }

    // Constructor mặc định
    public HoiVienDaKetHon() : base()
    {
        HoTenVoChong = "Chưa xác định";
        NgayCuoi = DateTime.MinValue; // Giá trị ngày tháng nhỏ nhất
    }

    // Constructor có tham số (bao gồm cả của các lớp cha)
    public HoiVienDaKetHon(string hoTen, string diaChi, string hoTenNY, string sdtNY, string hoTenVC, DateTime ngayCuoi)
        : base(hoTen, diaChi, hoTenNY, sdtNY)
    {
        HoTenVoChong = hoTenVC;
        NgayCuoi = ngayCuoi;
    }

    // Ghi đè phương thức InThongTin() để bổ sung thông tin vợ/chồng và ngày cưới
    public override void InThongTin()
    {
        base.InThongTin(); // Gọi phương thức của lớp cha (HoiVienCoNguoiYeu)
        Console.WriteLine($"Tên vợ/chồng: {HoTenVoChong}");
        Console.WriteLine($"Ngày cưới: {NgayCuoi:dd/MM/yyyy}"); // Định dạng ngày tháng
    }
}