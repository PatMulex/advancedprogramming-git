using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.OpenClosedPrinciple
{
    public class SalarayAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalculInterest() => (Balance * 5) / 100;
    }
}
