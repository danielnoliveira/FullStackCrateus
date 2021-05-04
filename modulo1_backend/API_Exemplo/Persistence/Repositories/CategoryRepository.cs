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

    public async Task AddAsync(Category category){
      await _context.Categories.AddAsync(category);
    }

    public async Task<Category> FindByIdAsync(int id){
      return await _context.Categories.FindAsync(id);
    }
    public void Update(Category category){
      _context.Categories.Update(category);
    }
    public void Remove(Category category){
      _context.Categories.Remove(category);
    }
  }
}