using ClassWork.Models;
using ClassWork.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Services
{
    public class CategoryService
    {
        public async Task CreateAsync (Category catogries)
        {
            AppDbContext context = new AppDbContext ();
            await context.Categories.AddAsync (catogries);
            await context.SaveChangesAsync ();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            AppDbContext context = new AppDbContext();
                var categories = await context.Categories.AsNoTracking().ToListAsync();
            return categories;
        }

        
    }

   
}
