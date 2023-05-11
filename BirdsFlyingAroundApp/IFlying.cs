﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal interface IFlying
    {
        internal int Height { get; set; }
        internal int FlightTime { get; set; }

        void Fly();
    }
}
