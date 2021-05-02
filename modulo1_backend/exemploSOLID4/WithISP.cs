using System;

namespace ConsoleApp
{
  public interface IDBAccess {
    void insert();
    void delete();
    void update();
    void next();
    void previous();
  }
  public interface IFileAccess {
    void write();
    void read();
    void append();
    void rotate();
  }
  public class DatabaseDAO: IDBAccess {

  }
  public class FileDAO: IFileAccess {

  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Exemplo de classes e interfaces que seguem o ISP");
    }
  }
}