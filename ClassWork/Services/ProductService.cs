using ClassWork.Models.ConsoleAppWithEFCore.Models;
using ClassWork.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassWork.Services
{
    public class ProductService
    {
        private Product products;

        public async Task CreateAsync(Product product)
        {
            AppDbContext context = new AppDbContext();
            await context.Product.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            AppDbContext context = new AppDbContext();

            var students = await context.Product.Include(s => s.Category).AsNoTracking().ToListAsync();
            return students;
        }

        public async Task<Product> GetById(int id)
        {
            AppDbContext context = new AppDbContext();
            var student = await context.Product.FindAsync(id);
            return student;
        }


        public async Task DeleteAsync(int id)
        {
            AppDbContext contexts = new AppDbContext();
            var category = await contexts.Product.FindAsync(id);
            if (category != null)
            {
                contexts.Product.Remove(products);
                await contexts.SaveChangesAsync();
            }
        }
    }
}
