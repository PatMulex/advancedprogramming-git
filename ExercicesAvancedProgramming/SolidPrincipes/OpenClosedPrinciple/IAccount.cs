using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.OpenClosedPrinciple
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        decimal CalculInterest();
    }
}
