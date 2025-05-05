class Program
{
    static void Main()
    {
        List<PhanSo> danhSachPhanSo = new List<PhanSo>();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap phan so thu {i + 1}:");
            PhanSo ps = new PhanSo(0, 1);
            ps.NhapPhanSo();
            danhSachPhanSo.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSachPhanSo)
        {
            tong = PhanSo.CongPhanSo(tong, ps);
        }

        Console.Write("tong cac phan so ");
        tong.XuatPhanSo();
    }
}
