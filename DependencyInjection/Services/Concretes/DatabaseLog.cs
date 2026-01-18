using DependencyInjection.Services.Abstracts;

namespace DependencyInjection.Services.Concretes;

public class DatabaseLog : ILog
{
    public void Log()
    {
        Console.WriteLine("Database Log isledi");
    }
}
