using System;
using System.Collections.Generic;

public class QuanLyTaiLieu
{
    private List<TaiLieu> danhSachTaiLieu;

    public QuanLyTaiLieu()
    {
        danhSachTaiLieu = new List<TaiLieu>();
    }

    public void NhapThongTinMoi()
    {
        Console.WriteLine("Chon loai tai lieu muon nhap:");
        Console.WriteLine("1. Sach");
        Console.WriteLine("2. Tap chi");
        Console.WriteLine("3. Bao");
        Console.Write("Lua chon: ");
        int choice = int.Parse(Console.ReadLine());

        TaiLieu taiLieu = null;
        switch (choice)
        {
            case 1:
                taiLieu = new Sach();
                break;
            case 2:
                taiLieu = new TapChi();
                break;
            case 3:
                taiLieu = new Bao();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        taiLieu.NhapThongTin();
        danhSachTaiLieu.Add(taiLieu);
        Console.WriteLine("Them tai lieu thanh cong!");
    }

    public void HienThiDanhSach()
    {
        if (danhSachTaiLieu.Count == 0)
        {
            Console.WriteLine("Danh sach tai lieu trong!");
            return;
        }

        Console.WriteLine("Danh sach tat ca tai lieu:");
        foreach (var taiLieu in danhSachTaiLieu)
        {
            taiLieu.HienThiThongTin();
            Console.WriteLine("-------------------");
        }
    }

    public void TimKiemTheoLoai()
    {
        Console.WriteLine("Chon loai tai lieu muon tim:");
        Console.WriteLine("1. Sach");
        Console.WriteLine("2. Tap chi");
        Console.WriteLine("3. Bao");
        Console.Write("Lua chon: ");
        int choice = int.Parse(Console.ReadLine());

        string loaiTaiLieu = "";
        switch (choice)
        {
            case 1:
                loaiTaiLieu = "Sach";
                break;
            case 2:
                loaiTaiLieu = "TapChi";
                break;
            case 3:
                loaiTaiLieu = "Bao";
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        bool found = false;
        foreach (var taiLieu in danhSachTaiLieu)
        {
            if (taiLieu.GetLoaiTaiLieu() == loaiTaiLieu)
            {
                taiLieu.HienThiThongTin();
                Console.WriteLine("-------------------");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Khong tim thay tai lieu loai {loaiTaiLieu}!");
        }
    }
}