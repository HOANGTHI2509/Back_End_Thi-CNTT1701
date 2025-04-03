//Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và 
//chiều rộng.

Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
double chieuDai, chieuRong, dienTich;
//Nhập dữ liệu từ bàn phím
Console.Write("Nhập chiều dài của hình chữ nhật: ");
chieuDai = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập chiều rộng của hình chữ nhật: ");
chieuRong = double.Parse(Console.ReadLine() ?? "0");
//Tính diện tích
dienTich = chieuDai * chieuRong;
Console.WriteLine($"Diện tích của hình chữ nhật là: {dienTich}");



