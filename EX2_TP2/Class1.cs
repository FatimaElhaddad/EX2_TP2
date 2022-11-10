using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_TP2
{
    public class point
    {
        private double x, y;
        public void setX(double p)
        {
            x = p;
        }
        public void setY(double p)
        {
            y = p;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public bool equal(point p)
        {
            if (this.x == p.x && this.y == p.y)
                return true;
            else
                return false;
        }
        public double distance(point p)
        {
            double dx = this.x - p.x;
            double dy = this.y = p.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public void translation(double p)
        {
            x += p;
            y += p;

        }
        public void rotation(double ang)
        {
            x = x * Math.Cos(ang) - y * Math.Sin(ang);
            y = x * Math.Cos(ang) - y * Math.Sin(ang);
        }

        
    }
}
