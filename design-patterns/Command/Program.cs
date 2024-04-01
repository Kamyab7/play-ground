using Command;

List<ICommand> commands = new List<ICommand>();
commands.Add(new BuildCommand());
commands.Add(new DeployCommand());
commands.Add(new SetupDNSCommand());

foreach (ICommand command in commands)
    command.Execute();

Console.ReadKey();