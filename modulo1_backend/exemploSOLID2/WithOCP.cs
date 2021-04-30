using System;

namespace ConsoleApp
{
  public interface IRemuneravel {
    float Remuneracao();
  }
  public class ContratoCLT: IRemuneravel {
    public float Remuneracao(){
      return 2500;
    }
  }
  public class Estagio: IRemuneravel {
    public float Remuneracao(){
      return 1000;
    }
  }
  public class ContratoPJ: IRemuneravel {
    public float Remuneracao(){
      return 3000;
    }
  }
  public class FolhaPagamento {
    protected float saldo = 5000;

    public void Calcular(IRemuneravel remuneravel){
      this.saldo -= remuneravel.Remuneracao();
    }  
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Exemplo de classes que seguem o Open/Close Principle");
    }
  }
}