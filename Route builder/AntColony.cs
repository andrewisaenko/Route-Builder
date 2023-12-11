using System;
using System.Collections.Generic;
using System.Linq;

namespace Route_builder
{
    public class AntColony
    {
        int vertexCount;

        int antNumber;
        List<List<int>> antsRoures;

        double[,] pheromone;
        double[,] proximityOfVertexes;
        double[,] lenthMatrix;

        double[] desireToMoveArr;
        double[] transitionProbabilityArr;

        List<int> bestVertexOrder = new List<int>();
        List<double> antRoutesLengths;
        double bestRouteLength;


        Random rand = new Random();

        public AntColony(double[,] lenthMatrix, int[] vertexValue)
        {
            this.lenthMatrix = lenthMatrix;
            vertexCount = vertexValue.Length;

            transitionProbabilityArr = new double[vertexCount];
            desireToMoveArr = new double[vertexCount];

            antsRoures = new List<List<int>>();
            antRoutesLengths = new List<double>();
            bestRouteLength = double.PositiveInfinity;

            pheromone = new double[vertexCount, vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    pheromone[i, j] = 0.200;
                }
            }

            proximityOfVertexes = new double[vertexCount, vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (lenthMatrix[i, j] == 0)
                    {
                        proximityOfVertexes[i, j] = 0;
                    }
                    else
                    {
                        proximityOfVertexes[i, j] = 20 / lenthMatrix[i, j];

                    }
                }
            }
        }

        public List<int> ACO()
        {
            for (int i = 0; i < 10000; i++)
            {
                antsRoures.Clear();
                antRoutesLengths.Clear();
                for (antNumber = 0; antNumber < vertexCount; antNumber++)
                {
                    antsRoures.Add(new List<int>());
                    antRoutesLengths.Add(new double());

                    antsRoures[antNumber].Add(antNumber);

                    for (int j = 0; j < vertexCount; j++)
                    {
                        CalculateTransitionProbability(antsRoures[antNumber].Last());
                        ChooseVertex();
                    }
                    antRoutesLengths[antNumber] += lenthMatrix[antNumber, antsRoures[antNumber].Last()];
                    antsRoures[antNumber].Add(antNumber);

                }

                if (antRoutesLengths.Min() < bestRouteLength)
                {
                    bestRouteLength = antRoutesLengths.Min();
                    bestVertexOrder = antsRoures[antRoutesLengths.IndexOf(bestRouteLength)];
                }
                UpdatePheromone();
            }
             return bestVertexOrder;
        }

        private void CalculateTransitionProbability(int row)
        {
            double sumDesireToMove = 0;

            for (int column = 0; column < vertexCount; column++)
            {
                if (antsRoures[antNumber].Contains(column))
                {
                    desireToMoveArr[column] = 0;
                }
                else
                {
                    desireToMoveArr[column] = Math.Pow(proximityOfVertexes[column, row], 8) * Math.Pow(pheromone[column, row], 3);
                    sumDesireToMove += desireToMoveArr[column];
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                transitionProbabilityArr[i] = desireToMoveArr[i] / sumDesireToMove;
            }
        }

        private void ChooseVertex()
        {
            double randNumber = rand.NextDouble();
            double sum = 0;

            for (int nextVertexStep = 0; nextVertexStep < vertexCount; nextVertexStep++)
            {
                sum += transitionProbabilityArr[nextVertexStep];
                if (sum > randNumber)
                {
                    antRoutesLengths[antNumber] += lenthMatrix[antsRoures[antNumber].Last(), nextVertexStep];
                    antsRoures[antNumber].Add(nextVertexStep);
                    break;
                }
            }
        }

        private void UpdatePheromone()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    pheromone[i, j] *= 0.8;
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 1; j < antsRoures[i].Count; j++)
                {
                    pheromone[antsRoures[i][j], antsRoures[i][j - 1]] = 500 / antRoutesLengths[i];
                    pheromone[antsRoures[i][j - 1], antsRoures[i][j]] = 500 / antRoutesLengths[i];
                }

            }
        }
    }
}
