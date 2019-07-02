using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Assign_abstract_class
    {
        abstract class Area
        {
            public abstract void rectangle_get_area(double x, double y);
            public abstract void circle_get_area(double r);
            public abstract void triangle_get_area(double w, double h);
            public abstract void cone_get_area(double r, double h);


        }
        class shape : Area
        {
            public override void rectangle_get_area(double x, double y)
            {
                double z = x * y;
                Console.WriteLine("Area of the Rectangle: " + z);
            }
            public override void circle_get_area(double r)
            {
                double a = Math.PI * r * r;
                Console.WriteLine("Area of the circle: " + a);
            }
            public override void triangle_get_area(double w, double h)
            {
                double b = (w * h) / 2;
                Console.WriteLine("Area of the Triangle :" + b);
            }
            public override void cone_get_area(double r, double h)
            {
                double c = (Math.PI * r * r) + (Math.PI * r * h);
                Console.WriteLine("Area of the cone: " + c);
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                shape r = new shape();
                shape c = new shape();
                shape t = new shape();
                shape cone = new shape();
                r.rectangle_get_area(3, 4);
                c.circle_get_area(5);
                t.triangle_get_area(4, 8);
                cone.cone_get_area(5, 6);
                Console.ReadKey();
            }
        }
    }


