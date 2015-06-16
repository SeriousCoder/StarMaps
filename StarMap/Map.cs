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

        public int Combine(Map map1, Map map2)
        {
            foreach (var edge1 in map1._listEdges)
            {
                foreach (var edge2 in map2._listEdges)
                {
                    if (edge1 == edge2)
                    {
                        var x0 = edge2.X - edge1.X;
                        var y0 = edge2.Y - edge1.Y;

                        var angle = Math.Acos((edge1.X * edge2.X + edge1.Y * edge2.Y) / edge1.Length() / edge2.Length());

                       
                    }
                }
            }
        }
    }
}
