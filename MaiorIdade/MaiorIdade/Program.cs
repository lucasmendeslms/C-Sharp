using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas você deseja cadastrar? ");
            int quantityPeople = int.Parse(Console.ReadLine());

            Console.Clear();

            Person[] person = new Person[quantityPeople];

            Console.WriteLine("Controle de pessoas\n");

            for (int i = 0; i < quantityPeople; i++) 
            {
                person[i] = new Person();

                Console.Clear();

                Console.Write($"Informe o nome da {i + 1}ª pessoa: ");
                person[i].Name = Console.ReadLine();

                Console.Clear();

                Console.Write($"Informe a data de aniversário da {i + 1}ª pessoa - Formato dd/mm/aaaa: ");
                person[i].BirthDate = DateTime.Parse(Console.ReadLine());

                Console.Clear();
            }


            foreach(Person people in person)
            {
                people.ExhibitData();
            }

            Console.ReadKey();
        }
    }
}
