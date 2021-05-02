using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_Exemplo.Domain.Services;
using API_Exemplo.Domain.Models;

namespace API_Exemplo.Controllers
{
  [Route("/api/[controller]")]
  public class CategoryController: Controller
  {
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService){
      _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IEnumerable<Category>> GetAllAsync(string value)
    {
      var categories = await _categoryService.ListAsync();
      return categories;
    }
  }
  
}