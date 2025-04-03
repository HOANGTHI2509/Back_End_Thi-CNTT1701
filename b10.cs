//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không. 
// Số nguyên tố là số lớn hơn 1 và chỉ chia hết cho 1 và chính nó.
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int? so;
Console.Write("Nhập một số bất kì: ");
try
{
    so = int.Parse(Console.ReadLine() ?? "0");
    if (so < 2)
    {
        Console.WriteLine("Đây không phải là số nguyên tố!");
    }
    else
    {
        bool laSoNguyenTo = true;
        for (int i = 2; i <= Math.Sqrt(so.Value); i++)
        {
            if (so % i == 0)
            {
                laSoNguyenTo = false;
                break;
            }
        }
        if (laSoNguyenTo)
        {
            Console.WriteLine("Đây là số nguyên tố!");
        }
        else
        {
            Console.WriteLine("Đây không phải là số nguyên tố");
        }
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
}