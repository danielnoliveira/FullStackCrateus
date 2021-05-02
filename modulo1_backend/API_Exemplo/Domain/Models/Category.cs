using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Exemplo.Domain.Models
{
  public class Category
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public IList<Product> Products {get; set;} = new List<Product>();
  }
}