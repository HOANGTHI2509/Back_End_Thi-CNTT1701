namespace BaiTapHinhHoc
{
    // Lớp TamGiac kế thừa từ lớp DaGiac
    public class TamGiac : DaGiac
    {
        /// <summary>
        /// Hàm khởi tạo của lớp TamGiac.
        /// </summary>
        /// <param name="dsCanh">Danh sách phải chứa đúng 3 cạnh.</param>
        // Sử dụng ": base(dsCanh)" để gọi hàm khởi tạo của lớp cha (DaGiac)
        public TamGiac(List<int> dsCanh) : base(dsCanh)
        {
            // Thêm kiểm tra ràng buộc riêng cho tam giác
            if (dsCanh.Count != 3)
            {
                throw new ArgumentException("Tam giác phải có đúng 3 cạnh.");
            }
        }

        /// <summary>
        /// Ghi đè phương thức tính chu vi từ lớp cha.
        /// </summary>
        public override int TinhChuVi()
        {
            Console.WriteLine("Đang gọi phương thức tính chu vi của lớp TamGiac...");
            return base.TinhChuVi(); // Gọi lại phương thức gốc của lớp cha
        }

        /// <summary>
        /// Tính diện tích tam giác bằng công thức Heron.
        /// </summary>
        /// <returns>Diện tích của tam giác, hoặc 0 nếu không hợp lệ.</returns>
        public double TinhDienTich()
        {
            int a = DsCanh[0];
            int b = DsCanh[1];
            int c = DsCanh[2];

            // Kiểm tra bất đẳng thức tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (double)TinhChuVi() / 2; // Nửa chu vi
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return 0;
        }

        /// <summary>
        /// Kiểm tra tam giác có thỏa mãn định lý Pytago (là tam giác vuông).
        /// </summary>
        /// <returns>True nếu là tam giác vuông, ngược lại là False.</returns>
        public bool KiemTraPitago()
        {
            // Sắp xếp các cạnh để tìm cạnh huyền (cạnh dài nhất)
            var canhSapXep = DsCanh.OrderBy(x => x).ToList();
            int a = canhSapXep[0];
            int b = canhSapXep[1];
            int c = canhSapXep[2]; // Cạnh huyền

            // Vì các cạnh là số nguyên, ta có thể so sánh trực tiếp
            return (a * a) + (b * b) == (c * c);
        }
    }
}