﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class Rem : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            float x = arguments[0] % arguments[1];
            return x;
        }
    }
}
