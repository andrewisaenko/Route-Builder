using System;
using System.Collections.Generic;
using System.Drawing;


namespace Route_builder
{
    class Ruler
    {
        public List<Point> points = new List<Point>();
        public double scale_px;
        public double scale_m;
        public double plannedDistanсeKm;
        public double plannedDistancePx;


        public void CalculateLength()
        {
            scale_px = Math.Round(Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2)));            
        }

        public double CalculateDistanceInPx()
        {
            plannedDistancePx = (plannedDistanсeKm * 1000 * scale_px) / scale_m;
            return plannedDistancePx;
        }

    }
}
