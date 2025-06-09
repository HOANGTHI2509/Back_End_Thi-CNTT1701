using System;

public class HocSinhNu : HocSinh // Kế thừa từ HocSinh
{
    public double DiemNuCong { get; set; }

    // Constructor mặc định
    public HocSinhNu() : base()
    {
        GioiTinhNam = false; // Luôn là Nữ
        DiemNuCong = 0;
    }

    // Constructor có tham số (bao gồm cả của lớp cha)
    public HocSinhNu(string hoTen, double diemToan, double diemLy, double diemHoa, double diemNuCong)
        : base(hoTen, false, diemToan, diemLy, diemHoa) // Giới tính luôn là false (Nữ)
    {
        DiemNuCong = diemNuCong;
    }

    // Ghi đè phương thức InThongTin() để bổ sung điểm Nữ công
    public override void InThongTin()
    {
        base.InThongTin(); // Gọi phương thức của lớp cha
        Console.WriteLine($"Điểm Nữ công: {DiemNuCong:F2}");
    }
}