namespace StrategyPattern.FlyBehaviour;

public class LowFly : IFly
{
    public void Fly()
    {
        Console.WriteLine("Low flying bird");
    }
}
