using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap
{
    class Map
    {
        private List<Star> _listStars;
        private List<Edge> _listEdges;

        public Map()
        {
            _listStars = new List<Star>();
            _listEdges = new List<Edge>();
        }

        public void Add(double x, double y)
        {
            var newStar = new Star(x, y);

            foreach (var star in _listStars)
            {
                _listEdges.Add(new Edge(newStar, star));
            }

            _listStars.Add(newStar);
        }

        static public int Combine(Map map1, Map map2)
        {
            int maxCorr = 0;

            foreach (var edge1 in map1._listEdges)
            {
                foreach (var edge2 in map2._listEdges)
                {
                    if (!edge1.Equals(edge2)) continue;
                    int corr = 0; 

                    var x0 = edge2.Origin.X - edge1.Origin.X;
                    var y0 = edge2.Origin.Y - edge1.Origin.Y;

                    var angle = Math.Acos((edge1.X * edge2.X + edge1.Y * edge2.Y) / edge1.Length() / edge2.Length());

                    if (edge1.X * edge2.Y - edge1.Y * edge2.X < 0)
                    {
                        angle *= -1;
                    }

                    foreach (var star in map1._listStars)
                    {
                        var modifStar = new Star(star.X - edge1.Origin.X, star.Y - edge1.Origin.Y);
                        modifStar = modifStar.Turn(angle);
                        modifStar.X += edge2.Origin.X;
                        modifStar.Y += edge2.Origin.Y;

                        corr += map2._listStars.Count(modifStar.InLocal);
                    }

                    if (corr > maxCorr)
                    {
                        maxCorr = corr;
                    }
                }
            }

            return maxCorr;
        }
    }
}
