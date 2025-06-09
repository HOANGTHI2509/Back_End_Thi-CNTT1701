// DaGiac.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTapHinhHoc
{
    public class DaGiac
    {
        // Thuộc tính: Danh sách các cạnh, chỉ có thể được gán trong lớp này hoặc lớp con
        public List<int> DsCanh { get; protected set; }

        // Thuộc tính: Số cạnh được tính tự động từ danh sách cạnh
        public int SoCanh => DsCanh.Count;

        /// <summary>
        /// Hàm khởi tạo của lớp DaGiac
        /// </summary>
        /// <param name="dsCanh">Một danh sách chứa độ dài các cạnh</param>
        public DaGiac(List<int> dsCanh)
        {
            DsCanh = dsCanh;
        }

        /// <summary>
        /// Tính chu vi của đa giác.
        /// Được đánh dấu là "virtual" để các lớp con có thể ghi đè (override).
        /// </summary>
        /// <returns>Tổng độ dài các cạnh</returns>
        public virtual int TinhChuVi()
        {
            // Sử dụng LINQ để tính tổng các phần tử trong danh sách
            return DsCanh.Sum();
        }

        /// <summary>
        /// In giá trị các cạnh ra màn hình console.
        /// </summary>
        public void InCanh()
        {
            // Nối các phần tử của danh sách thành một chuỗi, phân tách bởi dấu phẩy
            Console.WriteLine($"Giá trị các cạnh: [{string.Join(", ", DsCanh)}]");
        }
    }
}