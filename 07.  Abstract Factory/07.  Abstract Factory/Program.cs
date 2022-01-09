public class Program
{
    public static void Main(string[] args)
    {
        TransportApp app = ConfigureApplication("Uber");
        app.StartRoute();
    }

    public static TransportApp ConfigureApplication(string company)
    {
        ITransportFactory transportFactory;
    
        if (company == "Uber")
        {
            transportFactory = new UberTransportFactory();
        }
        else
        {
            transportFactory = new NineNineTransportFactory();
        }

        return new TransportApp(transportFactory);
    }
}