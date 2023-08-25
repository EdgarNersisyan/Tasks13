using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypeConversions
{
    class Distance
    {
        public double length;

        public double Length {
            get { return length; }
            set { length = value; }
        }

        public Distance(double length)
        {
            this.length = length;
        }

        public static implicit operator DistanceInFeet(Distance dist)
        {
            double distInFeet =  dist.length * 3.2;
            return new DistanceInFeet(distInFeet);
        }
    }

    public class DistanceInFeet
    {
        public double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public DistanceInFeet(double length)
        {
            this.length = length;
        }
    }
}
