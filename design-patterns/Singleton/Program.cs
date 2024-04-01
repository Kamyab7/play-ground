using Singleton;

var instance1 = AppState.GetInstance();

instance1.State = "App is Running";

var instance2 = AppState.GetInstance();

if (instance1.State == instance2.State)
{
    Console.WriteLine("instances are same.");
}
else 
{
    Console.WriteLine("instances are not same.");
}

Console.ReadKey();
