using System;

namespace ConsoleApp
{

  public class A {
    public virtual void Operacao(){
      Console.WriteLine("Operaçao em A");
    }
  }
  public class B: A {
    public override void Operacao()
    {
      Console.WriteLine("Operacao em B");
    }
  }
  public class Processador {

    public void Processar(A input){
      input.Operacao();
    }
  } 
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Exemplo de classes que seguem o Liskov Substitutive Principle");
      Console.WriteLine("Formas de ferir o LSP:");
      Console.WriteLine("1- Fazer a sobrescrita do metodo Operacao em B e não implementar\n a logica da operação nesta sobrescrita, que é imprimir uma mensagem.");
      Console.WriteLine("2- Modificar a assinatura do metodo Operacao em B que foi definida em A.");
    }
  }
}