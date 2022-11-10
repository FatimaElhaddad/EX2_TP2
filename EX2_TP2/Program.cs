using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2_TP2
{
     class Program
    {
        static void Main(string[] args)
        {
            double x, y,t ;
            point p = new point(1.5,1.5);
            Console.Out.Write("Donner l'abscisse: ");
            x = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonne: ");
            y = double.Parse(Console.In.ReadLine());
            p.setX(x);
            p.setY(y);
            point q = new point(0.5, 0.5);
            Console.Out.Write("La distance(p,q) est "  +p.distance(q));
            if (p.equal(q))
                Console.Out.Write("p et q sont egaux ");
            else
                Console.Out.Write("p et q sont egaux ");
            t = p.translation(10);
            Console.Out.Write("Translation du point B par 10 "+t);
            Console.Out.Write("Rotation du point B par 45deg " + rotation(45);
            Console.ReadKey();




        }
    }
}
