using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cat : Animal
    {
        static float food = 1f;
        static float f = 0f;
        public void Sleep()
        {
            Console.WriteLine("Cat Is Sleeping");
            Animal.isHungry = true;
        }
        public override void Eat(float fo)
        {
            f += fo;
            if (Animal.isHungry == true)
            {
                if (f < food)
                {
                    Console.WriteLine("Cat Eat " + f + " Food Fully And Cat Is Hungry Now.");
                    Animal.isHungry = true;
                }
                else if (f == food)
                {
                    Console.WriteLine("Cat Eat " + f + " Food Fully.And Cat Is Not Hungry Now.");
                    Animal.isHungry = false;
                    f = 0;
                    Sleep();
                }
                else if (f > food)
                {
                    Console.WriteLine("Cat Eat 1 Food Fully.And Cat Is Not Hungry Now. And Cat Waste " + (f - food) + " Food.");
                    Animal.isHungry = false;
                    Sleep();
                }
            }
            else
                Console.WriteLine("Cat Is Not Hungry.");
        }
        

    }
}
