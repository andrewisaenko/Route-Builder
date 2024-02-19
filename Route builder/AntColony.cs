using System;
using System.Collections.Generic;
using System.Linq;

namespace Route_builder
{
    public class AntColony
    {
        int vertexCount;
        int[] vertexesValue;


        int antNumber;
        List<List<int>> antsRoutes;

        double[,] pheromone;
        double[,] influenceMatrix;
        double[,] lenthMatrix;

        double[] desireToMoveArr;
        double[] transitionProbabilityArr;

        List<int> bestVertexOrder = new List<int>();        
        List<int> routeValues;
        int bestRouteValue;
        int finishIndex;

        List<double> antRoutesLengths;
        double bestRouteLength;       
        
        Random rand = new Random();

        public AntColony(double[,] lenthMatrix, int[] vertexNumber)
        {
            this.lenthMatrix = lenthMatrix;
            vertexCount = vertexNumber.Length;

            finishIndex = Array.IndexOf(vertexNumber, 1);

            vertexesValue = new int[vertexCount]; 
                        
            for (int i = 0; i < vertexCount; i++)
            {
                vertexesValue[i] = vertexNumber[i] / 10;
            }
            vertexesValue[finishIndex] = 10;

            transitionProbabilityArr = new double[vertexCount];
            desireToMoveArr = new double[vertexCount];            

            antsRoutes = new List<List<int>>();
            antRoutesLengths = new List<double>();
            routeValues = new List<int>();
            bestRouteLength = double.PositiveInfinity;

            pheromone = new double[vertexCount, vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    pheromone[i, j] = 0.200;                    
                }
            }

            influenceMatrix = new double[vertexCount, vertexCount];
        }

        public List<int> ACOforRogaine(double maxRouteLenth, int iterations)
        {
            CalculateDensity();
            //CalculateProximity();


            for (int i = 0; i < iterations; i++)
            {
                antsRoutes.Clear();
                antRoutesLengths.Clear();
                routeValues.Clear();
                for (antNumber = 0; antNumber < vertexCount; antNumber++)
                {
                    antsRoutes.Add(new List<int>());
                    antRoutesLengths.Add(new double());
                    routeValues.Add(new int());

                    antsRoutes[antNumber].Add(antNumber);

                    for (int j = 0; j < vertexCount; j++)
                    {
                        CalculateTransitionProbabilityForRogaine(antsRoutes[antNumber].Last(), maxRouteLenth);
                        ChooseVertexForRogaine();
                    }

                    antRoutesLengths[antNumber] += lenthMatrix[antNumber, antsRoutes[antNumber].Last()];

                    if (antNumber != finishIndex)
                    {
                        routeValues[antNumber] += vertexesValue[antNumber];
                    }
                    antsRoutes[antNumber].Add(antNumber);
                }

                int bestRouteIndex = antsRoutes.Select((route, index) => new { Route = route, Index = index })
                                    .Where(item => item.Route.Contains(finishIndex))
                                    .OrderByDescending(item => routeValues[item.Index])
                                    .FirstOrDefault()?.Index ?? -1;

                if (bestRouteIndex != -1 && (bestRouteValue < routeValues[bestRouteIndex] || (bestRouteValue == routeValues[bestRouteIndex] && bestRouteLength > antRoutesLengths[bestRouteIndex])))
                {
                    bestVertexOrder = antsRoutes[bestRouteIndex];
                    bestRouteValue = routeValues[bestRouteIndex];
                    bestRouteLength = antRoutesLengths[bestRouteIndex];
                }

                UpdatePheromoneForRogaine();
            }
            return bestVertexOrder;
        }                

