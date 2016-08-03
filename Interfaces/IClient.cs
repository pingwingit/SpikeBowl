using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine.Interfaces
{
    public interface IClient
    {
        bool RerollRequest(int diceResult, int target, RerollRequestMessages message);

    }
}
