public class NhanVien : CanBo
{
    private string congViec;

    public NhanVien() { }

    public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec)
        : base(hoTen, namSinh, gioiTinh, diaChi) 
    {
        this.congViec = congViec;
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhap cong viec: ");
        congViec = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine("Cong viec: " + congViec);
    }
}