using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Iphone
{
    public abstract class Iphone
    {
        public void common()
        {
            string OS = "Mac OS";
            string Keypad = "Iphone keypad";
            Console.WriteLine("OS      :" + OS);
            Console.WriteLine("Keypad  :" + Keypad);
        }
        public abstract void features(string c, string s, string b, int p, string m);
    }
    public class Iphone_6 : Iphone
    {
        public override void features(string c, string s, string b, int p, string m)
        {
            Console.WriteLine("Camera  :" + c);
            Console.WriteLine("Screen  :" + s);
            Console.WriteLine("Battery :" + b);
            Console.WriteLine("Price   :" + p);
            Console.WriteLine("Memory  :" + m);
        }
    }
    public class Iphone_7s : Iphone
    {

        public override void features(string c, string s, string b, int p, string m)
        {
            Console.WriteLine("Camera  :" + c);
            Console.WriteLine("Screen  :" + s);
            Console.WriteLine("Battery :" + b);
            Console.WriteLine("Price   :" + p);
            Console.WriteLine("Memory  :" + m);
        }
        public void extra()
        {
            Console.WriteLine("Excess features : 3D touch");
        }
    }
    public class Iphone_8_plus : Iphone
    {
        public override void features(string c, string s, string b, int p, string m)
        {
            Console.WriteLine("Camera  :" + c);
            Console.WriteLine("Screen  :" + s);
            Console.WriteLine("Battery :" + b);
            Console.WriteLine("Price   :" + p);
            Console.WriteLine("Memory  :" + m);
        }
        public void extra()
        {
            Console.WriteLine("Excess features : 3D touch");
        }
    }
    public class Iphone_Xs : Iphone
    {
        public override void features(string c, string s, string b, int p, string m)
        {
            Console.WriteLine("Camera  :" + c);
            Console.WriteLine("Screen  :" + s);
            Console.WriteLine("Battery :" + b);
            Console.WriteLine("Price   :" + p);
            Console.WriteLine("Memory  :" + m);
        }
        public void extra()
        {
            Console.WriteLine("Excess features: 3D touch & Face Recognition");
        }
    }
    public class Iphone_Xr : Iphone
    {
        public override void features(string c, string s, string b, int p, string m)
        {
            Console.WriteLine("Camera  :" + c);
            Console.WriteLine("Screen  :" + s);
            Console.WriteLine("Battery :" + b);
            Console.WriteLine("Price   :" + p);
            Console.WriteLine("Memory  :" + m);
        }
        public void extra()
        {
            Console.WriteLine("Excess features: 3D touch & Face Recognition");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iphone_6 a = new Iphone_6();
            Iphone_7s b = new Iphone_7s();
            Iphone_8_plus c = new Iphone_8_plus();
            Iphone_Xs d = new Iphone_Xs();
            Iphone_Xr e = new Iphone_Xr();
            Console.WriteLine("Iphone_6");
            a.common();
            a.features("5MP", "4'7", "2500mAh", 17000, "16gb");
            Console.WriteLine("\nIphone_7S");
            b.common();
            b.features("8MP", "4'9", "3000mAh", 45000, "32gb");
            b.extra();
            Console.WriteLine("\nIphone_8_Plus");
            c.common();
            c.features("12MP", "4'11", "3500mAh", 70000, "64gb");
            c.extra();
            Console.WriteLine("\nIphone_XS");
            d.common();
            d.features("40MP", "5'5", "5000mAh", 103000, "256gb");
            d.extra();
            Console.WriteLine("\nIphone_XR");
            e.common();
            e.features("24MP", "5'0", "4000mAh", 59000, "128gb");
            e.extra();
            Console.WriteLine("\n");
            Console.Read();
        }
    }
}

