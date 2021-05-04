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
    public async Task<CategoryResponse> SaveAsync(Category category){
      try {
        await _categoryRepository.AddAsync(category);
        await _unityOfWork.CompleteAsync();

        return new CategoryResponse(category);
      } catch(Exception e) {
        return new CategoryResponse($"An error ocurred when saving the category: {e.Message}");
      }
    }

    public async Task<CategoryResponse> UpdateAsync(int id,Category category){
      var existingCategory = await _categoryRepository.FindByIdAsync(id);

      if(existingCategory == null)
        return new CategoryResponse("Category not found!");
      
      existingCategory.Name = category.Name;

      try {
        _categoryRepository.Update(existingCategory);
        await _unityOfWork.CompleteAsync();

        return new CategoryResponse(existingCategory);
      }catch(Exception e){
        return new CategoryResponse($"An error ocurred when updating the category: {e.Message}");
      }
    }
    public async Task<CategoryResponse> DeleteAsync(int id){
      var existingCategory = await _categoryRepository.FindByIdAsync(id);

      if(existingCategory == null)
        return new CategoryResponse("Category not found!");
      
      try{
        _categoryRepository.Remove(existingCategory);
        await _unityOfWork.CompleteAsync();
        
        return new CategoryResponse(existingCategory);
      }catch (Exception e){
        return new CategoryResponse($"An error ocurred when deleting the category: {e.Message}");
      }

    }
  }
}