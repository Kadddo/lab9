public class Logger
{
    private static Logger instance;
    private List<string> logs = new List<string>();

    private Logger() { }

    public static Logger GetInstance()
    {
        if (instance == null)
            instance = new Logger();
        return instance;
    }

    public void AddLog(string message)
    {
        logs.Add(DateTime.Now + ": " + message);
    }

    public List<string> GetLogs()
    {
        return logs;
    }
}