﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine.Interfaces
{
    interface DiceManager
    {
        DiceResult RollDice(RollTypes rollType);
    }
}
