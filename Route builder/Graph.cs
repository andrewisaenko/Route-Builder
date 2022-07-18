using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class Graph
    {
        public List<Vertex> Vertexes = new List<Vertex>();
        public List<Edge> Edges = new List<Edge>();

        public List<Vertex> CpOrder;
        public double RouteLength;
        public int RouteValue;

        public List<Vertex> BufCpOrder;
        public double BufRouteLength;
        public int BufRouteValue;

        public double plannedDisnance;

        public Converter Converter = new Converter();

        public Graph()
        {
            Converter.graph = this;
        }



        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(int number, int x, int y)
        {
            var v = new Vertex(number, x, y);
            Vertexes.Add(v);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public void BuildAllEdges()
        {
            if (Vertexes != null)
            {
                for (int i = 0; i < Vertexes.Count - 1; i++)
                {
                    for (int j = i + 1; j < Vertexes.Count; j++)
                    {
                        AddEdge(Vertexes[i], Vertexes[j]);
                    }
                }
            }
        }

        public void OptimizeGraph()
        {
            if (Vertexes != null && Edges != null)
            {
                for (int v = 0; v < Vertexes.Count - 1; v++) // vertexes in ghaph
                {
                    for (int e1 = 0; e1 < Edges.Count - 1; e1++) // edges from vertex
                    {
                        if (CheckBelonging(Vertexes[v], Edges[e1])) // belong checking
                        {
                            for (int e2 = 0; e2 < Edges.Count; e2++) // selecting second edge for comparing
                            {
                                if (CheckBelonging(Vertexes[v], Edges[e2])) // belong checking of second edge
                                {
                                    double angle = GetAngle(Edges[e1], Edges[e2]);
                                    if (angle < 25 && ((Edges[e1].Length / Edges[e2].Length) * 100 > 105 || (Edges[e1].Length / Edges[e2].Length) * 100 < 95))
                                    {
                                        if (Edges[e1].Length < Edges[e2].Length)
                                        {
                                            Edges.RemoveAt(e2);
                                            e2--;
                                        }
                                        else if (Edges[e2].Length < Edges[e1].Length)
                                        {
                                            Edges.RemoveAt(e1);
                                            e1--;
                                            e2--;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void OptimizeGraphByTriangle()
        {
            for (int v1 = 0; v1 < Vertexes.Count; v1++)
            {
                for (int v2 = 0; v2 < Vertexes.Count; v2++)
                {
                    if (Vertexes[v1] == Vertexes[v2])
                    {
                        continue;
                    }
                    else
                    {
                        double v1_v2 = Edge.CalculateLength(Vertexes[v1], Vertexes[v2]);
                        for (int v3 = 0; v3 < Vertexes.Count; v3++)
                        {
                            if(Vertexes[v1] == Vertexes[v3] || Vertexes[v2] == Vertexes[v3])
                            {
                                continue;
                            }
                            else
                            { 
                                double v1_v3 = Edge.CalculateLength(Vertexes[v1], Vertexes[v3]);
                                double v2_v3 = Edge.CalculateLength(Vertexes[v2], Vertexes[v3]);

                                double differencePerсent = (1 - (v1_v3 / (v1_v2 + v2_v3))) * 100;

                                if(differencePerсent < 10)
                                {                                    
                                    Edges.Remove(Edges.Where(e => (e.To == Vertexes[v1] && e.From == Vertexes[v3]) || e.To == Vertexes[v3] && e.From == Vertexes[v1]).FirstOrDefault());
                                }
                            }

                        }
                    }
                }
            }
        }

        private bool CheckBelonging(Vertex v, Edge e)
        {
            return v.Number == e.From.Number || v.Number == e.To.Number;
        }

        public static double GetAngle(Edge e1, Edge e2)
        {
            Vertex v1 = e1.From != e2.From && e1.From != e2.To ? e1.From : e1.To;
            Vertex v2 = e2.From != e1.From && e2.From != e1.To ? e2.From : e2.To;

            double e3_Length = Edge.CalculateLength(v1, v2);

            double radians = Math.Acos((Math.Pow(e1.Length, 2) + Math.Pow(e2.Length, 2) - Math.Pow(e3_Length, 2)) / (2 * e1.Length * e2.Length));

            return Math.Round((180 / Math.PI) * radians, 2);
        }

        public bool CheckIsAllInBuf(List<Vertex> vlist)
        {
            bool ContainAll = true;
            foreach (Vertex v in vlist)
            {
                if (!BufCpOrder.Contains(v))
                {
                    ContainAll = false;
                    return ContainAll;
                }
            }
            return ContainAll;
        }

        private List<Vertex> GetVertexList(Vertex vertex)
        {
            var result = new List<Vertex>();

            //for (int i = 0; i < Edges.Count; i++)
            //{
            //    if (Edges[i].From == vertex)
            //    {
            //        result.Add(Edges[i].To);
            //    }
            //    if (Edges[i].To == vertex)
            //    {
            //        result.Add(Edges[i].From);
            //    }
            //}

            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
                if (edge.To == vertex)
                {
                    result.Add(edge.From);
                }
            }
            return result;
        }

        private void AddVertexToCpOrder(Vertex curentV)
        {
            BufCpOrder.Add(curentV);
            BufRouteValue += curentV.Number / 10;
        }

        private void DellVertexFromCpOrder()
        {
            if (BufCpOrder.Count >= 2)
            {
                BufRouteValue -= BufCpOrder.Last().Number / 10;
                BufCpOrder.RemoveAt(BufCpOrder.Count - 1);
            }
        }

        public void FindBestRoute(double dist)
        {
            plannedDisnance = dist;
            BufCpOrder = new List<Vertex>();
            BufCpOrder.Add(Vertexes.Find(x => x.Number == 1));
            FindNextStep();
        }

        private void FindNextStep()
        {
            List<Vertex> Vlist = GetVertexList(BufCpOrder.Last());
            for (int i = 0; i < Vlist.Count; i++)
            {
                double nextStepDistance = Edge.CalculateLength(Vlist[i], BufCpOrder[BufCpOrder.Count - 1]);
                BufRouteLength += nextStepDistance;
                if (BufRouteLength < plannedDisnance)
                {
                    if (Vlist[i].Number == 1)
                    {
                        AddVertexToCpOrder(Vlist[i]);
                        if ((BufRouteValue > RouteValue) || (BufRouteValue == RouteValue && BufRouteLength < RouteLength))
                        {
                            CpOrder = BufCpOrder.ToList();
                            RouteValue = BufRouteValue;
                            RouteLength = BufRouteLength;
                        }
                        DellVertexFromCpOrder();
                    }
                    else if (!BufCpOrder.Contains(Vlist[i]))
                    {
                        AddVertexToCpOrder(Vlist[i]);
                        FindNextStep();
                    }
                }
                BufRouteLength -= nextStepDistance;
            }
            DellVertexFromCpOrder();
        }
    }

}
