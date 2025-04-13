//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên. 

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
int max1 = int.MinValue;
int max2 = int.MinValue;
foreach (int i in arr)
{
    if (i > max1)
    {
        max2 = max1;
        max1 = i;
    }
    else if (i > max2 && i != max1)
    {
        max2 = i;
    }
}
if (max2 == int.MinValue)
{
    Console.WriteLine("Không có số lớn thứ hai trong mảng.");
}
else
{
    Console.WriteLine($"Số lớn thứ hai trong mảng là: {max2}");
}