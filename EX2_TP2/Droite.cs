using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_TP2
{
    internal class Droite
    {
        public point p { get; set; }//extrimete1
        public point q { get; set; }//extrimete2

        public Droite(point p, point q)
        {
            this.p = p;
            this.q = q;
        }
        public bool egalite(Droite d)
        {
            return (p.equal(d.q) && q.equal(d.q));
        }
        public bool Parallelisme(Droite d)
        {
            return (d.p == p.translation(p) && d.q == q.translation(q));

        }
       


    }
}
