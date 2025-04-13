//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím. 
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int a, b;
Console.Write("Nhập số nguyên a: ");
a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập số nguyên b: ");
b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
static void HoanVi(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
HoanVi(ref a, ref b);
Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

