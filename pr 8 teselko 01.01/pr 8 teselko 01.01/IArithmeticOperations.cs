using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_teselko_01._01
{
    internal interface IArithmeticOperations
    {
        Pair Addition(Pair secondPair);
        Pair Subtraction(Pair secondPair);
        Pair Multiplication(Pair secondPair);
        Pair Division(Pair secondPair);

    }
}
