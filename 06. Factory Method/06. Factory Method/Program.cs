public class Program
{
    public static void Main(string[] args)
    {
        TransportFactory transport = null;

        if (args.Length > 0 && args[0] == "--uber")
        {
            transport = new CarFactory();
        }
        else if (args.Length > 0 && args[0] == "--log")
        {
            transport = new MotorcycleFactory();
        }
        else
        {
            Console.WriteLine("Selecione o tipo da entrega.");
        }

        if (transport != null)
        {
            transport.StartTransport();
        }
    }
}