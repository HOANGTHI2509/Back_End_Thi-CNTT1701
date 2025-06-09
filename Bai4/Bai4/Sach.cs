using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Sach : TaiLieu
    {
        private string? tenTG;
        private int soTrang;
        //Phương thức khởi tạo mặc định
        public Sach() { }
        //Phương thức khởi tạo có tham số
        public Sach(string maTL, string tenNXB, int soBanPhatHanh,
            string tenTG, int soTrang) : base(maTL, tenNXB, soBanPhatHanh)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;

        }
        //Phương thức nhập thông tin sách
        public override void Nhap()
        {
            Console.Write("+ Tên tác giả:");
            tenTG = Console.ReadLine();
            Console.Write("+ số trang: ");
            soTrang = int.Parse(Console.ReadLine() ?? "0");
        }
        //Phương thức hiển thị thông tin sách
        public overide void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ tên tác giả: {tenTG}");
            Console.WriteLine($"+ số trang: {soTrang}");
        }
    }

}
