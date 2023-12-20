using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;

namespace StrategyPattern.Ducks;

public class GreenDuck : Duck
{
    public GreenDuck(IFly fly, IQuack quack) : base(fly, quack) // here we are programming to implementation 
    {
    }
}
