using System;

namespace exemplo3Struct
{

    struct Employee {
        public string name;
        public string position;

        public Employee(string name, string position){
            this.name = name;
            this.position = position;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Daniel","Salersman");
            Console.WriteLine("Hello World! "+emp.name+", the "+emp.position);
        }
    }
}
