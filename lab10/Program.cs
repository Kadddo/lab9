class Program
{
    static void Main()
    {
        // Singleton
        Logger.GetInstance().AddLog("Application started");
        Settings.GetInstance().Language = "en-US";

        // Builder Character
        var character = new HeroBuilder()
            .SetStrength(10)
            .SetAgility(8)
            .SetIntelligence(6)
            .Build();
        Console.WriteLine(character);

        // Builder SQL
        var sql = new SqlQueryBuilder()
            .Select("*")
            .Where("age > 18")
            .OrderBy("name")
            .Build();
        Console.WriteLine(sql);

        // Bridge Messages
        var emailSender = new EmailSender(new HtmlFormatter());
        emailSender.Send("Welcome!");

        var smsSender = new SmsSender(new TextFormatter());
        smsSender.Send("Your code is 1234");

        // Bridge Devices
        var remote = new RemoteControl(new TV());
        remote.TurnOnDevice();
        remote.TurnOffDevice();
    }
}
