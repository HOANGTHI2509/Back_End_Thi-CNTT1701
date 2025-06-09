// Controllers/ProductController.cs
using Microsoft.AspNetCore.Mvc;
using ProductDisplayApp.Models; // Đảm bảo đúng namespace của Model Product

public class ProductController : Controller
{
    // Action Details will display information about a product  
    // URL access will be /Product/Details or /Product/Details/{id} (if id is provided)  
    public IActionResult Details()
    {
        // 1. Create a mock Product object  
        // In a real application, you would retrieve data from a database  
        var product = new Product
        {
            Id = 101,
            Name = "Laptop Gaming XYZ Pro",
            Price = 25500000.00M // 'M' specifies this is a decimal type  
        };

        // 2. Pass this Product object to the View  
        return View(product);
    }
}
