//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10. 
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int? so;
Console.Write("Nhập một số bất kì để in ra bảng cửu chương đó: ");
try
{
    so = int.Parse(Console.ReadLine() ?? "0");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{so} x {i} = {so * i}");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}