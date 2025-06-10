public class Settings
{
    private static Settings instance;

    public string Language { get; set; }
    public string WindowSize { get; set; }

    private Settings()
    {
        // Значення за замовчуванням
        Language = "uk-UA";
        WindowSize = "1280x720";
    }

    public static Settings GetInstance()
    {
        if (instance == null)
            instance = new Settings();
        return instance;
    }
}
