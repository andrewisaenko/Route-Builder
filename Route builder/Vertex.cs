using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class Vertex
    {
        public int Number { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public Vertex(int number, int x, int y)
        {
            Number = number;
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
