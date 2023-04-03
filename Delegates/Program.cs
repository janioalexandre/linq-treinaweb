using System;

namespace Delegates
{
    delegate void ExibirMensagem(string texto);

    class Program
    {
        static void Main(string[] args)
        {
            Action<string> exibir = informacao => Console.WriteLine($"INFORMAÇÂO: {informacao}");
            exibir("Testando");

            Func<int, int, int> realizarOperacao = (a, b) => a + b;
            Console.WriteLine(realizarOperacao(1, 2));

            Predicate<int> verificar = a => a % 2 == 0;
            Console.WriteLine(verificar(1));
            
        /*
        Action<string> exibir = ExibirInformacao;
        exibir("Testando");

        Func<int, int, int> realizarOperacao = Somar;
        Console.WriteLine(realizarOperacao(1, 2));

        Predicate<int> verificar = EhPar;
        Console.WriteLine(verificar(1));
        */
        }
        

        static void ExibirInformacao(string informacao)
        {
            Console.WriteLine($"INFORMAÇÂO: {informacao}");
        }

        static void ExibirErro(string informacao)
        {
            Console.WriteLine($"Erro: {informacao}");
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static bool EhPar(int a)
        {
            return a % 2 == 0;
        }
    }
}