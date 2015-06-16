using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap
{
    class Edge
    {
        public double X;
        public double Y;
        public Star Origin;

        public Edge(Star begin, Star end)
        {
            this.Origin = begin;
            this.X = end.X - begin.X;
            this.Y = end.Y - begin.X;
        }

        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public bool Equals(Edge other)
        {
            return (this.Length().Equals(other.Length()));
        }
    }
}
