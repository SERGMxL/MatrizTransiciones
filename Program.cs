using System;

class Program
{
    private MatrizTransiciones mMatrizTransiciones;
    private Interfaz mInterfaz;

    public Program()
    {
        mMatrizTransiciones = new MatrizTransiciones();
        mInterfaz = new Interfaz();
    }

    public void Correr()
    {
        mInterfaz.PedirEntrada();
        mMatrizTransiciones.SetEntrada(mInterfaz.GetEntrada());
        mMatrizTransiciones.AnalizarEntrada();
        mInterfaz.ImprimirEstado(mMatrizTransiciones.GetEstado());
    }

    static void Main(string[] args)
    {
        Program mProgram = new Program();
        mProgram.Correr();
    }
}
