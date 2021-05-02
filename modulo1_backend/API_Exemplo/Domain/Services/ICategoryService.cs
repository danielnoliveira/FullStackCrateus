using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Models;

namespace API_Exemplo.Domain.Services
{
  public interface ICategoryService {
    Task<IEnumerable<Category>> ListAsync();
  }
}