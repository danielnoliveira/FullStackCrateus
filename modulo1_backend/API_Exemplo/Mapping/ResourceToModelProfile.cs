using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using API_Exemplo.Resources;
using API_Exemplo.Domain.Models;

namespace API_Exemplo.Mapping
{
  public class ResourceToModelProfile : Profile
  {
    public ResourceToModelProfile(){
      CreateMap<SaveCategoryResource, Category>();
    }
  }
}