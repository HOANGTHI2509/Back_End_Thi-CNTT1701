using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaTran
{
    private int soDong;
    private int soCot;
    private double[,] phanTu;

    // Hàm tạo không đối số
    public MaTran()
    {
        this.soDong = 0;
        this.soCot = 0;
        this.phanTu = null;
    }

    // Hàm tạo có đối số
    public MaTran(int n, int m)
    {
        this.soDong = n;
        this.soCot = m;
        this.phanTu = new double[n, m];
    }

    // Phương thức nhập ma trận
    public void NhapMaTran()
    {
        Console.Write("Nhap so dong: ");
        soDong = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: ");
        soCot = int.Parse(Console.ReadLine());

        phanTu = new double[soDong, soCot];
        Console.WriteLine("Nhap cac phan tu cua ma tran:");
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                Console.Write($"Phan tu [{i},{j}]: ");
                phanTu[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    // Phương thức hiển thị ma trận
    public void HienThiMaTran()
    {
        if (phanTu == null)
        {
            Console.WriteLine("Ma tran rong!");
            return;
        }

        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                Console.Write(phanTu[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Phương thức cộng hai ma trận
    public MaTran Cong(MaTran mt)
    {
        if (this.soDong != mt.soDong || this.soCot != mt.soCot)
        {
            throw new Exception("Hai ma tran khong cung cap, khong the cong!");
        }

        MaTran ketQua = new MaTran(this.soDong, this.soCot);
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                ketQua.phanTu[i, j] = this.phanTu[i, j] + mt.phanTu[i, j];
            }
        }
        return ketQua;
    }

    // Phương thức trừ hai ma trận
    public MaTran Tru(MaTran mt)
    {
        if (this.soDong != mt.soDong || this.soCot != mt.soCot)
        {
            throw new Exception("Hai ma tran khong cung cap, khong the tru!");
        }

        MaTran ketQua = new MaTran(this.soDong, this.soCot);
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                ketQua.phanTu[i, j] = this.phanTu[i, j] - mt.phanTu[i, j];
            }
        }
        return ketQua;
    }

    // Phương thức nhân hai ma trận
    public MaTran Nhan(MaTran mt)
    {
        if (this.soCot != mt.soDong)
        {
            throw new Exception("So cot cua ma tran thu nhat phai bang so dong cua ma tran thu hai!");
        }

        MaTran ketQua = new MaTran(this.soDong, mt.soCot);
        for (int i = 0; i < this.soDong; i++)
        {
            for (int j = 0; j < mt.soCot; j++)
            {
                ketQua.phanTu[i, j] = 0;
                for (int k = 0; k < this.soCot; k++)
                {
                    ketQua.phanTu[i, j] += this.phanTu[i, k] * mt.phanTu[k, j];
                }
            }
        }
        return ketQua;
    }

    // Phương thức chia hai ma trận (chia từng phần tử)
    public MaTran Chia(MaTran mt)
    {
        if (this.soDong != mt.soDong || this.soCot != mt.soCot)
        {
            throw new Exception("Hai ma tran khong cung cap, khong the chia!");
        }

        MaTran ketQua = new MaTran(this.soDong, this.soCot);
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                if (mt.phanTu[i, j] == 0)
                {
                    throw new DivideByZeroException("Phan tu cua ma tran thu hai bang 0, khong the chia!");
                }
                ketQua.phanTu[i, j] = this.phanTu[i, j] / mt.phanTu[i, j];
            }
        }
        return ketQua;
    }
}
