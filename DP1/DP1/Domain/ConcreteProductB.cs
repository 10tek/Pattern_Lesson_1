using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public class ConcreteProductB : IAbstractProductB
    {
        public string ProductName { get; set; }
        
        public string AnotherUsefullFunction(IAbstractProductA productA)
        {
            return productA.ProductName;
        }

        public string UsefullFunction()
        {
            return ProductName;
        }
    }
}
