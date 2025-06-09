using System;

public class Diem
{
    private double x; // Hoành độ
    private double y; // Tung độ

    // Toán tử tạo lập (Constructor)
    public Diem(double x = 0, double y = 0)
    {
        this.x = x;
        this.y = y;
    }

    // Thuộc tính để truy cập hoành độ (get)
    public double X
    {
        get { return x; }
    }

    // Thuộc tính để truy cập tung độ (get)
    public double Y
    {
        get { return y; }
    }

    // Phương thức in một đối tượng Diem
    public void InDiem()
    {
        Console.WriteLine($"({x}, {y})");
    }

    // Tính khoảng cách giữa hai điểm
    public double TinhKhoangCach(Diem otherDiem)
    {
        double deltaX = this.x - otherDiem.x;
        double deltaY = this.y - otherDiem.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}