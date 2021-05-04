using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Models;

namespace API_Exemplo.Domain.Services.Communication
{
  public class CategoryResponse: BaseResponse
  {
    public Category Category {get; private set;}

    private CategoryResponse(bool success, string message, Category category):base(success,message) {
      Category = category;
    }

    public CategoryResponse(Category category) : this(true,string.Empty, category){
    }

    public CategoryResponse(string message) : this(false,message, null){

    }


  }
}