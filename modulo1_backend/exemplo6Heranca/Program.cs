using System;

namespace exemplo6Heranca
{
    class Program
    {   
        class Vehicle {
            private string name;
            private byte doors;

            public Vehicle(string name, byte doors){
                this.name = name;
                this.doors = doors;
            }

            public void SetName(string name){
                this.name = name;
            }
            public string GetName(){
                return name;
            }
            public void SetDoors(byte doors){
                this.doors = doors;
            }
            public byte GetDoors(){
                return doors;
            }
        }
        class Car:Vehicle {
            private string Placa {
                get; set;
            }
            public Car(byte doors, string name, string placa):base(name,doors){
                this.Placa = placa;
            }

            public void infoCar(){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nome do carro: "+this.GetName()+", portas:"+Convert.ToString(this.GetDoors())+", placa:"+this.Placa);
            }
        }
        static void Main(string[] args)
        {
            var sedan = new Car(4,"Sedan","X4AV62");
            sedan.infoCar();
        }
    }
}
