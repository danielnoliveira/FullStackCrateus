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

    Task<CategoryResponse> SaveAsync(Category category);

    Task<CategoryResponse> UpdateAsync(int id,Category category);

    Task<CategoryResponse> DeleteAsync(int id);
  }
}