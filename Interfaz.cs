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
                Console.WriteLine("Es un número entero.");
                break;
            case 200:
                Console.WriteLine("Es un número flotante.");
                break;
            case 300:
                Console.WriteLine("Es una variable.");
                break;
            case 400:
                Console.WriteLine("Es el inicio de una cadena de texto.");
                break;
            case 500:
                Console.WriteLine("Es una cadena de texto completa.");
                break;
            default:
                Console.WriteLine("Error: Entrada no reconocida.");
                break;
        }
        Console.ReadKey();
    }
}
