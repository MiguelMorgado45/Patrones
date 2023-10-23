using Spectre.Console;

namespace Patrones.Factory.Entity;

public class OrdenSuadero
{
    public void PrepararTacos()
    {
        AnsiConsole.WriteLine($"Asando carne de suadero");
        AnsiConsole.WriteLine("Preparando los tacos");
    }

    public void CobrarOrden()
    {
        AnsiConsole.WriteLine($"Cobrando $65.5");
    }

    public void EntregarOrden()
    {
        AnsiConsole.WriteLine($"Mandando ordén de 3 tacos");
    }
}