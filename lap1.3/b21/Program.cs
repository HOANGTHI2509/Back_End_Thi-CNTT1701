using System;
using System.Collections.Generic;
using System.Linq; // Cần dùng cho các thao tác với danh sách như Where, OrderBy

public class Program
{
    public static void Main(string[] args)
    {
        List<HocSinh> danhSachHocSinh = new List<HocSinh>();
        int luaChon;

        do
        {
            Console.WriteLine("\n--- MENU QUẢN LÝ HỌC SINH ---");
            Console.WriteLine("1. Nhập thông tin N học sinh");
            Console.WriteLine("2. Hiển thị thông tin học sinh nam có điểm Kĩ thuật >= 8");
            Console.WriteLine("3. In số liệu học sinh nam trước, rồi đến học sinh nữ");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập một số.");
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    NhapDanhSachHocSinh(danhSachHocSinh);
                    break;
                case 2:
                    HienThiHocSinhNamDiemKiThuatCao(danhSachHocSinh);
                    break;
                case 3:
                    InDanhSachTheoGioiTinh(danhSachHocSinh);
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

    // Phương thức nhập thông tin N học sinh
    public static void NhapDanhSachHocSinh(List<HocSinh> danhSach)
    {
        Console.Write("Nhập số lượng học sinh muốn thêm: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Số lượng không hợp lệ. Vui lòng nhập số nguyên dương: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin học sinh thứ {i + 1} ---");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Giới tính (Nam/Nu): ");
            string gioiTinhStr = Console.ReadLine();
            bool laNam = gioiTinhStr.ToLower() == "nam";

            Console.Write("Điểm Toán: ");
            double diemToan = NhapDiem("Toán");
            Console.Write("Điểm Lý: ");
            double diemLy = NhapDiem("Lý");
            Console.Write("Điểm Hóa: ");
            double diemHoa = NhapDiem("Hóa");

            if (laNam)
            {
                Console.Write("Điểm Kĩ thuật: ");
                double diemKiThuat = NhapDiem("Kĩ thuật");
                danhSach.Add(new HocSinhNam(hoTen, diemToan, diemLy, diemHoa, diemKiThuat));
            }
            else
            {
                Console.Write("Điểm Nữ công: ");
                double diemNuCong = NhapDiem("Nữ công");
                danhSach.Add(new HocSinhNu(hoTen, diemToan, diemLy, diemHoa, diemNuCong));
            }
            Console.WriteLine("Đã thêm học sinh thành công!");
        }
    }

    // Hàm hỗ trợ nhập điểm hợp lệ
    public static double NhapDiem(string monHoc)
    {
        double diem;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out diem) && diem >= 0 && diem <= 10)
            {
                return diem;
            }
            else
            {
                Console.Write($"Điểm {monHoc} không hợp lệ (0-10). Vui lòng nhập lại: ");
            }
        }
    }    // Add the missing method 'InDanhSachTheoGioiTinh' to resolve the CS0103 error.

    public static void InDanhSachTheoGioiTinh(List<HocSinh> danhSach)
    {
        Console.WriteLine("\n--- Danh sách học sinh nam ---");
        foreach (var hocSinh in danhSach.Where(hs => hs.GioiTinhNam))
        {
            hocSinh.InThongTin();
        }

        Console.WriteLine("\n--- Danh sách học sinh nữ ---");
        foreach (var hocSinh in danhSach.Where(hs => !hs.GioiTinhNam))
        {
            hocSinh.InThongTin();
        }
    }
