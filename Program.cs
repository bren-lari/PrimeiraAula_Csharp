using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
           string a = Console.ReadLine();

           string resultado = "\r\nBem vindo, " + a;

           Console.WriteLine(resultado);
        }
    }
}
