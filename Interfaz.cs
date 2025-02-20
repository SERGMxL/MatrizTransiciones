using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatrizTransiciones
{
    private string _Entrada;
    private int[,] _MT;
    private int _Estado;

    public MatrizTransiciones()
    {
        _Estado = 0;
        _MT = new int[7, 7] // Aumentar el tamaño de la matriz para incluir el guion bajo
        {
            //         0     1     2     3     4     5     6
            //       dig   .     ;     esp   letra  "     _
            /* 0 */ {  1,   -1,   -1,   -1,   4,    5,    4 },
            /* 1 */ {  1,    2,  100,  100,  -1,   -1,   -1 },
            /* 2 */ {  3,   -1,   -1,   -1,   -1,   -1,   -1 },
            /* 3 */ {  3,   -1,  200,  200,  -1,   -1,   -1 },
            /* 4 */ {  4,   -1,  300,  300,   4,   -1,    4 },
            /* 5 */ {  5,    5,   -1,   -1,   5,    6,   -1 },
            /* 6 */ { -1,   -1,  500,  500,  -1,   -1,   -1 }
        };
    }

    public void SetEntrada(string entrada)
    {
        _Entrada = entrada;
    }

    public void AnalizarEntrada()
    {
        bool empiezaConComillas = false;
        foreach (char caracter in _Entrada)
        {
            if (Char.IsDigit(caracter))
            {
                _Estado = _MT[_Estado, 0];
            }
            else if (caracter == '.')
            {
                _Estado = _MT[_Estado, 1];
            }
            else if (caracter == ';')
            {
                _Estado = _MT[_Estado, 2];
            }
            else if (caracter == ' ')
            {
                _Estado = _MT[_Estado, 3];
            }
            else if (Char.IsLetter(caracter))
            {
                _Estado = _MT[_Estado, 4];
            }
            else if (caracter == '"')
            {
                if (_Estado == 0)
                {
                    empiezaConComillas = true;
                }
                _Estado = _MT[_Estado, 5];
            }
            else if (caracter == '_')
            {
                _Estado = _MT[_Estado, 6];
            }
            else
            {
                _Estado = -1;
            }

            if (_Estado == -1)
            {
                break;
            }
        }

        if (_Estado == 6 && empiezaConComillas)
        {
            _Estado = 500;
        }
        else if (_Estado < 100)
        {
            _Estado = -1;
        }
    }

    public int GetEstado()
    {
        return _Estado;
    }
}
