using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDefaultImplementationsTest
{
    public class Catto : IAnimal
    {
        public void DoSomething() => Console.WriteLine("Meow");
    }
}
