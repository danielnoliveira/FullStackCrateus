using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_Exemplo.Domain.Repositories
{
  public interface IUnityOfWork
  {
    Task CompleteAsync();
  }
}