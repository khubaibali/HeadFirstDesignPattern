using StrategyPattern.Ducks;
using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;

namespace StrategyPattern
{
    internal class Program
    {
        // strategy pattern allows to encapsulate the family of algorithms.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Duck greenDuck = new GreenDuck(new FlyHigh() , new LoudQuck());
            greenDuck.PerformQuack();
            greenDuck.PerformFly();
            greenDuck.SetFlyBehaviour(new LowFly());
            greenDuck.PerformFly();

        }
    }
}