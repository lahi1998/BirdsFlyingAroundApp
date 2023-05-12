using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class Penguin : Birds, IDiving_Water
    {
        public int HUNGER
        {
            get { return Hunger; }
            set { Hunger = value; }
        }

        public Penguin(int hunger)
        {
            HUNGER = hunger;
        }

        public void Diving()
        {
            if (Hunger < 50)
            {
                Console.Clear();
                Console.WriteLine("Penguin dives for food.");
                Thread.Sleep(1500);
                Eat();
            }
        }

        public override void Eat()
        {
            Console.Clear();
            Hunger = Hunger + 23;
            Console.WriteLine("Penguin eats.");
            Thread.Sleep(1500);
        }

        public override void Walk()
        {
            Console.Clear();
            Console.WriteLine("Penguin walks around.");
            Thread.Sleep(1500);
            Hunger = Hunger - 15;
        }

        public override void Sound()
        {
            Console.Clear();
            Console.WriteLine("Noot Noot!!");
            Thread.Sleep(1500);
        }
    }
}
