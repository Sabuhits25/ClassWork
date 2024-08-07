using ClassWork.Models.ConsoleAppWithEFCore.Models;
using ConsoleAppWithEFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassWork.Services
{
    public class ProductService
    {
        private Product products;

        public async Task CreateAsync(Product student)
        {
            AppDbContext context = new AppDbContext();
            await context.Product.AddAsync(products);
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

    }
}
