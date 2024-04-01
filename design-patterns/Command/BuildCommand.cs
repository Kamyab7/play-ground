namespace Command;

public class BuildCommand : ICommand
{
    public void Execute()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("Building the project");
    }
}
