using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.OpenClosedPrinciple
{
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; }

        public decimal CalculInterest() => (Balance * 3) / 100;
    }
}
