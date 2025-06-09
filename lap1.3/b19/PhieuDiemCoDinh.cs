using System;

public static class PhieuDiemCoDinh
{
    public static void DocVaInMotPhieuDiem()
    {
        Console.WriteLine("\n--- Đọc và In thông tin từ một phiếu điểm cụ thể ---");

        // Tạo một đối tượng THISINH mẫu với dữ liệu cố định
        HoTen hoTenMau = new HoTen("Trần", "Văn", "Bình");
        QueQuan queQuanMau = new QueQuan("Thị trấn Vĩnh Tường", "Huyện Vĩnh Tường", "Tỉnh Vĩnh Phúc");
        DiemThi diemThiMau = new DiemThi(7.0, 8.75, 6.5); // Điểm chính xác đến 1/4

        THISINH thiSinhMau = new THISINH(hoTenMau, queQuanMau, "THPT Chuyên Vĩnh Phúc", 17, "VP05678", diemThiMau);

        Console.WriteLine("Thông tin thí sinh mẫu:");
        thiSinhMau.InThongTinChiTiet();
    }
}