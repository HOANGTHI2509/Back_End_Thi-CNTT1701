using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VanBan
{
    private string st;

    // Hàm tạo không đối số
    public VanBan()
    {
        this.st = "";
    }

    // Hàm tạo có đối số
    public VanBan(string st)
    {
        this.st = st;
    }

    // Phương thức đếm số từ
    public int DemSoTu()
    {
        if (string.IsNullOrEmpty(st))
            return 0;

        // Chuẩn hóa xâu trước khi đếm
        string temp = st.Trim();
        if (temp == "")
            return 0;

        // Tách xâu thành mảng các từ, bỏ qua các khoảng trắng thừa
        string[] words = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // Phương thức đếm số ký tự H (không phân biệt hoa/thường)
    public int DemKyTuH()
    {
        if (string.IsNullOrEmpty(st))
            return 0;

        int count = 0;
        foreach (char c in st.ToLower())
        {
            if (c == 'h')
                count++;
        }
        return count;
    }

    // Phương thức chuẩn hóa xâu
    public void ChuanHoa()
    {
        if (string.IsNullOrEmpty(st))
        {
            st = "";
            return;
        }

        // Loại bỏ khoảng trắng thừa ở đầu và cuối, thay thế nhiều khoảng trắng giữa các từ bằng 1 khoảng trắng
        st = st.Trim();
        while (st.Contains("  "))
        {
            st = st.Replace("  ", " ");
        }
    }

    // Phương thức nhập xâu
    public void NhapXau()
    {
        Console.Write("Nhap xau ky tu: ");
        st = Console.ReadLine();
    }

    // Phương thức hiển thị xâu
    public void HienThiXau()
    {
        Console.WriteLine("Xau hien tai: " + st);
    }
}
