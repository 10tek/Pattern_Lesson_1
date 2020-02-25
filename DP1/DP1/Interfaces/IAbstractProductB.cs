using System;
using System.Collections.Generic;
using System.Text;

namespace DP1
{
    public interface IAbstractProductB
    {
        string ProductName { get; set; }

        string UsefullFunction();
        string AnotherUsefullFunction(IAbstractProductA productA);
    }
}
