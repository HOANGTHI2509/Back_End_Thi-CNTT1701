using System;

public class THISINH
{
    // Các thuộc tính sử dụng các cấu trúc đã định nghĩa
    public HoTen HoTen { get; set; }
    public QueQuan QueQuan { get; set; }
    public string Truong { get; set; }
    public int Tuoi { get; set; }
    public string SoBaoDanh { get; set; }
    public DiemThi DiemThi { get; set; }

    // Constructor mặc định
    public THISINH()
    {
        HoTen = new HoTen("Chưa", "xác", "định");
        QueQuan = new QueQuan("Chưa", "xác", "định");
        Truong = "Chưa xác định";
        Tuoi = 0;
        SoBaoDanh = "000000";
        DiemThi = new DiemThi(0, 0, 0);
    }

    // Constructor đầy đủ tham số
    public THISINH(HoTen hoTen, QueQuan queQuan, string truong, int tuoi, string soBaoDanh, DiemThi diemThi)
    {
        HoTen = hoTen;
        QueQuan = queQuan;
        Truong = truong;
        Tuoi = tuoi;
        SoBaoDanh = soBaoDanh;
        DiemThi = diemThi;
    }

    // Phương thức để in tất cả thông tin chi tiết của một thí sinh
    public void InThongTinChiTiet()
    {
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Quê quán: {QueQuan}");
        Console.WriteLine($"Trường: {Truong}");
        Console.WriteLine($"Tuổi: {Tuoi}");
        Console.WriteLine($"Số báo danh: {SoBaoDanh}");
        Console.WriteLine($"Điểm thi: {DiemThi} (Tổng: {DiemThi.TongDiem:F2})");
    }
}