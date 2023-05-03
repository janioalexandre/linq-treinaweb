using System;
using System.Collections.Generic;
using System.Linq;

namespace Where
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Categoria = "Informática", Preco = 8000 },
            new Produto { Nome = "Monitor", Categoria = "Informática", Preco = 1000 },
            new Produto { Nome = "Cama", Categoria = "Moveis", Preco = 2000 },
            new Produto { Nome = "Armario", Categoria = "Moveis", Preco = 3000 }
        };

        private static List<Promocao> promocoes = new List<Promocao> 
        {
            new Promocao { Categoria = "Informática", Desconto = 10 },
            new Promocao { Categoria = "Moveis", Desconto = 20 }
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

            /*
            var categorias = produtos.Select(p => p.Categoria).Distinct();

            foreach (var c in categorias)
            {
                Console.WriteLine(c);
            }
            */

            // Funções de agregação: Count, Max, Min, Sum, e Average

            /*
            var quantidade = produtos.Count(p => p.Categoria == "Limpeza");
            var maximo = produtos.Max(p => p.Preco);
            var minimo = produtos.Min(p => p.Preco);
            var soma = produtos.Sum(p => p.Preco);
            var media = produtos.Average(p => p.Preco);

            Console.WriteLine(quantidade);
            Console.WriteLine(maximo);
            Console.WriteLine(minimo);
            Console.WriteLine(soma);
            Console.WriteLine(media);
            */

            // Agrupando resultados com Join 
            var resultado = produtos.Join(promocoes,
                                          produto => produto.Categoria,
                                          promocao => promocao.Categoria,
                                          (produto, promocao) => new {
                                            produto.Nome,
                                            produto.Categoria,
                                            PrecoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))
                                          });

            foreach (var p in resultado)
            {
                Console.WriteLine($" { p.Nome } - { p.Categoria } - { p.PrecoComDesconto }");
            }                              
        }
    }
}