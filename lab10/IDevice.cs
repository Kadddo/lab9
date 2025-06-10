public interface IMessageFormatter
{
    string Format(string message);
}

public class TextFormatter : IMessageFormatter
{
    public string Format(string message) => message;
}

public class HtmlFormatter : IMessageFormatter
{
    public string Format(string message) => $"<p>{message}</p>";
}

// Засіб доставки
public abstract class MessageSender
{
    protected IMessageFormatter formatter;

    public MessageSender(IMessageFormatter formatter)
    {
        this.formatter = formatter;
    }

    public abstract void Send(string message);
}

public class EmailSender : MessageSender
{
    public EmailSender(IMessageFormatter formatter) : base(formatter) { }

    public override void Send(string message)
    {
        Console.WriteLine($"Email sent: {formatter.Format(message)}");
    }
}

public class SmsSender : MessageSender
{
    public SmsSender(IMessageFormatter formatter) : base(formatter) { }

    public override void Send(string message)
    {
        Console.WriteLine($"SMS sent: {formatter.Format(message)}");
    }
}