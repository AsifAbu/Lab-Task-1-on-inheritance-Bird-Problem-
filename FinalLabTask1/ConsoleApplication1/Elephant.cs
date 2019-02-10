using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Elephant : Animal
    {
        static float food =1000;
        static float f = 0;

        public void Sleep()
        {
            Console.WriteLine("Elephant Is Going To Sleeping");
            Animal.isHungry = true;
        }
        public override void Eat(float fo)
        {
            f += fo;
            if (Animal.isHungry == true)
            {
                if (f < food)
                {
                    Console.WriteLine("Elephant Eat " + f + " Food Fully And Elephant Is Hungry Now.");
                    Animal.isHungry = true;
                }
                else if (f == food)
                {
                    Console.WriteLine("Elephant Eat " + f + " Food Fully.And Elephant Is Not Hungry Now.");
                    Animal.isHungry = false;
                    f = 0;
                    Sleep();
                }
                else if (f > food)
                {
                    Console.WriteLine("Elephant Eat 1000 Food Fully.And Elephant Is Not Hungry Now. And Elephant Waste " + (f - food) + " Food.");
                    Animal.isHungry = false;
                    Sleep();
                }
            }
            else
                Console.WriteLine("Cat Is Not Hungry.");
        }
        
    }
}
