using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa");
            Pessoa p = new Pessoa();

            Console.Write("Por favor, informe o nome da pessoa: ");
            p.Nome = Console.ReadLine();

            Console.Write("Informe o ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
