using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorPatternLearn
    {

        

        public static void RunDecoratorPattern()
        {
            Beverages drink = new Coffees();
            drink = new ChoclateAddOn(drink);
            drink = new ChoclateAddOn(drink);

            Console.WriteLine(drink.Cost());
        }

    }

    public abstract class Beverages
    {
        public string Description { get; set; }
        public abstract double Cost();
    }

    public class Coffees : Beverages
    {
        public override double Cost()
        {
            return 10;
        }
    }

    public abstract class AddOn : Beverages
    {
        public Beverages _beverages;
        public AddOn(Beverages beverages)
        {
            _beverages = beverages;
        }


    }

    public class ChoclateAddOn : AddOn
    {
        public ChoclateAddOn(Beverages beverages) : base(beverages) { }
        double price = 15;
        public override double Cost()
        {
            return this._beverages.Cost() + price;
        }
    }


   
}
