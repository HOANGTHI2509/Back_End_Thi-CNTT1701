using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SoPhuc
{
    private double phanThuc;
    private double phanAo;

    // Hàm tạo không đối số
    public SoPhuc()
    {
        this.phanThuc = 0;
        this.phanAo = 0;
    }

    // Hàm tạo có đối số
    public SoPhuc(double phanThuc, double phanAo)
    {
        this.phanThuc = phanThuc;
        this.phanAo = phanAo;
    }

    // Phương thức nhập số phức
    public void NhapSoPhuc()
    {
        Console.Write("Nhap phan thuc: ");
        phanThuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        phanAo = double.Parse(Console.ReadLine());
    }

    // Phương thức hiển thị số phức
    public void HienThiSoPhuc()
    {
        if (phanAo >= 0)
            Console.WriteLine($"{phanThuc} + {phanAo}i");
        else
            Console.WriteLine($"{phanThuc} - {Math.Abs(phanAo)}i");
    }

    // Phương thức cộng hai số phức
    public SoPhuc Cong(SoPhuc sp)
    {
        double thuc = this.phanThuc + sp.phanThuc;
        double ao = this.phanAo + sp.phanAo;
        return new SoPhuc(thuc, ao);
    }

    // Phương thức trừ hai số phức
    public SoPhuc Tru(SoPhuc sp)
    {
        double thuc = this.phanThuc - sp.phanThuc;
        double ao = this.phanAo - sp.phanAo;
        return new SoPhuc(thuc, ao);
    }

    // Phương thức nhân hai số phức
    public SoPhuc Nhan(SoPhuc sp)
    {
        // (a + bi)(c + di) = (ac - bd) + (ad + bc)i
        double thuc = this.phanThuc * sp.phanThuc - this.phanAo * sp.phanAo;
        double ao = this.phanThuc * sp.phanAo + this.phanAo * sp.phanThuc;
        return new SoPhuc(thuc, ao);
    }

    // Phương thức chia hai số phức
    public SoPhuc Chia(SoPhuc sp)
    {
        // (a + bi)/(c + di) = [(a + bi)(c - di)]/(c^2 + d^2)
        double mauSo = sp.phanThuc * sp.phanThuc + sp.phanAo * sp.phanAo;
        if (mauSo == 0)
        {
            throw new DivideByZeroException("Khong the chia cho so phuc bang 0!");
        }

        double thuc = (this.phanThuc * sp.phanThuc + this.phanAo * sp.phanAo) / mauSo;
        double ao = (this.phanAo * sp.phanThuc - this.phanThuc * sp.phanAo) / mauSo;
        return new SoPhuc(thuc, ao);
    }
}
