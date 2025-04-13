using System;
using System.Collections.Generic;

public class QLCB
{
    private List<CanBo> danhSachCanBo;

    public QLCB()
    {
        danhSachCanBo = new List<CanBo>();
    }

    public void NhapThongTinMoi()
    {
        Console.WriteLine("Chon loai can bo muon nhap:");
        Console.WriteLine("1. Cong nhan");
        Console.WriteLine("2. Ky su");
        Console.WriteLine("3. Nhan vien");
        Console.Write("Lua chon: ");
        int choice = int.Parse(Console.ReadLine());

        CanBo canBo = null;
        switch (choice)
        {
            case 1:
                canBo = new CongNhan();
                break;
            case 2:
                canBo = new KySu();
                break;
            case 3:
                canBo = new NhanVien();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        canBo.NhapThongTin();
        danhSachCanBo.Add(canBo);
        Console.WriteLine("Them can bo thanh cong!");
    }

    public void TimKiemTheoHoTen()
    {
        Console.Write("Nhap ho ten can tim: ");
        string hoTen = Console.ReadLine();
        bool found = false;

        foreach (var canBo in danhSachCanBo)
        {
            if (canBo.GetHoTen().Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                canBo.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay can bo voi ho ten: " + hoTen);
        }
    }

    public void HienThiDanhSach()
    {
        if (danhSachCanBo.Count == 0)
        {
            Console.WriteLine("Danh sach can bo trong!");
            return;
        }

        Console.WriteLine("Danh sach tat ca can bo:");
        foreach (var canBo in danhSachCanBo)
        {
            canBo.HienThiThongTin();
            Console.WriteLine("-------------------");
        }
    }
}