
Console.OutputEncoding = System.Text.Encoding.UTF8;

int x;
Console.Write("Nhập số nguyên x: ");
try
{
    x = int.Parse(Console.ReadLine());
    if (x % 2 == 0)
    {
        Console.WriteLine("Số chẵn");
    }
    else
    {
        Console.WriteLine("Số lẻ");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Lỗi: " + ex.Message);
}
 