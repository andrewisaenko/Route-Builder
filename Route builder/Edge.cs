using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public double Length { get; private set; }
            
        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
            Length = CalculateLength(from, to);
        }

        public override string ToString()
        {
            return $"{From}; {To}";
        }

        public static double CalculateLength(Vertex v1, Vertex v2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2)), 2);
        }
    }
}
