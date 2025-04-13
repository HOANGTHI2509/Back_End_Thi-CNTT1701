//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số 
//không.
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int? so;
Console.Write("Nhập một số bất kì: ");
try
{
    so = int.Parse(Console.ReadLine() ?? "0");
    if (so >= 0)
    {
        Console.WriteLine("Đây là số dương!");
    }
    else
    {
        Console.WriteLine("đây là số dương");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}