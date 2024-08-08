using ClassWork.Models;
using ClassWork.Models.ConsoleAppWithEFCore.Models;
using ClassWork.Services;

namespace ClassWork
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var categoryService = new CategoryService();
            var productService = new ProductService();

           
            var newCategory = new Category { Name = "Electronics" };
            await categoryService.CreateAsync(newCategory);
            Console.WriteLine("New category created.");

            
            var newProduct = new Product { Name = "Smartphone", CategoryId = newCategory.Id };
            await productService.CreateAsync(newProduct);
            Console.WriteLine("New product created.");

           
            var categories = await categoryService.GetAllAsync();
            Console.WriteLine("All categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"Category Id: {category.Id}, Name: {category.Name}");
            }

           
            var products = await productService.GetAllAsync();
            Console.WriteLine("All products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Category Id: {product.CategoryId}");
            }

           
            var productById = await productService.GetById(newProduct.Id);
            Console.WriteLine($"Product retrieved by Id: Id: {productById.Id}, Name: {productById.Name}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
