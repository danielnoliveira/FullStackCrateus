using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Helpers;

namespace API_Exemplo.Domain.Models
{
  public class Product
  {

    public int Id {get; set;}
    public string Name {get; set;}
    public short QuantityInPackage {get; set;}
    public EUnitOfMeasurement UnitOfMeasurement {get; set;}
    public int CategoryId {get; set;}
    public Category Category {get; set;}
  }
}