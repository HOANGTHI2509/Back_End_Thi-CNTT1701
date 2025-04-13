using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThiSinhKhoiB : ThiSinh
{
    private double diemToan;
    private double diemHoa;
    private double diemSinh;

    public ThiSinhKhoiB() { }

    public ThiSinhKhoiB(string soBaoDanh, string hoTen, string diaChi, string uuTien, double diemToan, double diemHoa, double diemSinh)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        this.diemToan = diemToan;
        this.diemHoa = diemHoa;
        this.diemSinh = diemSinh;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap diem Toan: ");
        diemToan = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Hoa: ");
        diemHoa = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem Sinh: ");
        diemSinh = double.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Diem Toan: " + diemToan);
        Console.WriteLine("Diem Hoa: " + diemHoa);
        Console.WriteLine("Diem Sinh: " + diemSinh);
        Console.WriteLine("Tong diem: " + TinhTongDiem());
    }

    public override double TinhTongDiem()
    {
        return diemToan + diemHoa + diemSinh;
    }
}

