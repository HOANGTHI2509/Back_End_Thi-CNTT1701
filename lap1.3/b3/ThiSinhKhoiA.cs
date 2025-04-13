using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThiSinhKhoiA : ThiSinh
{
    private double diemToan;
    private double diemLy;
    private double diemHoa;

    public ThiSinhKhoiA() { }

    public ThiSinhKhoiA(string soBaoDanh, string hoTen, string diaChi, string uuTien, double diemToan, double diemLy, double diemHoa)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        this.diemToan = diemToan;
        this.diemLy = diemLy;
        this.diemHoa = diemHoa;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap diem Toan: ");
        diemToan = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Ly: ");
        diemLy = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Hoa: ");
        diemHoa = double.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Diem Toan: " + diemToan);
        Console.WriteLine("Diem Ly: " + diemLy);
        Console.WriteLine("Diem Hoa: " + diemHoa);
        Console.WriteLine("Tong diem: " + TinhTongDiem());
    }

    public override double TinhTongDiem()
    {
        return diemToan + diemLy + diemHoa;
    }
}
