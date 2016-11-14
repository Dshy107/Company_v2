using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        private int workHours;
        
        public JuniorManager(string name, int workHours) : base(name)
        {
            this.workHours = workHours;
        }
        public override bool IsBonusPaidOut()
        {
            if (workHours > 180)
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
