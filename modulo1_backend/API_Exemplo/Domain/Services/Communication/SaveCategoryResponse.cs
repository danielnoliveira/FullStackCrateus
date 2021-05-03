using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Models;

namespace API_Exemplo.Domain.Services.Communication
{
  public class SaveCategoryResponse: BaseResponse
  {
    public Category Category {get; private set;}

    private SaveCategoryResponse(bool success, string message, Category category):base(success,message) {
      Category = category;
    }

    public SaveCategoryResponse(Category category) : this(true,string.Empty, category){
    }

    public SaveCategoryResponse(string message) : this(false,message, null){

    }


  }
}