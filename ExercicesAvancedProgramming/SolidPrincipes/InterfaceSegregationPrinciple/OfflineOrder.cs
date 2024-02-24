using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.InterfaceSegregationPrinciple
{
    internal class OfflineOrder : IOrder
    {
        public void AddToCart() 
        {
            throw new NotImplementedException();
        }
    }
}
