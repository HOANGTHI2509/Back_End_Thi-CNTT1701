//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập 
//từ bàn phím.
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
int soDuong = 0;
int soAm = 0;
foreach (int i in arr)
{
    if (i > 0)
    {
        soDuong++;
    }
    else if (i < 0)
    {
        soAm++;
    }
}
Console.WriteLine($"Số lượng số dương trong mảng: {soDuong}");
Console.WriteLine($"Số lượng số âm trong mảng: {soAm}");

