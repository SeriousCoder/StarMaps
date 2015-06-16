using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var map1 = new Map();
            var map2 = new Map();

            map1.Add(1.0, 1.0);
            map1.Add(1.0, 3.0);

            map2.Add(4.0, 4.0);
            map2.Add(6.0, 4.0);

            Console.WriteLine(Map.Combine(map1, map2));
            Console.ReadKey();
        }
    }
}
