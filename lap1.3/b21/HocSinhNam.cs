using System;

public class HocSinhNam : HocSinh // Kế thừa từ HocSinh
{
    public double DiemKiThuat { get; set; }

    // Constructor mặc định
    public HocSinhNam() : base()
    {
        GioiTinhNam = true; // Luôn là Nam
        DiemKiThuat = 0;
    }

    // Constructor có tham số (bao gồm cả của lớp cha)
    public HocSinhNam(string hoTen, double diemToan, double diemLy, double diemHoa, double diemKiThuat)
        : base(hoTen, true, diemToan, diemLy, diemHoa) // Giới tính luôn là true (Nam)
    {
        DiemKiThuat = diemKiThuat;
    }

    // Ghi đè phương thức InThongTin() để bổ sung điểm Kĩ thuật
    public override void InThongTin()
    {
        base.InThongTin(); // Gọi phương thức của lớp cha
        Console.WriteLine($"Điểm Kĩ thuật: {DiemKiThuat:F2}");
    }
}