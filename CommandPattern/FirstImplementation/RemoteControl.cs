namespace CommandPattern.FirstImplementation;

public class RemoteControl
{
    ICommand command = null;

    public RemoteControl(ICommand command)
    {
        this.command = command;
    }

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void ButtonPressed()
    {
        command.Execute();
    }
}
