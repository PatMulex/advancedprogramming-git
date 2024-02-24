using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.InterfaceSegregationPrinciple
{
    internal class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            throw new NotImplementedException();
        }

        public void CCProcess()
        {
            throw new NotImplementedException();
        }
    }
}
