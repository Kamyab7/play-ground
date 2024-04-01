namespace Command;

public class DeployCommand : ICommand
{
    public void Execute()
    {
        Task.Delay(3000).Wait();
        Console.WriteLine("Deploying the project");
    }
}
