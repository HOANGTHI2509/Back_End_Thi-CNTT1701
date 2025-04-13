////?? là toán tử null-coalescing, nếu biến bên trái là null thì sẽ trả về giá trị bên phải
//int? x = null;
//int y = x ?? 100; // nếu x là null thì y sẽ nhận giá trị 100
//Console.WriteLine(y); // 100

Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
//Khai báo biến
string? ten;
int tuoi;
//Nhập dữ liệu từ bàn phím
Console.Write("Nhap ten của ban:");
ten = Console.ReadLine();
Console.Write("Nhập tuổi của bạn: ");
tuoi = int.Parse(Console.ReadLine() ?? "0");
//Xuất ra màn hình
//Console.WritedLine("Xin Chào "+ten + ", bạn "+tuoi+" tuổi");
Console.Write($"Xin chào {ten}, bạn {tuoi} tuổi"); // chuỗi nội suy