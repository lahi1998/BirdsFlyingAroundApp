﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal interface IDiving_Water
    {
        internal int Depth { get; set; }
        internal int DiveTime { get; set; }

        void Diving();
    }
}