        private void CalculateTransitionProbabilityForRogaine(int row, double maxRouteLenth)
        {
            double sumDesireToMove = 0;

            for (int column = 0; column < vertexCount; column++)
            {
                if (antsRoutes[antNumber].Contains(column))
                {
                    desireToMoveArr[column] = 0;
                }
                else if (maxRouteLenth - (antRoutesLengths[antNumber] + lenthMatrix[antsRoutes[antNumber].Last(), column]) < lenthMatrix[column, antsRoutes[antNumber].First()])
                {
                    desireToMoveArr[column] = 0;
                }
                else
                {
                    desireToMoveArr[column] = Math.Pow(influenceMatrix[column, row], 4) * Math.Pow(pheromone[column, row], 1);
                    //desireToMoveArr[column] = Math.Pow(vertexesValue[column], 4) * Math.Pow(influenceMatrix[column, row], 4) * Math.Pow(pheromone[column, row], 1);
                    sumDesireToMove += desireToMoveArr[column];
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                transitionProbabilityArr[i] = desireToMoveArr[i] / sumDesireToMove;
            }
        }
        private void ChooseVertexForRogaine()
        {
            double randNumber = rand.NextDouble();
            double sum = 0;

            for (int nextVertexStep = 0; nextVertexStep < vertexCount; nextVertexStep++)
            {
                sum += transitionProbabilityArr[nextVertexStep];
                if (sum > randNumber)
                {
                    antRoutesLengths[antNumber] += lenthMatrix[antsRoutes[antNumber].Last(), nextVertexStep];
                    if (nextVertexStep != finishIndex)
                    {
                        routeValues[antNumber] += vertexesValue[nextVertexStep];
                    }
                    antsRoutes[antNumber].Add(nextVertexStep);
                    break;
                }
            }
        }
        private void UpdatePheromoneForRogaine()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (pheromone[i, j] > 0.1)
                    {
                        pheromone[i, j] *= 0.6;
                    }
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 1; j < antsRoutes[i].Count; j++)
                {
                    //if (antsRoutes[i].Contains(finishIndex))
                    //{
                    //    pheromone[antsRoutes[i][j], antsRoutes[i][j - 1]] += (routeValues[i] * 2) / 10;
                    //    pheromone[antsRoutes[i][j - 1], antsRoutes[i][j]] += (routeValues[i] * 2) / 10;
                    //}
                    //else
                    //{
                    //    pheromone[antsRoutes[i][j], antsRoutes[i][j - 1]] += (routeValues[i]) / 10;
                    //    pheromone[antsRoutes[i][j - 1], antsRoutes[i][j]] += (routeValues[i]) / 10;
                    //}

                    pheromone[antsRoutes[i][j], antsRoutes[i][j - 1]] += routeValues[i] * 10;
                    pheromone[antsRoutes[i][j - 1], antsRoutes[i][j]] += routeValues[i] * 10;

                    //pheromone[antsRoutes[i][j], antsRoutes[i][j - 1]] += (routeValues[i] * 5) / antRoutesLengths[i];
                    //pheromone[antsRoutes[i][j - 1], antsRoutes[i][j]] += (routeValues[i] * 5) / antRoutesLengths[i];
                }

            }
        }

        

        private void CalculateDensity()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (lenthMatrix[i, j] == 0)
                    {
                        influenceMatrix[i, j] = 0;
                    }
                    else
                    {
                        influenceMatrix[i, j] = vertexesValue[i] / lenthMatrix[i, j];
                    }
                }
            }
        }

        private void CalculateProximity()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (lenthMatrix[i, j] == 0)
                    {
                        influenceMatrix[i, j] = 0;
                    }
                    else
                    {
                        influenceMatrix[i, j] = 20 / lenthMatrix[i, j];
                    }
                }
            }
        }

        public List<int> ACO(int iterations)
        {
            // proximity
            CalculateProximity();

            for (int i = 0; i < iterations; i++)
            {
                antsRoutes.Clear();
                antRoutesLengths.Clear();

                for (antNumber = 0; antNumber < vertexCount; antNumber++)
                {
                    antsRoutes.Add(new List<int>());
                    antRoutesLengths.Add(new double());
                    antsRoutes[antNumber].Add(antNumber);

                    for (int j = 0; j < vertexCount; j++)
                    {
                        CalculateTransitionProbability(antsRoutes[antNumber].Last());
                        ChooseVertex();
                    }
                    antRoutesLengths[antNumber] += lenthMatrix[antNumber, antsRoutes[antNumber].Last()];
                    antsRoutes[antNumber].Add(antNumber);

                }

                if (antRoutesLengths.Min() < bestRouteLength)
                {
                    bestRouteLength = antRoutesLengths.Min();
                    bestVertexOrder = antsRoutes[antRoutesLengths.IndexOf(bestRouteLength)];
                }
                
                UpdatePheromoneSetMin();
            }
            return bestVertexOrder;
        }        

        private void CalculateTransitionProbability(int row)
        {
            double sumDesireToMove = 0;

            for (int column = 0; column < vertexCount; column++)
            {
                if (antsRoutes[antNumber].Contains(column))
                {
                    desireToMoveArr[column] = 0;
                }
                else
                {
                    desireToMoveArr[column] = Math.Pow(influenceMatrix[column, row], 4) * Math.Pow(pheromone[column, row], 1);
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
                    antRoutesLengths[antNumber] += lenthMatrix[antsRoutes[antNumber].Last(), nextVertexStep];
                    antsRoutes[antNumber].Add(nextVertexStep);
                    break;
                }
            }
        }

        private void UpdatePheromoneSetMin()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (pheromone[i, j] > 0.01)
                    {
                        pheromone[i, j] *= 0.5;
                    }
                    
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 1; j < antsRoutes[i].Count; j++)
                {
                    pheromone[antsRoutes[i][j], antsRoutes[i][j - 1]] += 650 / antRoutesLengths[i];
                    pheromone[antsRoutes[i][j - 1], antsRoutes[i][j]] += 650 / antRoutesLengths[i];
                }

            }
        }

    }
}
