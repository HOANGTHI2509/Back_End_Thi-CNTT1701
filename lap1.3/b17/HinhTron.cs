using System;
using System.Collections.Generic; // Để sử dụng List

public class HinhTron
{
    private Diem tam; // Tâm của hình tròn
    private float banKinh; // Bán kính của hình tròn

    // Toán tử tạo lập mặc định
    public HinhTron()
    {
        tam = new Diem(); // Tâm là điểm gốc (0,0)
        banKinh = 0; // Bán kính bằng 0
    }

    // Toán tử tạo lập với tâm và bán kính
    public HinhTron(Diem d, float bk)
    {
        if (bk < 0)
        {
            Console.WriteLine("Cảnh báo: Bán kính không được âm. Đặt bán kính bằng 0.");
            this.banKinh = 0;
        }
        else
        {
            this.tam = d;
            this.banKinh = bk;
        }
    }

    // Thuộc tính để truy cập tâm (get)
    public Diem Tam
    {
        get { return tam; }
    }

    // Thuộc tính để truy cập bán kính (get)
    public float BanKinh
    {
        get { return banKinh; }
    }

    // Phương thức tính chu vi hình tròn
    public double TinhChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    // Phương thức tính diện tích hình tròn
    public double TinhDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }

    // Phương thức kiểm tra hai hình tròn có giao nhau không
    public bool GiaoNhauVoi(HinhTron otherHinhTron)
    {
        // Khoảng cách giữa hai tâm
        double khoangCachTam = this.tam.TinhKhoangCach(otherHinhTron.tam);

        // Tổng bán kính của hai hình tròn
        double tongBanKinh = this.banKinh + otherHinhTron.banKinh;

        // Hai hình tròn giao nhau nếu khoảng cách giữa hai tâm nhỏ hơn hoặc bằng tổng bán kính
        // Và lớn hơn hoặc bằng trị tuyệt đối của hiệu hai bán kính (để xử lý trường hợp lồng nhau)
        return khoangCachTam <= tongBanKinh && khoangCachTam >= Math.Abs(this.banKinh - otherHinhTron.banKinh);
    }

    // Phương thức hiển thị thông tin hình tròn
    public void HienThiThongTin()
    {
        Console.WriteLine($"Hình tròn có tâm tại ({tam.X}, {tam.Y}) và bán kính {banKinh:F2}");
        Console.WriteLine($"  Chu vi: {TinhChuVi():F2}");
        Console.WriteLine($"  Diện tích: {TinhDienTich():F2}");
    }
}