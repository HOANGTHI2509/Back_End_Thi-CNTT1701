//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
static void SapXep(float[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                float temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int n;
Console.Write("Nhập số phần tử của mảng: ");
n = int.Parse(Console.ReadLine() ?? "0");
float[] arr = new float[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i + 1}: ");
    arr[i] = float.Parse(Console.ReadLine() ?? "0");
}
Console.WriteLine("Mảng trước khi sắp xếp:");
foreach (float i in arr)
{
    Console.Write(i + " ");
}
Console.WriteLine();
SapXep(arr);
Console.WriteLine("Mảng sau khi sắp xếp theo chiều tăng dần:");
foreach (float i in arr)
{
    Console.Write(i + " ");
}
