using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal interface Interface
    {
        double A { get; set; }
        double B { get; set; }

        Interface Add(Interface p);
        Interface Sub(Interface p);
        Interface Mult(Interface p);
        Interface Div(Interface p);
        bool Equ(Interface p);
        Interface Conj();

    }
}
