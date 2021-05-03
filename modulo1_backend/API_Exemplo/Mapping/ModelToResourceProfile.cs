using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API_Exemplo.Resources;
using API_Exemplo.Domain.Models;
namespace API_Exemplo.Mapping
{
  public class ModelToResourceProfile : Profile
  {
    public ModelToResourceProfile(){
      CreateMap<Category,CategoryResource>();
    }
  }
}