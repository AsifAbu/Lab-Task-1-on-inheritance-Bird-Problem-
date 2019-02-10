using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Animal : ISleepable
    {

        internal static bool isHungry = true;

        abstract public void Eat(float f);
        
        void ISleepable.Sleep()
        {
            Console.WriteLine("Animal is Sleeping");
        }
        
        static void Main(string[] args)
        {
            Animal a = new Elephant();

            //a.Eat(1500);
            Animal c = new Cat();

            c.Eat(2);

            Console.ReadLine();
        }
    }
}
