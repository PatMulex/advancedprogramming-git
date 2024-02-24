using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.DependencyInjectionPrinciple
{
    public class AutomobileController
    {
        readonly IAutomobile m_automobile;
        public AutomobileController(IAutomobile automobile) => this.m_automobile = automobile;

        public void Ignition() => m_automobile.Ignition();
        public void Stop() => m_automobile.Stop();
    }
}
