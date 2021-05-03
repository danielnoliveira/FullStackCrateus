using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Repositories;
using API_Exemplo.Persistence.Contexts;

namespace API_Exemplo.Persistence.Repositories
{
  public class UnityOfWork : IUnityOfWork
  {
    private readonly AppDbContext _context;

    public UnityOfWork(AppDbContext context){
      _context = context;
    }

    public async Task CompleteAsync(){
      await _context.SaveChangesAsync();
    }
  }
}