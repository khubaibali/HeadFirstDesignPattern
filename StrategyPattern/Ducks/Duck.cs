using StrategyPattern.FlyBehaviour;
using StrategyPattern.QuackBehaviour;

namespace StrategyPattern.Ducks;
public abstract class Duck
{
    IFly FlyBehaviour = null!;
    IQuack QuckSound = null!;
    public Duck(IFly fly,IQuack quack)
    {
        this.FlyBehaviour = fly;
        this.QuckSound = quack;
    }

    public void SetFlyBehaviour(IFly fly)
    {
        FlyBehaviour = fly;
    }
    public void SetQuackSound(IQuack quack)
    {
        QuckSound = quack;
    }

    public void PerformFly()
    {
        this.FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        this.QuckSound.Quack();
    }

}
