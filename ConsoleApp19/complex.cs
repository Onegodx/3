using ConsoleApp18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Complex : Interface
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }

        public Interface Add(Interface p)
        {
            return new Complex(this.A + p.A, this.B + p.B);
        }

        public Interface Conj()
        {
            return new Complex(this.A, -this.B);
        }

        public Interface Div(Interface p)
        {
            return new Complex((this.A * p.A + this.B * p.B) / (p.A * p.A + p.B * p.B),
                 (this.A * p.B + this.B * p.A) / (p.A * p.A + p.B * p.B));
        }

        public bool Equ(Interface p)
        {
            return (this.A == p.A) && (this.B == p.B);
        }

        public Interface Mult(Interface p)
        {
            return new Complex(this.A * p.A - this.B * p.B, this.A * p.B + p.A * this.B);
        }

        public Interface Sub(Interface p)
        {
            return new Complex(this.A - p.A, this.B - p.B);
        }

        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
    }
}