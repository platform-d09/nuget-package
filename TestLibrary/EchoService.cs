namespace TestLibrary;

public class EchoService : IEchoService
{
    public string Echo(string message)
    {
        return message;
    }
}