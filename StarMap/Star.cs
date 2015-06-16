using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap
{
    class Star
    {
        public double X;
        public double Y;

        public Star(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        private Star Convert(double x0, double y0, double angle)
        {
            var x = this.X + x0;
            var y = this.Y + y0;

            var x1 = x * Math.Cos(angle) - y * Math.Sin(angle);
            var y1 = x * Math.Sin(angle) + y * Math.Cos(angle);

            return new Star(x1, y1);
        }

        public bool Equals(Star other)
        {
            return (X.Equals(other.X) && Y.Equals(other.Y));
        }
    }
}
