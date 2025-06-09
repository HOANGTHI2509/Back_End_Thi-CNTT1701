// Models/TodoItem.cs
using System;
using System.ComponentModel.DataAnnotations; // Để dùng Data Annotations cho Validation

public class TodoItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tiêu đề không được để trống.")]
    [StringLength(100, ErrorMessage = "Tiêu đề không quá 100 ký tự.")]
    public string Title { get; set; }

    public bool IsCompleted { get; set; } = false;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DueDate { get; set; } = DateTime.Now.AddDays(7); // Mặc định là 7 ngày kể từ hôm nay
}