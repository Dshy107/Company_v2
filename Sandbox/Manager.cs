using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Manager : Employee
    {
        private int salaryPrMonth;
        private int bonusPrMonth;
     

        public Manager(string name) : base(name)
        {
            this.salaryPrMonth = 20000;
            this.bonusPrMonth = 5000;
        }

        public override int GetBonusPerMonth()
        {
            return bonusPrMonth;
        }

        public override int GetSalaryPerMonth()
        {
            return salaryPrMonth;
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
