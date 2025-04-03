//Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không. 
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 
//400).
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet

int? nam;
Console.Write("Nhập một năm bất kì: ");
try
{
    nam = int.Parse(Console.ReadLine() ?? "0");
    if (nam % 4 == 0 && (nam % 100 != 0 || nam % 400 == 0))
    {
        Console.WriteLine("Đây là năm nhuận!");
    }
    else
    {
        Console.WriteLine("Đây không phải là năm nhuận");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}