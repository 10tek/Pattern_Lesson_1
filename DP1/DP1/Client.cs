using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public class Client
    {
        public void Do()
        {
            ClientMethod(new ConcreteFactory1());
            Console.ReadKey();
            ClientMethod(new ConcreteFactory2());
            Console.ReadKey();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefullFunction());
            Console.WriteLine(productB.AnotherUsefullFunction(productA));
        }
    }
}
