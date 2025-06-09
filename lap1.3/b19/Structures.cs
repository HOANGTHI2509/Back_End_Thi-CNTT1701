using System;

// Cấu trúc Họ tên của thí sinh
public struct HoTen
{
    public string Ho;
    public string TenDem;
    public string Ten;

    public HoTen(string ho, string tenDem, string ten)
    {
        Ho = ho;
        TenDem = tenDem;
        Ten = ten;
    }

    // Ghi đè phương thức ToString() để in họ tên đầy đủ
    public override string ToString()
    {
        return $"{Ho} {TenDem} {Ten}";
    }
}

// Cấu trúc Quê quán của thí sinh
public struct QueQuan
{
    public string Xa;
    public string Huyen;
    public string Tinh;

    public QueQuan(string xa, string huyen, string tinh)
    {
        Xa = xa;
        Huyen = huyen;
        Tinh = tinh;
    }

    // Ghi đè phương thức ToString() để in quê quán đầy đủ
    public override string ToString()
    {
        return $"{Xa}, {Huyen}, {Tinh}";
    }
}

// Cấu trúc Điểm thi (điểm chấm chính xác đến 1/4)
public struct DiemThi
{
    public double Toan;
    public double Ly;
    public double Hoa;

    public DiemThi(double toan, double ly, double hoa)
    {
        // Đảm bảo điểm được làm tròn đến 0.25 gần nhất
        Toan = Math.Round(toan * 4) / 4;
        Ly = Math.Round(ly * 4) / 4;
        Hoa = Math.Round(hoa * 4) / 4;
    }

    // Thuộc tính chỉ đọc để tính tổng điểm
    public double TongDiem
    {
        get { return Toan + Ly + Hoa; }
    }

    // Ghi đè phương thức ToString() để in điểm các môn
    public override string ToString()
    {
        return $"Toán: {Toan:F2}, Lý: {Ly:F2}, Hóa: {Hoa:F2}";
    }
}