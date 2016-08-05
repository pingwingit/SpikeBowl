using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpikeBowl.Engine.Interfaces;

namespace SpikeBowl.Engine.TestClasses
{
    class TestController : IController
    {
        private Queue<bool> RerollResponses;

        public TestController(IEnumerable<bool> RerollResponses)
        {
            this.RerollResponses = new Queue<bool>(RerollResponses);
        }


        public bool ProcessRerollRequest(Team activeTeam, RerollRequestMessages message, string moreInfo)
        {
            throw new NotImplementedException();
        }
    }
}
