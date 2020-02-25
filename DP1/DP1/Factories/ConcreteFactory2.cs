using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA { ProductName = "apple" };
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB { ProductName = "Mouse" };
        }
    }
}
