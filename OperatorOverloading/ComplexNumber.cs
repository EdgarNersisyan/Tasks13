using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class ComplexNumber
    {
        public static ComplexNumber operator +(ComplexNumber p1, ComplexNumber p2) => 
            new ComplexNumber(p1.A + p2.A, p1.B + p2.B);

        public double A { get; set; }
        public double B { get; set; }

        public ComplexNumber(double a, double b)
        {
            A = a;
            B = b;
        }
        public override string ToString() => $"{this.A} + {this.B}i";
    }
}
