using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Interfaz
{
    private string Entrada;

    public void PedirEntrada()
    {
        Console.WriteLine("Ingrese una cadena de entrada: ");
        Entrada = Console.ReadLine();
    }

    public string GetEntrada()
    {
        return Entrada;
    }

    public void ImprimirEstado(int Estado)
    {
        switch (Estado)
        {
            case 100:
                Console.WriteLine("Estado 100");
                break;
            case 200:
                Console.WriteLine("Estado 200");
                break;
            case 300:
                Console.WriteLine("Estado 300");
                break;
            case 400:
                Console.WriteLine("Es el inicio de una cadena de texto.");
                break;
            case 500:
                Console.WriteLine("Estado 400");
                break;
            default:
                Console.WriteLine("Error: Entrada no reconocida.");
                break;
        }
        Console.ReadKey();
    }
}
