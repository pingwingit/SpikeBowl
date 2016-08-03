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

        void QueueActions(List<IAction> actions);

        void FeedbackToUI(List<IAction> actions);
        //in an actual client, this would tell the UI what has happened and wait until the UI has done whatever updates are necessary
    }
}
