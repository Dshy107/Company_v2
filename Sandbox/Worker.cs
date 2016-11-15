using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private int workHouresPrMonth;
        private int payPrHour;

        public Worker(string name) : base(name)
        {
            this.payPrHour = 200;
            this.workHouresPrMonth = 50;
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override int GetSalaryPerMonth()
        {
            return payPrHour * workHouresPrMonth;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
