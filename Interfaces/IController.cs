using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine.Interfaces
{
    public interface IController
    {
        bool ProcessRerollRequest(Team activeTeam, RerollRequestMessages message, string moreInfo);        
    }
}
