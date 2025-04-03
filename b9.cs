//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n. 
// Giai thừa của n là tích của tất cả các số nguyên dương từ 1 đến n.
// Ví dụ: 5! = 5 * 4 * 3 * 2 * 1 = 120
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int? n;
Console.Write("Nhập một số nguyên dương n: ");
try
{
    n = int.Parse(Console.ReadLine() ?? "0");
    if (n < 0)
    {
        Console.WriteLine("Giai thừa không xác định cho số âm.");
    }
    else
    {
        long giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}