using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EX2_TP2
{
    internal class Cercle
    {
        public point centre { get; set; }
        public float rayon { get; set; }

        public Cercle(point centre, float rayon)
        {
            this.centre = centre;
            this.rayon = rayon;
        }
        public bool egalite(Cercle cercle)
        {
            return (centre.equal(cercle.centre) && rayon == cercle.rayon);
        }
        public bool intersection(Cercle cercle)
        {
            if (cercle.centre.equal(this.centre))
                return true;
            double distanceRayon = centre.distance(cercle.centre);
            if (distanceRayon > rayon + cercle.rayon)
                return false;

            return true;
        }
        public double Aire()
        {
            return rayon * rayon * Math.PI;
        }
        public double circonference()
        {
            return (Math.PI * 2 * rayon);
        }
    }
}
