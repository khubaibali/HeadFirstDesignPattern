using CommandPattern.FirstImplementation;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Light light = new Light();
            LightOnCommand lightCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            RemoteControl remote = new RemoteControl(lightCommand);
            remote.ButtonPressed();
            remote.SetCommand(lightOffCommand);
            remote.ButtonPressed();


        }
    }
}