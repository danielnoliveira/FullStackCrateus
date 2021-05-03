using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace API_Exemplo.Extensions
{
  public static class ModelStateExtension
  {
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary){
      return dictionary.SelectMany(m => m.Value.Errors)
                      .Select(m => m.ErrorMessage)
                      .ToList();
    }
  }
}