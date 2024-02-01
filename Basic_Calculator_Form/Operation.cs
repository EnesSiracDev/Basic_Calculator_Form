using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator_Form
{
    internal class Operation
    {
        int sayi1, sayi2;

        public Operation(int s1, int s2)
        {
            sayi1 = s1;
            sayi2 = s2;
        }

        public int Addition()
        {
            return sayi1 + sayi2;
        }

        public int Subtraction()
        {
            return sayi1 - sayi2;
        }

        public int Multiplication()
        {
            return sayi1 * sayi2;
        }

        public int Division()
        {
            return sayi1 / sayi2;
        }
    }
}
