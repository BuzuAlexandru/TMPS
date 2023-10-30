
namespace Kitchen;

public class LoggerProxy : ILogger
{
    private readonly ILogger logger;
    private readonly string password;

    public LoggerProxy(ILogger logr, string pswd)
    {
        logger = logr;
        password = pswd;
    }

    public List<string> GetLogs()
    {
        if(CheckAccess()) 
            return logger.GetLogs();
        else
            throw new Exception("Not authorized");
    }

    public void Log(string message)
    {
        if(CheckAccess()) 
            logger.Log(message);
        else
            throw new Exception("Not authorized");
    }

    public bool CheckAccess()
    {
        bool res = false;

        if(password == "1111") res = true;

        return res;
    }
}