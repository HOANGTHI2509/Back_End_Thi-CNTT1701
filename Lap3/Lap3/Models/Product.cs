using System.ComponentModel.DataAnnotations; // Để sử dụng Data Annotations (tùy chọn nhưng nên dùng)

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tên sản phẩm không được để trống.")]
    [StringLength(100, ErrorMessage = "Tên sản phẩm không quá 100 ký tự.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Giá sản phẩm không được để trống.")]
    [Range(0.01, 1000000000.00, ErrorMessage = "Giá sản phẩm phải lớn hơn 0.")]
    [DataType(DataType.Currency)] // Gợi ý định dạng tiền tệ cho UI
    public decimal Price { get; set; }
}