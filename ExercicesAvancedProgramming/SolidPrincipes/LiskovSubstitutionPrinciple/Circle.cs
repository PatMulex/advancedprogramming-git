using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.LiskovSubstitutionPrinciple
{
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
