//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn 
//hay không.
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
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