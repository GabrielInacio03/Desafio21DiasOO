using System;
using Desafio21DiasOO.Models;

namespace Desafio21DiasOO 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //receitas
            var chocolateBolo = new Receita("Bolo de Chocolate", "Grande", 2.0, 9.99);
            var pave = new Receita("Pave", "PEQUENO", 0.5, 5.00);
            var carneDePanela = new Receita("Carne de Panela", "MEDIO", 3.0, 19.99);

            //exibindo objetos
            Console.WriteLine(chocolateBolo.ToString());
            Console.WriteLine();
            Console.WriteLine(pave.ToString());
            Console.WriteLine();
            Console.WriteLine(carneDePanela.ToString());
            Console.WriteLine();
        }
    }
}