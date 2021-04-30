using System;

namespace ConsoleApp
{
  public class ContratoCLT {
    public float Salario() {
      return 2500;
    }
  }
  public class Estagio {
    public float Bolsa() {
      return 1000;
    }
  }
  public class FolhaPagamento {
    protected float saldo = 5000;
    public void Calcular(Object input){
      if(typeof(ContratoCLT).IsInstanceOfType(input)){
        ContratoCLT contrato = (ContratoCLT) input;
        this.saldo -= contrato.Salario();
      }else if(typeof(Estagio).IsInstanceOfType(input)){
        Estagio estagio = (Estagio) input;
        this.saldo -= estagio.Bolsa();
      }
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Exemplo de classes que ferem o Open/Close Principle");
    }
  }
}