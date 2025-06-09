using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System; // Để sử dụng DateTime

public class TodoController : Controller
{
    // Giả lập cơ sở dữ liệu với một danh sách tĩnh
    private static List<TodoItem> _todoItems = new List<TodoItem>
    {
        new TodoItem { Id = 1, Title = "Học C#", IsCompleted = false, DueDate = DateTime.Parse("2025-06-15") },
        new TodoItem { Id = 2, Title = "Làm bài tập ASP.NET", IsCompleted = true, DueDate = DateTime.Parse("2025-06-08") },
        new TodoItem { Id = 3, Title = "Viết code cho dự án mới", IsCompleted = false, DueDate = DateTime.Parse("2025-06-30") }
    };
    private static int _nextId = 4; // ID tiếp theo cho việc thêm mới

    // GET: /Todo/Index
    public IActionResult Index()
    {
        return View(_todoItems);
    }

    // --- BỔ SUNG: ACTION ADD ---

    // GET: /Todo/Add
    // Hiển thị form để thêm một TodoItem mới
    public IActionResult Add()
    {
        return View(); // Trả về View Add.cshtml
    }

    // POST: /Todo/Add
    // Xử lý dữ liệu được gửi từ form thêm mới
    [HttpPost]
    [ValidateAntiForgeryToken] // Bảo vệ chống lại tấn công CSRF
    public IActionResult Add(TodoItem todoItem)
    {
        // Kiểm tra xem dữ liệu từ form có hợp lệ theo Model không (Data Annotations)
        if (ModelState.IsValid)
        {
            todoItem.Id = _nextId++; // Gán ID mới
            _todoItems.Add(todoItem); // Thêm vào danh sách giả lập
            return RedirectToAction(nameof(Index)); // Chuyển hướng về trang Index sau khi thêm thành công
        }
        // Nếu dữ liệu không hợp lệ, hiển thị lại form với các lỗi
        return View(todoItem);
    }

    // --- BỔ SUNG: ACTION EDIT ---

    // GET: /Todo/Edit/5
    // Hiển thị form để chỉnh sửa một TodoItem dựa trên Id
    public IActionResult Edit(int? id) // int? cho phép Id là null
    {
        if (id == null)
        {
            return NotFound(); // Trả về lỗi 404 nếu không có Id
        }

        var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
        if (todoItem == null)
        {
            return NotFound(); // Trả về lỗi 404 nếu không tìm thấy TodoItem
        }
        return View(todoItem); // Trả về View Edit.cshtml với dữ liệu của TodoItem
    }

    // POST: /Todo/Edit/5
    // Xử lý dữ liệu được gửi từ form chỉnh sửa
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, TodoItem todoItem)
    {
        // Kiểm tra Id trong URL có khớp với Id của đối tượng gửi lên không
        if (id != todoItem.Id)
        {
            return NotFound();
        }

        // Kiểm tra xem dữ liệu từ form có hợp lệ theo Model không
        if (ModelState.IsValid)
        {
            var existingTodoItem = _todoItems.FirstOrDefault(t => t.Id == id);
            if (existingTodoItem == null)
            {
                return NotFound();
            }

            // Cập nhật thông tin của TodoItem hiện có
            existingTodoItem.Title = todoItem.Title;
            existingTodoItem.IsCompleted = todoItem.IsCompleted;
            existingTodoItem.DueDate = todoItem.DueDate;

            return RedirectToAction(nameof(Index)); // Chuyển hướng về trang Index sau khi chỉnh sửa thành công
        }
        // Nếu dữ liệu không hợp lệ, hiển thị lại form với các lỗi
        return View(todoItem);
    }

    // (Tùy chọn) Action Delete để xóa một TodoItem
    // GET: /Todo/Delete/5
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
        if (todoItem == null)
        {
            return NotFound();
        }

        return View(todoItem); // Hiển thị trang xác nhận xóa
    }

    // POST: /Todo/Delete/5
    [HttpPost, ActionName("Delete")] // Đặt tên Action là "Delete" để phân biệt với GET Delete
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var todoItem = _todoItems.FirstOrDefault(t => t.Id == id);
        if (todoItem != null)
        {
            _todoItems.Remove(todoItem);
        }
        return RedirectToAction(nameof(Index));
    }
}