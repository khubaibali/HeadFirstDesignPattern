namespace StrategyPattern.QuackBehaviour;
public class LoudQuck : IQuack
{
    public void Quack()
    {
        Console.WriteLine("Very Loud Quack");
    }
}
