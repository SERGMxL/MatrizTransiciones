using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatrizTransiciones
{
    private string Entrada;
    private int[,] MT;
    private int Estado;

    public MatrizTransiciones()
    {
        Estado = 0;
        MT = new int[6, 6]
        {
            //         0     1     2     3     4     5
            //       dig   .     ;     esp   letra  "
            /* 0 */ {  1,   -1,   -1,   -1,   4,    5 },
            /* 1 */ {  1,    2,  100,  100,  -1,   -1 },
            /* 2 */ {  3,   -1,   -1,   -1,   -1,   -1 },
            /* 3 */ {  3,   -1,  200,  200,  -1,   -1 },
            /* 4 */ {  4,   -1,  300,  300,   4,   -1 },
            /* 5 */ {  5,    5,  400,  400,   5,    6 },
            /* 6 */ { -1,   -1,  500,  500,  -1,   -1 }
        };
    }

    public void SetEntrada(string entrada)
    {
        this.Entrada = entrada;
    }

    public void AnalizarEntrada()
    {
        foreach (char caracter in Entrada)
        {
            if (Char.IsDigit(caracter))
            {
                Estado = MT[Estado, 0];
            }
            else if (caracter == '.')
            {
                Estado = MT[Estado, 1];
            }
            else if (caracter == ';')
            {
                Estado = MT[Estado, 2];
            }
            else if (caracter == ' ')
            {
                Estado = MT[Estado, 3];
            }
            else if (Char.IsLetter(caracter))
            {
                Estado = MT[Estado, 4];
            }
            else if (caracter == '"')
            {
                Estado = MT[Estado, 5];
            }
            else
            {
                Estado = -1;
            }

            if (Estado == -1)
            {
                break;
            }
        }

        if (Estado < 100)
        {
            Estado = -1;
        }
    }

    public int GetEstado()
    {
        return Estado;
    }
}
