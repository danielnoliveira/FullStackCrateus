using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Persistence.Contexts;

namespace API_Exemplo.Persistence.Repositories
{
  public abstract class BaseRepository
  {
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context){
      _context = context;
    }
  }
}