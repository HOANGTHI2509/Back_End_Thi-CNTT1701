using System;
using System.Collections.Generic; // Để sử dụng List

public class TamGiac
{
    private Diem d1;
    private Diem d2;
    private Diem d3;

    // Toán tử tạo lập mặc định
    public TamGiac()
    {
        d1 = new Diem();
        d2 = new Diem();
        d3 = new Diem();
    }

    // Toán tử tạo lập với 3 đối tượng Diem
    public TamGiac(Diem d1, Diem d2, Diem d3)
    {
        // Kiểm tra xem ba điểm có tạo thành một tam giác hợp lệ không (không thẳng hàng)
        if (LaTamGiacHopLe(d1, d2, d3))
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }
        else
        {
            Console.WriteLine("Cảnh báo: Ba điểm này không tạo thành một tam giác hợp lệ (có thể thẳng hàng). Khởi tạo tam giác với các điểm gốc (0,0).");
            this.d1 = new Diem();
            this.d2 = new Diem();
            this.d3 = new Diem();
        }
    }

    // Phương thức kiểm tra ba điểm có thẳng hàng không
    private bool LaTamGiacHopLe(Diem p1, Diem p2, Diem p3)
    {
        // Sử dụng công thức diện tích tam giác: 0 nếu thẳng hàng
        // 0.5 * |x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)|
        double dienTich = 0.5 * Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y));
        return dienTich > 0; // Diện tích lớn hơn 0 thì không thẳng hàng
    }

    // Tính chu vi của tam giác
    public double TinhChuVi()
    {
        double canhAB = d1.TinhKhoangCach(d2);
        double canhBC = d2.TinhKhoangCach(d3);
        double canhCA = d3.TinhKhoangCach(d1);
        return canhAB + canhBC + canhCA;
    }

    // Tính diện tích tam giác (sử dụng công thức Heron)
    public double TinhDienTich()
    {
        double a = d1.TinhKhoangCach(d2);
        double b = d2.TinhKhoangCach(d3);
        double c = d3.TinhKhoangCach(d1);

        // Nửa chu vi
        double p = (a + b + c) / 2;

        // Công thức Heron
        double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return dienTich;
    }
}