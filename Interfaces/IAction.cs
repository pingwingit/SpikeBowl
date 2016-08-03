using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public interface IAction
    {
        ActionResults actionResult { get; set; }

        ActionResults TryAction();

        bool ValidateAction();
    }    
}
