using System;

namespace ProjetoRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Tecnico");
            Tecnico t = new Tecnico("Ana", 19, "Adm", 9989.3);
            t.MostrarDados();
            t.Cumprimentar();

            Console.WriteLine("Quantidade Técnico " +
                Tecnico.Quantidade);

            Console.WriteLine("Criando Outro Tecnico");
            Tecnico tt = new Tecnico("Bruno", 20, "Aux", 5289.3);
            tt.MostrarDados();
            tt.Cumprimentar();
            Console.WriteLine("Quantidade Técnico " +
                Tecnico.Quantidade);

            Professor p = new Professor();

            Sistema.CalcularAumento(t, 1.1);

        }
    }
}
