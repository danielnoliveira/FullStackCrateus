using System;

namespace ConsoleApp
{
  public interface IDAO {
    void insert();
    void delete();
    void update();
    void read();
  }
  public class DatabaseDAO: IDAO {

  }
  public class FileDAO: IDAO {

  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Exemplo de classes e interfaces que ferem o ISP");
    }
  }
}