// Program.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTapHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ hiển thị tiếng Việt

            var danhSachTamGiac = new List<TamGiac>();
            int n = 0;

            // ---- Nhập số lượng tam giác (có xử lý lỗi) ----
            while (true)
            {
                Console.Write("Nhập số lượng tam giác: ");
                // TryParse sẽ an toàn hơn Parse, không gây exception nếu nhập sai
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break; // Thoát vòng lặp nếu nhập số nguyên dương thành công
                }
                Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập một số nguyên dương.");
            }

            // ---- Vòng lặp nhập dữ liệu cho n tam giác ----
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"\n--- Nhập thông tin cho tam giác thứ {i + 1} ---");
                        Console.Write("Nhập 3 cạnh của tam giác (cách nhau bởi dấu cách): ");

                        // Đọc chuỗi, cắt theo dấu cách, chuyển từng phần thành số nguyên và tạo List
                        List<int> canh = Console.ReadLine()
                                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToList();

                        // Tạo đối tượng tam giác (có thể ném ra exception nếu không đủ 3 cạnh)
                        var tg = new TamGiac(canh);

                        // Kiểm tra bất đẳng thức tam giác thông qua diện tích
                        if (tg.TinhDienTich() > 0)
                        {
                            danhSachTamGiac.Add(tg);
                            break; // Nhập thành công, chuyển sang tam giác tiếp theo
                        }
                        else
                        {
                            Console.WriteLine("Lỗi: Ba cạnh vừa nhập không tạo thành một tam giác. Vui lòng nhập lại.");
                        }
                    }
                    catch (FormatException) // Lỗi khi người dùng nhập chữ thay vì số
                    {
                        Console.WriteLine("Lỗi: Định dạng cạnh không hợp lệ. Vui lòng nhập 3 số nguyên.");
                    }
                    catch (Exception ex) // Bắt các lỗi khác, ví dụ như không nhập đủ 3 cạnh
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            // ---- In kết quả ----
            Console.WriteLine("\n==============================================");
            Console.WriteLine("Các tam giác thỏa mãn định lý Pitago là:");
            Console.WriteLine("==============================================");

            // Lọc danh sách các tam giác thỏa mãn điều kiện và lấy ra
            var dsPitago = danhSachTamGiac.Where(tg => tg.KiemTraPitago()).ToList();

            if (dsPitago.Any()) // Kiểm tra xem danh sách kết quả có phần tử nào không
            {
                foreach (var tg in dsPitago)
                {
                    tg.InCanh();
                }
            }
            else
            {
                Console.WriteLine("Không có tam giác nào trong danh sách thỏa mãn định lý Pitago.");
            }
        }
    }
}