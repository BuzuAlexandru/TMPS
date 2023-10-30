namespace Kitchen;

public interface ILogger
{
    public void Log(string message);

    public List<string> GetLogs();
}
