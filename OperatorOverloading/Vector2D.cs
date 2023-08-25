using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Vector2D
    {
        public static Vector2D operator *(Vector2D a, double factor) => new Vector2D(a.X* factor, a.Y* factor);

        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"[{this.X}, {this.Y}]";
    }
}
