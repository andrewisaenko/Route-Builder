using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_builder
{
    class Converter
    {
        public Graph graph { private get; set; }

        public int[] CpValueToArr()
        {
            int[] CpValue = new int[graph.VertexCount];
            for (int i = 0; i < graph.VertexCount; i++)
            {
                CpValue[i] = graph.Vertexes[i].Number;
            }
            return CpValue;
        }
        public int[,] CpCoordinatesToArr()
        {
            var coordinates = new int[graph.VertexCount, 2];

            for (int i = 0; i < graph.VertexCount; i++)
            {
                coordinates[i, 0] = graph.Vertexes[i].X;
                coordinates[i, 1] = graph.Vertexes[i].Y;
            }
            return coordinates;
        }
        public double[,] EdgeLengthToMatrix()
        {
            var matrix = new double[graph.Vertexes.Count, graph.Vertexes.Count];
            foreach (var edge in graph.Edges)
            {
                var row = graph.Vertexes.IndexOf(edge.To);
                var column = graph.Vertexes.IndexOf(edge.From);

                matrix[row, column] = edge.Length;
                matrix[column, row] = edge.Length;
            }
            return matrix;
        }
        public string CpCoordinatesToString()
        {
            return CpCoordinatesArrToString(CpCoordinatesToArr());
        }
        public string EdgeLengthMatrixToString()
        {
            return EdgeLengthMatrixToString(EdgeLengthToMatrix());
        }
        public string CpValueToString()
        {
            return CpValueArrToString(CpValueToArr());
        }
        public static string CpValueArrToString(int[] CpValues)
        {
            return string.Join(" ", CpValues);
        }
        public static string CpCoordinatesArrToString(int[,] arr)
        {
            string str = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                str += $"{arr[i, 0]} {arr[i, 1]} ";
            }
            return str.Trim();
        }
        public static string EdgeLengthMatrixToString(double[,] arr)
        {
            string str = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str += $"{arr[i, j]} ";
                }

            }
            return str.Trim();
        }
        public static int[] CpValueStringToArray(string str)
        {
            return str.Split(' ').Select(Int32.Parse).ToArray();
        }
        public static int[,] CpCoordinatesStringToArr(string str)
        {
            string[] s = str.Split(' ');
            int[,] arr = new int[s.Length / 2, 2];
            for (int i = 0; i < s.Length / 2; i++)
            {
                arr[i, 0] = Convert.ToInt32(s[i * 2]);
                arr[i, 1] = Convert.ToInt32(s[(i * 2) + 1]);
            }
            return arr;
        }
        public static double[,] EdgeLengthStringToArr(string str)
        {
            string[] s = str.Split(' ');
            int size = Convert.ToInt32(Math.Sqrt(s.Length));
            double[,] arr = new double[size, size];
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = Convert.ToDouble(s[counter]);
                    counter++;
                }
            }
            return arr;
        }
        public static Graph ArrToVertexes(int[] CpValue, int[,] CpCoordinates)
        {
            Graph graph = new Graph();
            for (int i = 0; i < CpValue.Length; i++)
            {
                graph.AddVertex(CpValue[i], CpCoordinates[i, 0], CpCoordinates[i, 1]);
            }
            return graph;
        }
        public static Graph StringToVertexes(string CpValue, string CpCoordinates)
        {
            int[] CpValueArr = CpValueStringToArray(CpValue);
            int[,] CpCoordinatesArr = CpCoordinatesStringToArr(CpCoordinates);
            return ArrToVertexes(CpValueArr, CpCoordinatesArr);
        }
        public static Graph EdgeLengthMatrixToEdges(Graph graph, double[,] matrix)
        {

            if (graph.Vertexes.Count != 0)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (matrix[j, i] > 0)
                        {
                            graph.AddEdge(graph.Vertexes[i], graph.Vertexes[j]);
                        }
                    }
                }
            }
            return graph;
        }
        public static Graph EdgeLengthStringToEdges(Graph graph, string matrixString)
        {
            double[,] matrix = EdgeLengthStringToArr(matrixString);
            return EdgeLengthMatrixToEdges(graph, matrix);
        }

        public List<Vertex> CpOrderIndexesToVertexList(List<int> cpIndexes)
        {
            graph.CpOrder = new List<Vertex>();
            for (int i = 0; i < cpIndexes.Count; i++)
            {               
                graph.CpOrder.Add(graph.Vertexes[cpIndexes[i]]);
            }
            return graph.CpOrder;
        }
    }
}