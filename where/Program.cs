using System;
using System.Collections.Generic;
using System.Linq;

namespace Where
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Descricao = "Arroz", Categoria = "Cereais", Preco = 4.89m },
            new Produto { Descricao = "Feijão", Categoria = "Cereais", Preco = 8.19m },
            new Produto { Descricao = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
            new Produto { Descricao = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
        };

        static void Main(string[] args)
        {
            /*
            //  Filtrando coleções com Where        

            // var resultado = produtos.Where(p => p.Preco < 5);
            // var resultado = produtos.Where(p => p.Categoria == "Cereais");
            var resultado = produtos.Where(p => p.Descricao.Contains("De") && p.Preco < 3);

            foreach (var r in resultado)
            {
                Console.WriteLine(r);
            }
            

            // Recuperando um elemento: First, Single e Last

            var primeiro = produtos.First(p => p.Descricao.Contains("De"));
            var ultimo = produtos.Last(p => p.Descricao.Contains("De"));
            var arroz = produtos.Single(p => p.Descricao == "Arroz");

            Console.WriteLine(primeiro);
            

            // Limitando a quantidade de registros com Take 

            var resultado = produtos.Take(2);

            foreach(var r in resultado)
            {
                Console.WriteLine(r);
            }
            

            // Avançando registros com o método Skip

            var resultado = produtos.Skip(1);

            foreach(var r in resultado)
            {
                Console.WriteLine(r);
            }
            */

            // Ordenando o resultado: OrderBy e OrderByDescending / Ordenações secundárias: ThenBy e ThenByDescending   

            /*
            var resultado = produtos.OrderBy(p => p.Categoria).ThenBy(p => p.Preco);

            foreach(var r in resultado)
            {
                Console.WriteLine(r);
            } 
            */

            // Mudando a forma do retorno com o méthodo Select

            /*
            var resultado = produtos.Select(p => new { p.Descricao, PrecoComAcrescimo = p.Preco * 1.1m });

            foreach (var p in resultado)
            {
                Console.WriteLine(p);        
            }
            */

            // Resultados distintos com Distinct
            
            var categorias = produtos.Select(p => p.Categoria).Distinct();

            foreach (var c in categorias)
            {
                Console.WriteLine(c);
            }
        }
    }
}