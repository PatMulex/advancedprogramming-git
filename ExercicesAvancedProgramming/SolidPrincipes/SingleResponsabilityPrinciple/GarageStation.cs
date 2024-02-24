using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesAvancedProgramming.SolidPrincipes.SingleResponsabilityPrinciple
{
    public class GarageStation
    {
        readonly IGarageUtility _iGarageUtility;

        public GarageStation (IGarageUtility iGarageUtility)
        {
            _iGarageUtility = iGarageUtility;
        }

        public void OpenForService() => _iGarageUtility.OpenGate();

        public void CloseGarage() => _iGarageUtility.CloseGate();

        public void DoService()
        {

        }
    }
}
