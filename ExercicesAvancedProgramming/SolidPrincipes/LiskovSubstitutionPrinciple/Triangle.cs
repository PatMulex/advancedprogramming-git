using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.LiskovSubstitutionPrinciple
{
    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "triangle";
        }
    }
}
