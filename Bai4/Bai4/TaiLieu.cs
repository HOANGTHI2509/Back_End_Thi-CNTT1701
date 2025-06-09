using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class TaiLieu
    {
        //khai báo các thuộc tính
        protected string? maTL;
        protected string? tenNXB;
        protected int soBanPhatHanh;
        // Phương thức khởi tạo mặc định
        public TaiLieu()
        {
            
        }
        //Phương thức khởi tạo có tham số
        public TaiLieu(string maTL, string tenNXB, int soBanPhatHanh)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBanPhatHanh = soBanPhatHanh;
        }
        //Phương thức nhập thông tin tài liệu
        public virtual void Nhap()
        {
            Console.Write("Nhập mã tài liệu: ");
            maTL = Console.ReadLine();
            Console.Write("Nhập tên nhà xuất bản: ");
            tenNXB = Console.ReadLine();
            Console.Write("Nhập số bản: ");
            soBanPhatHanh = int.Parse(Console.ReadLine() ?? "0");
        }
        //Phương thức hiển thị thông tin tài liệu
        public virtual void Xuat()
        {
            Console.WriteLine($"+ Mã tài Liệu: {maTL}");
            Console.WriteLine($"+ Tên nhà xuất bản: {tenNXB}");
            Console.WriteLine($"+ Số bản phát hành: {soBanPhatHanh}");
        }
    }
}
