using System;

namespace exemplo2Classes
{
    public class Pessoa{
        public byte idade;
        public string name;

        public void introducao(){
            Console.WriteLine("Ola, meu nome é "+name+" e minha idade é "+idade+" anos.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.name = "Daniel";
            pessoa.idade = 23;
            pessoa.introducao();
        }
    }
}
