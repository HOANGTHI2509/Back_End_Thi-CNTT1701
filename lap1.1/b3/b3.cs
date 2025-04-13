//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F 
//Công thức: F = (C * 9 / 5) + 32
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet

double doC, doF;
//Nhập dữ liệu từ bàn phím
Console.Write("Nhập nhiệt độ theo độ C cần chuyển đổi:");
doC = double.Parse(Console.ReadLine() ?? "0");
//Tính nhiệt độ theo độ F (công thức tính)
doF = (doC * 9 / 5) + 32;
Console.WriteLine($"Nhiệt độ theo độ F là: {doF}" + " độ F");
