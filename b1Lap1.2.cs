//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng. 
Console.OutputEncoding = System.Text.Encoding.UTF8; // lenh go tieng viet
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;
foreach (int num in arr)
{
    if (num % 2 == 0)
    {
        sum += num;
    }
}
Console.WriteLine("Tổng các số chẵn trong mảng là: " + sum);
