﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine.Interfaces
{
    interface SBClient
    {
        bool RerollRequest(int diceResult, int target, RerollRequestMessages message);

    }
}
