
Timer timer = new Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));

Console.ReadLine();


static void TimerCallback(object? state)
{
    // This function will be executed when the timer elapses
    Console.WriteLine("Function executed at: " + DateTime.Now);
    // Call your desired function here
}