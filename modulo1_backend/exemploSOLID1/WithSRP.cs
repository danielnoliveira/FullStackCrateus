using System;

namespace exemploSOLID1_2
{
    public class Ordem {
        // Gestao de itens
        public void CalcularTotal();
        public void GetItems();
        public void GetItensCount();
        public void AddItem();
        public void DeleteItem();
    }
    public class OrdemViewer {
        // Exibir itens
        public void PrintOrder();
        public void ShowOrder();
    }
    public class OrdemRepository {
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
            Console.WriteLine("Exemplo de classe que está de acordo com o Single Responsability Principle");
        }
    }
}
