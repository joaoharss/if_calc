using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Contracts.Operations
{
    internal class Dividir : IOperation
    {
        public int calc(int value1, int value2) => value1 / value2;
    }
}
