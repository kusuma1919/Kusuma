using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    interface Animal
    {
        void noise();
    }
    class Lion : Animal

    {
        public void noise()
    {
            Console.WriteLine("Lion Noise");
    }
    }
class Tiger : Animal

{
        public void noise()
{
            Console.WriteLine("Tiger Noise");
}
}
    class Zoo
{
    public static void Main(String[] args)
    {
        makeSound(new Tiger());
        makeSound(new Lion());
            Console.ReadKey();
        }
    public static void makeSound(Animal a1)
    {
        a1.noise();
            
    }
}
   }
