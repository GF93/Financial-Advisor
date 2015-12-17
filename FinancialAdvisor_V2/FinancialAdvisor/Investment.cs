using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAdvisor
{
    class Investment
    {
        public double years { get; set; } 
        public double pVal { get; set; }
        public double fVal { get; set; }
        public double interest { get; set; }



        public double calculateYears (double pv, double fv, double i)
        {
            double num = Math.Log(fv / pv);
            double denom = Math.Log(1 + i);
            return num / denom;

        } 

    }
}
