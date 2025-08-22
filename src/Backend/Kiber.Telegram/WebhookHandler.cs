namespace Kiber.Telegram;

public class WebhookHandler
{
    public Task HandleAsync(string updateJson)
    {
        Console.WriteLine(updateJson);
        return Task.CompletedTask;
    }
}
