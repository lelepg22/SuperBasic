using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Solver_Linear : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float x = ((arguments[2] - arguments[1]) / arguments[0]);
            return x;
        }

    }
}
