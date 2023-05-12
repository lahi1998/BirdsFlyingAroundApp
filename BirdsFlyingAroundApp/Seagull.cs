using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class Seagull : Birds, IFlying
    {
        public int HUNGER
        {
            get { return Hunger; }
            set { Hunger = value; }
        }

        public Seagull(int hunger)
        {
            HUNGER = hunger;
        }

        public void Fly()
        {
            if (Hunger < 50)
            {
                Console.Clear();
                Console.WriteLine("Seagull flyes around looking for food.");
                Thread.Sleep(1500);
                Eat();
            }
        }

        public override void Eat()
        {
            Console.Clear();
            Hunger = Hunger + 23;
            Console.WriteLine("Seagull eats trash.");
            Thread.Sleep(1500);
        }

        public override void Walk()
        {
            Console.Clear();
            Console.WriteLine("Seagull walks around.");
            Thread.Sleep(1500);
            Hunger = Hunger - 15;
        }

        public override void Sound()
        {
            Console.Clear();
            Console.WriteLine("squawk squawk!!");
            Thread.Sleep(1500);
        }
    }
}
