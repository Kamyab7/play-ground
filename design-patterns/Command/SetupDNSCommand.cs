namespace Command;

public class SetupDNSCommand : ICommand
{
    public void Execute()
    {
        Task.Delay(5000).Wait();
        Console.WriteLine("Setup DNS records");
    }
}
