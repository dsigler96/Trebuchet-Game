using System;
namespace Trebuchet.Game.Services
{
    public class PhysicsService
    {
        private double dx;
        private double dy;
        private double aDegrees;
        private double aRadians;            // Angle in radians
        private double v;                   // Total velocity

        public PhysicsService()
        {
            dx = 0;
            dy = 0;
            aDegrees = 0;
            aRadians = 0;
            v = 0;
        }

        public double ComputeDistance(double s, double v, double a, double t)
        {
            s = s + (v * t) + (0.5 * a * (t * t));

            return s;
        }

        public double ComputeVelocity(double ballWeight, double counterWeight, double counterHeight, double ballHeight)
        {
            return Math.Sqrt(-2 * (ballWeight * 9.8 * ballHeight - counterWeight *  9.8 * counterHeight)/ballWeight);
        }

        public double ComputeVerticalComponent(double a, double total)
        {
            return Math.Cos(a) * total;
        }

        public double ComputeHorizontalComponent(double a, double total)
        {
            return Math.Sin(a) * total;
        }

        public double ComputeTotalComponent(double x, double y)
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        public double radiansFromDegrees(double d)
        {
            return (d * (Math.PI / 180));
        }


        //Getters and Setters
        public double getDX()
        {
            return this.dx;
        }
        public double getDY()
        {
            return this.dy;
        }

        public double getADegrees()
        {
            return this.aDegrees;
        }

        public double getARadians()
        {
            return this.aRadians;
        }
        public double getV()
        {
            return this.v;
        }

        public void setDX(double value)
        {
            this.dx = value;
        }
        public void setDY(double value)
        {
            this.dy = value;
        }
        
        public void setADegrees(double value)
        {
            this.aDegrees = value;
        }
        
        public void setARadians(double value)
        {
            this.aRadians = value;
        }
        public void setV(double value)
        {
            this.v = value;
        }
    }
}