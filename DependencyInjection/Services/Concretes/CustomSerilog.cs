using DependencyInjection.Services.Abstracts;

namespace DependencyInjection.Services.Concretes;

public class CustomSerilog : ILog
{
    private string _msj { get; set; }

    public CustomSerilog(string msj)
    {
        _msj = msj;
    }

    public void Log()
    {
        Console.WriteLine($"Custome Serilog isledi: {_msj}");
    }
}
