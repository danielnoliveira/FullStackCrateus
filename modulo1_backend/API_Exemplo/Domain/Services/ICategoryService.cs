using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Models;
using API_Exemplo.Domain.Services.Communication;

namespace API_Exemplo.Domain.Services
{
  public interface ICategoryService {
    Task<IEnumerable<Category>> ListAsync();

    Task<SaveCategoryResponse> SaveAsync(Category category);
  }
}