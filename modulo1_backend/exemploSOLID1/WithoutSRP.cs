using System;

namespace exemploSOLID1
{
    public class Ordem {
        // Gestao de itens
        public void CalcularTotal();
        public void GetItems();
        public void GetItensCount();
        public void AddItem();
        public void DeleteItem();

        // Exibir itens
        public void PrintOrder();
        public void ShowOrder();

        // Acesso ao banco de dados
        public void Load();
        public void Save();
        public void Delete();
        public void Update();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de classe que fere o Single Responsability Principle");
        }
    }
}
