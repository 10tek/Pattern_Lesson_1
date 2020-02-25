using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
