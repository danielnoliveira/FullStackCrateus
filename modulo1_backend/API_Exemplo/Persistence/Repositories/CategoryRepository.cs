using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Persistence.Contexts;
using API_Exemplo.Domain.Repositories;
using API_Exemplo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Exemplo.Persistence.Repositories
{
  public class CategoryRepository : BaseRepository, ICategoryRepository
  {
    public CategoryRepository(AppDbContext context):base(context){
    }

    public async Task<IEnumerable<Category>> ListAsync(){
      return await _context.Categories.ToListAsync();
    }
  }
}