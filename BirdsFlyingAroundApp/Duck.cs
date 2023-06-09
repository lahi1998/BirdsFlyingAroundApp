﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal class Duck : Birds, IFlying, IDiving_Water
    {
        public int HUNGER
        {
            get { return Hunger; }
            set { Hunger = value; }
        }

        public Duck(int hunger)
        {
            HUNGER = hunger;
        }

        public void Fly()
        {
            Console.Clear();
            Console.WriteLine("Duck Flyes to new area.");
            Thread.Sleep(1500);
        }

        public void Diving()
        {
            if (Hunger < 50)
            {
                Console.Clear();
                Console.WriteLine("Duck dives for food");
                Thread.Sleep(1500);
                Eat();
            }
        }

        public override void Eat()
        {
            Console.Clear();
            Hunger = Hunger + 23;
            Console.WriteLine("Duck eats.");
            Thread.Sleep(1500);
        }

        public override void Walk()
        {
            Console.Clear();
            Console.WriteLine("Duck walks around.");
            Thread.Sleep(1500);
            Hunger = Hunger - 15;
        }

        public override void Sound()
        {
            Console.Clear();
            Console.WriteLine("Quak Quak!!");
            Thread.Sleep(1500);
        }
    }
}
