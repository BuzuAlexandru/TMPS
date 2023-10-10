namespace Kitchen;

public class Logger
{
    private static readonly Logger _instance = new();
    private readonly List<string> _log = new();

    static Logger(){}

    private Logger(){}

    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now}: {message}";
        _log.Add(logEntry);
    }

    public List<string> GetLogs()
    {
        return _log;
    }
}
