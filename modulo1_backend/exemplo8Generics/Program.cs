using System;

namespace exemplo8Generics
{
    public class GenericList<T> {
        public void Add(T value){
            throw new NotImplementedException();
        }
        public T this[int index] {
            get { throw new NotImplementedException();}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);
        }
    }
}
