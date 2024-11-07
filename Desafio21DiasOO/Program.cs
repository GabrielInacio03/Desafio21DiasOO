using System;
using Desafio21DiasOO.Models;

namespace Desafio21DiasOO 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa gabriel = new Pessoa();
            gabriel.Id = 1;
            gabriel.Nome = "Gabriel";
            gabriel.Endereco = "Rua123";

            Pessoa maria = new Pessoa();
            maria.Id = 2;
            maria.Nome = "Maria";
            maria.Endereco = "Rua123";

            Pessoa joao = new Pessoa();
            joao.Id = 3;
            joao.Nome = "João";
            joao.Endereco = "Rua123";

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(gabriel);
            pessoas.Add(maria);
            pessoas.Add(joao); 
        }
    }
}