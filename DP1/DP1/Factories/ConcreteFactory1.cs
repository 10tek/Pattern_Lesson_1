using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA { ProductName = "Banana" };
        }

        IAbstractProductB IAbstractFactory.CreateProductB()
        {
            return new ConcreteProductB { ProductName = "KeyBoard" };
        }
    }
}
