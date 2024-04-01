namespace Singleton;

public class AppState
{
    private static AppState? _instance;

    private AppState()
    {

    }

    public static AppState GetInstance()
    {
        if (_instance == null)
            _instance = new AppState();

        return _instance;
    }

    public string State;
}
