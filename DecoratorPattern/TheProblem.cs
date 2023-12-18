using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class TheProblem
    {
    }


public abstract class Beverage
    {
        public string Description;
        public float Cost()
        {
            float sum = 0;
            if (TopChoclate)
            {
                sum += HasTopChoclate();
            }
            if (TopBiscuits)
            {
                sum += HasTopBiscuits();
            }
            if (Butter)
            {
                sum += HasButter();
            }
            if (GreenSugar)
            {
                sum += HasGreenSugar();
            }
            return sum;
        }

        public float HasTopChoclate()
        {
            return 10;
        }
        public float HasTopBiscuits()
        {
            return 10;
        }
        public float HasButter()
        {
            return 10;
        }
        public float HasGreenSugar()
        {
            return 10;
        }

        // extra topping
        public bool TopChoclate;
        public bool TopBiscuits;
        public bool Butter;
        public bool GreenSugar;
    }

    public class Coffee : Beverage
    {
        float price = 15;
        public float Cost()
        {
            float otherCost = base.Cost();
            return otherCost + price;

        }
    }

    public class Pepsi : Beverage
    {
        public float Cost()
        {
            throw new NotImplementedException();
        }
    }


}
