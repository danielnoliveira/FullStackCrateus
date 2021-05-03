using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Services;
using API_Exemplo.Domain.Models;
using API_Exemplo.Domain.Repositories;
using API_Exemplo.Domain.Services.Communication;

namespace API_Exemplo.Services
{
  public class CategoryService: ICategoryService
  {
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnityOfWork _unityOfWork;

    public CategoryService(ICategoryRepository categoryRepository, IUnityOfWork unityOfWork){
      _categoryRepository = categoryRepository;
      _unityOfWork = unityOfWork;
    }
    public async Task<IEnumerable<Category>> ListAsync(){

      return await _categoryRepository.ListAsync();
    }
    public async Task<SaveCategoryResponse> SaveAsync(Category category){
      try {
        await _categoryRepository.AddAsync(category);
        await _unityOfWork.CompleteAsync();

        return new SaveCategoryResponse(category);
      } catch(Exception e) {
        return new SaveCategoryResponse($"An error ocurred when saving the category: {e.Message}");
      }
    }
  }
}