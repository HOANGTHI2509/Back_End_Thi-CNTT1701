/*Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm 
tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử 
là số nguyên tố trong mảng. */

Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int n;
Console.Write("Nhập số phần tử của mảng: ");
n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine() ?? "0");
}
Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");

