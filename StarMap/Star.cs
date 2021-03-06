﻿using System;
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

        public Star Turn(double angle)
        {
            var x1 = this.X * Math.Cos(angle) - this.Y * Math.Sin(angle);
            var y1 = this.X * Math.Sin(angle) + this.Y * Math.Cos(angle);

            return new Star(x1, y1);
        }

        public bool InLocal(Star other)
        {
            if (Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)) < 1.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Star other)
        {
            return (X.Equals(other.X) && Y.Equals(other.Y));
        }
    }
}
