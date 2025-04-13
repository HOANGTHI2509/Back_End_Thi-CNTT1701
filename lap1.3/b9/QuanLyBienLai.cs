using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuanLyBienLai
{
    private List<BienLai> danhSachBienLai;

    public QuanLyBienLai()
    {
        danhSachBienLai = new List<BienLai>();
    }

    public void NhapDanhSachBienLai()
    {
        Console.Write("Nhap so luong ho su dung dien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin bien lai thu {i + 1}:");
            BienLai bienLai = new BienLai();
            bienLai.NhapThongTin();
            danhSachBienLai.Add(bienLai);
            Console.WriteLine("-------------------");
        }
    }

    public void HienThiDanhSachBienLai()
    {
        if (danhSachBienLai.Count == 0)
        {
            Console.WriteLine("Danh sach bien lai trong!");
            return;
        }

        Console.WriteLine("Danh sach tat ca bien lai:");
        for (int i = 0; i < danhSachBienLai.Count; i++)
        {
            Console.WriteLine($"Bien lai thu {i + 1}:");
            danhSachBienLai[i].HienThiThongTin();
            Console.WriteLine("===================");
        }
    }
}
