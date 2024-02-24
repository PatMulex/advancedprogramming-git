using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.DependencyInjectionPrinciple
{
    public class Jeep : IAutomobile
    {
        public void Ignition() => Console.WriteLine("Jeep Start");

        public void Stop() => Console.WriteLine("Jeep stoped.");
    }
}
