using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        protected string program = "PC";
    }
    class Instruct : Program
    {
        string brand_name;
        int cost;
        string memorysize;
        public void detailsInfo(string b, int c, string m)
        {
            brand_name = b;
            cost = c;
            memorysize = m;

        }

        public void higher()
        {
            Console.WriteLine($"Type: {program}\nbrand_name: {brand_name}\ncost:{cost}\nmemorysize:{memorysize} ");

        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Instruct h1 = new Instruct();
            h1.detailsInfo("Lenovo", 28000, "2TB");
            h1.higher();
            h1.detailsInfo("Dell", 38000, "1TB");
            h1.higher();
            h1.detailsInfo("HP", 68000, "3TB");
            h1.higher();
            Console.ReadKey();
        }
    }
}
