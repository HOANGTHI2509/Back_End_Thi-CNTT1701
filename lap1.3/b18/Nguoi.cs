using System;

public class Nguoi
{
    // Thuộc tính
    private string hoTen;
    private bool gioiTinh; // true: Nam, false: Nữ
    private int tuoi;

    // Toán tử tạo lập mặc định
    public Nguoi()
    {
        this.hoTen = "Chưa xác định";
        this.gioiTinh = true; // Mặc định là Nam
        this.tuoi = 0;
    }

    // Toán tử tạo lập với đầy đủ tham số
    public Nguoi(string hoTen, bool gioiTinh, int tuoi)
    {
        this.hoTen = hoTen;
        this.gioiTinh = gioiTinh;
        this.tuoi = tuoi;
    }

    // Các thuộc tính chỉ đọc (get) để truy cập thông tin từ bên ngoài
    public string HoTen
    {
        get { return hoTen; }
    }

    public bool GioiTinh
    {
        get { return gioiTinh; }
    }

    public int Tuoi
    {
        get { return tuoi; }
    }

    // Phương thức in thông tin về một cá nhân
    public virtual void InThongTin()
    {
        Console.WriteLine($"Họ tên: {this.hoTen}");
        Console.WriteLine($"Giới tính: {(this.gioiTinh ? "Nam" : "Nữ")}");
        Console.WriteLine($"Tuổi: {this.tuoi}");
    }
}