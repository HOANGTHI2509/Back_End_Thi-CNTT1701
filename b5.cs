//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
double a, b, tong, tich;
//Nhập số
Console.Write("Nhập số a: ");
a = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập sô b: ");
b = double.Parse(Console.ReadLine() ?? "0");
// công thức tính
tong = a + b;
tich = a * b;
//In kết quả
Console.WriteLine($"Tổng là: {tong}");
Console.Write($"Tích là: {tich}");