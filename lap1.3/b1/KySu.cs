using System;

public class KySu : CanBo
{
    private string nganhDaoTao;

    public KySu() { }

    public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        this.nganhDaoTao = nganhDaoTao;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap nganh dao tao: ");
        nganhDaoTao = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Nganh dao tao: " + nganhDaoTao);
    }
}