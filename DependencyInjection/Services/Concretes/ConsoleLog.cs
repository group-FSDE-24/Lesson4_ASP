using DependencyInjection.Services.Abstracts;

namespace DependencyInjection.Services.Concretes;

public class ConsoleLog : ILog
{
    public void Log()
    {
        Console.WriteLine("Console Log isledi");
    }
}
