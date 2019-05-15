using System;

namespace InterfaceDefaultImplementationsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Catto();
            var animal2 = new Doggo();
            IAnimal human = new Human();
            animal1.DoSomething();
            animal2.DoSomething();
            human.DoSomething();
        }
    }
}
