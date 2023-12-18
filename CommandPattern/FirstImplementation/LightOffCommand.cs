namespace CommandPattern.FirstImplementation;

public class LightOffCommand : ICommand
{
    private readonly Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        this.light.Off();
    }
}
