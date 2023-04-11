using System;
using System.Collections.Generic;
using System.Linq;

namespace any_all_contains
{
    class Program
    {
        private static List<int> notas = new List<int> { 500, 600, 700, 800, 900 };

        static void Main(string[] args)
        {
            var any = notas.Any(n => n > 700);
            var all = notas.All(n => n > 500);
            var contains = notas.Contains(900);

            Console.WriteLine("Any: " + any);
            Console.WriteLine("All: " + all); 
            Console.WriteLine("Contains: " + contains);   
        }
    }
}