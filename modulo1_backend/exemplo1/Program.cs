using System;

namespace modulo1_backend
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      byte number = 2;
      int count = 0;
      float price = 20.95f;
      char letter = 'A';
      string name = "Daniel";
      bool isEmpty = false;

      Console.WriteLine(number);
      Console.WriteLine(count);
      Console.WriteLine(price);
      Console.WriteLine(letter);
      Console.WriteLine(name);
      Console.WriteLine(isEmpty);

      var s = "345";
      var r = Convert.ToInt32(s);
      Console.WriteLine(r);

    }
  }
}
