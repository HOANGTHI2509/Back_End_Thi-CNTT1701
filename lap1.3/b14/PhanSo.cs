using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PhanSo
{
    private int tuSo;
    private int mauSo;

    // Hàm tạo không đối số
    public PhanSo()
    {
        this.tuSo = 0;
        this.mauSo = 1;
    }

    // Hàm tạo có đối số
    public PhanSo(int tu, int mau)
    {
        if (mau == 0)
            throw new ArgumentException("Mau so khong the bang 0!");
        this.tuSo = tu;
        this.mauSo = mau;
    }

    // Phương thức nhập phân số
    public void NhapPhanSo()
    {
        Console.Write("Nhap tu so: ");
        tuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        mauSo = int.Parse(Console.ReadLine());
        if (mauSo == 0)
            throw new ArgumentException("Mau so khong the bang 0!");
    }

    // Phương thức hiển thị phân số
    public void HienThiPhanSo()
    {
        Console.WriteLine($"{tuSo}/{mauSo}");
    }

    // Phương thức tìm UCLN (ước chung lớn nhất) để rút gọn
    private int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Phương thức rút gọn phân số
    public void RutGon()
    {
        int ucln = UCLN(tuSo, mauSo);
        tuSo /= ucln;
        mauSo /= ucln;
        if (mauSo < 0) // Đảm bảo mẫu số luôn dương
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
    }

    // Phương thức cộng hai phân số
    public PhanSo Cong(PhanSo ps)
    {
        int tu = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo ketQua = new PhanSo(tu, mau);
        ketQua.RutGon();
        return ketQua;
    }

    // Phương thức trừ hai phân số
    public PhanSo Tru(PhanSo ps)
    {
        int tu = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo ketQua = new PhanSo(tu, mau);
        ketQua.RutGon();
        return ketQua;
    }

    // Phương thức nhân hai phân số
    public PhanSo Nhan(PhanSo ps)
    {
        int tu = this.tuSo * ps.tuSo;
        int mau = this.mauSo * ps.mauSo;
        PhanSo ketQua = new PhanSo(tu, mau);
        ketQua.RutGon();
        return ketQua;
    }

    // Phương thức chia hai phân số
    public PhanSo Chia(PhanSo ps)
    {
        if (ps.tuSo == 0)
            throw new DivideByZeroException("Khong the chia cho phan so bang 0!");
        int tu = this.tuSo * ps.mauSo;
        int mau = this.mauSo * ps.tuSo;
        PhanSo ketQua = new PhanSo(tu, mau);
        ketQua.RutGon();
        return ketQua;
    }
}
