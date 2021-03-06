using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;

namespace API_Exemplo.Domain.Helpers
{
  public enum EUnitOfMeasurement: byte
  {
    [Description("UN")]
    Unity = 1,
    [Description("MG")]
    Milligram = 2,
    [Description("G")]
    Gram = 3,
    [Description("KG")] 
    Kilogram = 4,
    [Description("L")]
    Liter = 5,

  }
}