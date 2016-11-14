using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int performancelevel;

        public SeniorManager(string name, int performancelevel) : base(name)
        {
            this.performancelevel = performancelevel;
        }
        public override bool IsBonusPaidOut()
        {
            if (performancelevel >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
