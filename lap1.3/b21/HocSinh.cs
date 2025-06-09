using System;

public class HocSinh
{
    public string HoTen { get; set; }
    public bool GioiTinhNam { get; set; } // true: Nam, false: Nữ
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    // Constructor mặc định
    public HocSinh()
    {
        HoTen = "Chưa xác định";
        GioiTinhNam = true; // Mặc định là Nam
        DiemToan = 0;
        DiemLy = 0;
        DiemHoa = 0;
    }

    // Constructor có tham số
    public HocSinh(string hoTen, bool gioiTinhNam, double diemToan, double diemLy, double diemHoa)
    {
        HoTen = hoTen;
        GioiTinhNam = gioiTinhNam;
        DiemToan = diemToan;
        DiemLy = diemLy;
        DiemHoa = diemHoa;
    }

    // Phương thức ảo (virtual) để in thông tin chung của học sinh
    public virtual void InThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Giới tính: {(GioiTinhNam ? "Nam" : "Nữ")}");
        Console.WriteLine($"Điểm Toán: {DiemToan:F2}");
        Console.WriteLine($"Điểm Lý: {DiemLy:F2}");
        Console.WriteLine($"Điểm Hóa: {DiemHoa:F2}");
    }
}