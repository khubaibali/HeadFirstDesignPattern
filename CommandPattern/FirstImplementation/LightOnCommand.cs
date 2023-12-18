namespace CommandPattern.FirstImplementation;

public class LightOnCommand : ICommand
{
    Light light = null;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        this.light.On();
    }
}
