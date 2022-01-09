public class Program
{
    public static void Main(string[] args)
    {
        StartLive(new Facebook());
        Console.WriteLine("");
        StartLiveAdvanced(new YouTube());
        Console.WriteLine("");
        StartLive(new TwitchTV());
    }

    public static void StartLive(IPlatform platform)
    {
        Console.WriteLine("Aguarde...");

        Live live = new Live(platform);

        live.Broadcasting();
        live.Result();
    }

    public static void StartLiveAdvanced(IPlatform platform)
    {
        Console.WriteLine("Aguarde...");

        AdvancedLive live = new AdvancedLive(platform);

        live.Broadcasting();
        live.Subtitle();
        live.Comments();
        live.Result();
    }
}