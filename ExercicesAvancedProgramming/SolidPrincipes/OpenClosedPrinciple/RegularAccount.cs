using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.OpenClosedPrinciple
{
    public class RegularAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalculInterest()
        {
            decimal interest = (Balance * 4) / 100;

            if (Balance < 1000) interest -= (Balance * 2) / 100;
            if (Balance < 5000) interest -= (Balance * 4) / 100;

            return interest;
        }
    }
}
