using System;

public class CoQuan : Nguoi // Lớp CoQuan kế thừa từ lớp Nguoi
{
    // Hằng số lương cơ bản
    public const double LUONG_CO_BAN = 1050000; // 1.050.000 VNĐ

    // Thuộc tính riêng của lớp CoQuan
    private string donViCongTac;
    private double heSoLuong;

    // Toán tử tạo lập mặc định
    public CoQuan() : base() // Gọi constructor mặc định của lớp cha Nguoi
    {
        this.donViCongTac = "Chưa xác định";
        this.heSoLuong = 0.0;
    }

    // Toán tử tạo lập với đầy đủ tham số, bao gồm cả tham số của lớp cha
    public CoQuan(string hoTen, bool gioiTinh, int tuoi, string donViCongTac, double heSoLuong)
        : base(hoTen, gioiTinh, tuoi) // Gọi constructor của lớp cha Nguoi với các tham số tương ứng
    {
        this.donViCongTac = donViCongTac;
        this.heSoLuong = heSoLuong;
    }

    // Thuộc tính chỉ đọc (get) cho donViCongTac và heSoLuong
    public string DonViCongTac
    {
        get { return donViCongTac; }
    }

    public double HeSoLuong
    {
        get { return heSoLuong; }
    }

    // Ghi đè phương thức InThongTin() từ lớp Nguoi
    public override void InThongTin()
    {
        base.InThongTin(); // Gọi phương thức InThongTin của lớp cha để in thông tin cơ bản
        Console.WriteLine($"Đơn vị công tác: {this.donViCongTac}");
        Console.WriteLine($"Hệ số lương: {this.heSoLuong:F2}"); // Định dạng 2 chữ số thập phân
        Console.WriteLine($"Lương: {TinhLuong():N0} VNĐ"); // Định dạng số có dấu phẩy ngăn cách hàng nghìn
    }

    // Phương thức tính lương cho cá nhân trong cơ quan
    public double TinhLuong()
    {
        return this.heSoLuong * LUONG_CO_BAN;
    }
}