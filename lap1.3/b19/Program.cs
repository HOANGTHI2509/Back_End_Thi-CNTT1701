using System;
using System.Collections.Generic;
using System.Linq; // Cần dùng cho các thao tác với danh sách như Where, OrderByDescending

public class Program
{
    public static void Main(string[] args)
    {
        List<THISINH> danhSachThiSinh = new List<THISINH>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU QUẢN LÝ THÍ SINH ---");
            Console.WriteLine("1. Xem thông tin một thí sinh mẫu");
            Console.WriteLine("2. Nhập thông tin N thí sinh");
            Console.WriteLine("3. Hiển thị tất cả thí sinh (dạng chi tiết)");
            Console.WriteLine("4. Tìm kiếm thí sinh có tổng điểm > 15");
            Console.WriteLine("5. Sắp xếp và hiển thị danh sách theo tổng điểm giảm dần");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            // Đảm bảo người dùng nhập số hợp lệ
            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập một số.");
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    PhieuDiemCoDinh.DocVaInMotPhieuDiem();
                    break;
                case 2:
                    NhapDanhSachThiSinh(danhSachThiSinh);
                    break;
                case 3:
                    HienThiDanhSachThiSinhChiTiet(danhSachThiSinh);
                    break;
                case 4:
                    TimThiSinhDiemCaoHon15(danhSachThiSinh);
                    break;
                case 5:
                    SapXepVaHienThiTheoTongDiem(danhSachThiSinh);
                    break;
                case 0:
                    Console.WriteLine("Đang thoát chương trình. Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không tồn tại. Vui lòng thử lại.");
                    break;
            }
        } while (luaChon != 0);
    }

    // Phương thức nhập thông tin N thí sinh từ bàn phím
    public static void NhapDanhSachThiSinh(List<THISINH> danhSach)
    {
        Console.Write("Nhập số lượng thí sinh muốn nhập: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Số lượng không hợp lệ. Vui lòng nhập số nguyên dương: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin thí sinh thứ {i + 1} ---");

            Console.Write("Họ: ");
            string ho = Console.ReadLine();
            Console.Write("Tên đệm: ");
            string tenDem = Console.ReadLine();
            Console.Write("Tên: ");
            string ten = Console.ReadLine();
            HoTen hoTen = new HoTen(ho, tenDem, ten);

            Console.Write("Xã: ");
            string xa = Console.ReadLine();
            Console.Write("Huyện: ");
            string huyen = Console.ReadLine();
            Console.Write("Tỉnh: ");
            string tinh = Console.ReadLine();
            QueQuan queQuan = new QueQuan(xa, huyen, tinh);

            Console.Write("Trường: ");
            string truong = Console.ReadLine();

            Console.Write("Tuổi: ");
            int tuoi;
            while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi < 0 || tuoi > 100) // Giới hạn tuổi hợp lý
            {
                Console.Write("Tuổi không hợp lệ. Vui lòng nhập số nguyên không âm và nhỏ hơn 100: ");
            }

            Console.Write("Số báo danh: ");
            string sbd = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            double diemToan;
            while (!double.TryParse(Console.ReadLine(), out diemToan) || diemToan < 0 || diemToan > 10)
            {
                Console.Write("Điểm Toán không hợp lệ (0-10). Nhập lại: ");
            }

            Console.Write("Điểm Lý: ");
            double diemLy;
            while (!double.TryParse(Console.ReadLine(), out diemLy) || diemLy < 0 || diemLy > 10)
            {
                Console.Write("Điểm Lý không hợp lệ (0-10). Nhập lại: ");
            }

            Console.Write("Điểm Hóa: ");
            double diemHoa;
            while (!double.TryParse(Console.ReadLine(), out diemHoa) || diemHoa < 0 || diemHoa > 10)
            {
                Console.Write("Điểm Hóa không hợp lệ (0-10). Nhập lại: ");
            }

            DiemThi diemThi = new DiemThi(diemToan, diemLy, diemHoa);

            THISINH thiSinh = new THISINH(hoTen, queQuan, truong, tuoi, sbd, diemThi);
            danhSach.Add(thiSinh);
            Console.WriteLine("Đã thêm thí sinh thành công!");
        }
    }

    // Phương thức hiển thị tất cả thí sinh với thông tin chi tiết (dùng để kiểm tra)
    public static void HienThiDanhSachThiSinhChiTiet(List<THISINH> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("\nDanh sách thí sinh rỗng.");
            return;
        }

        Console.WriteLine("\n--- DANH SÁCH TẤT CẢ THÍ SINH (CHI TIẾT) ---");
        foreach (var ts in danhSach)
        {
            ts.InThongTinChiTiet();
            Console.WriteLine("--------------------");
        }
    }

    // Phương thức chung để hiển thị danh sách thí sinh dưới dạng bảng
    public static void HienThiBangThongTin(List<THISINH> danhSach, string tieuDe)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine($"\n{tieuDe}");
            Console.WriteLine("Không có thí sinh nào trong danh sách.");
            return;
        }

        Console.WriteLine($"\n{tieuDe}");
        Console.WriteLine(new string('-', 90));
        Console.WriteLine(string.Format("| {0,-25} | {1,-25} | {2,-10} | {3,-5} | {4,-5} | {5,-5} |",
            "Họ tên", "Quê quán", "SBD", "Toán", "Lý", "Hóa"));
        Console.WriteLine(new string('-', 90));

        foreach (var ts in danhSach)
        {
            Console.WriteLine(string.Format("| {0,-25} | {1,-25} | {2,-10} | {3,-5:F2} | {4,-5:F2} | {5,-5:F2} |",
                ts.HoTen.ToString(),
                ts.QueQuan.ToString(),
                ts.SoBaoDanh,
                ts.DiemThi.Toan,
                ts.DiemThi.Ly,
                ts.DiemThi.Hoa));
        }
        Console.WriteLine(new string('-', 90));
    }

    // Tìm kiếm và in ra các thí sinh có tổng điểm ba môn lớn hơn 15
    public static void TimThiSinhDiemCaoHon15(List<THISINH> danhSach)
    {
        var thiSinhDiemCao = danhSach.Where(ts => ts.DiemThi.TongDiem > 15).ToList();
        HienThiBangThongTin(thiSinhDiemCao, "--- DANH SÁCH THÍ SINH CÓ TỔNG ĐIỂM > 15 ---");
    }

    // Sắp xếp lại danh sách theo tổng điểm ba môn giảm dần và in ra màn hình
    public static void SapXepVaHienThiTheoTongDiem(List<THISINH> danhSach)
    {
        // Sắp xếp danh sách theo tổng điểm giảm dần
        var danhSachSapXep = danhSach.OrderByDescending(ts => ts.DiemThi.TongDiem).ToList();
        HienThiBangThongTin(danhSachSapXep, "--- DANH SÁCH THÍ SINH SẮP XẾP THEO TỔNG ĐIỂM GIẢM DẦN ---");
    }
}