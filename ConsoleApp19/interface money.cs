using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public interface IPairMoney
    {
        IPairMoney Add(IPairMoney value);
        IPairMoney Subtract(IPairMoney value);
        IPairMoney Multiply(double value);
        IPairMoney Divide(double value);
        int CompareTo(object obj);
        string ToString();
    }
}
