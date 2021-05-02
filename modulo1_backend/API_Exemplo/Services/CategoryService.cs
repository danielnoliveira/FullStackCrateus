using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Services;
using API_Exemplo.Domain.Models;
using API_Exemplo.Domain.Repositories;

namespace API_Exemplo.Services
{
  public class CategoryService: ICategoryService
  {
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository){
      _categoryRepository = categoryRepository;
    }
    public async Task<IEnumerable<Category>> ListAsync(){

      return await _categoryRepository.ListAsync();
    }
  }
}