using DependencyInjection.Services.Abstracts;

namespace DependencyInjection.Services.Concretes;

public class FileLog : ILog
{
    public void Log()
    {
        Console.WriteLine("File Log isledi");
    }
}
