using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDogs = 0, countCats = 0, countFishs = 0;

            Console.Write("Quantos animais você deseja inserir? ");
            int quantityAnimals = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Animal[] animal = new Animal[quantityAnimals];

            Console.WriteLine("Controle de animais\n");

            for (int i = 0; i < quantityAnimals; i++)
            {
                animal[i] = new Animal();

                Console.Clear();

                Console.Write($"Informe o nome do {i+1}º animal: ");
                animal[i].Name = Console.ReadLine();

                Console.Clear();

                Console.Write($"Informe o tipo do {i+1}º animal: ");
                animal[i].Species = Console.ReadLine();

                Console.Clear();

                if (animal[i].Species == "Cachorro") { countDogs++; }
                if (animal[i].Species == "Gato") { countCats++; }
                if (animal[i].Species == "Peixe") { countFishs++; }
            }

            foreach(Animal especie in animal)
            {
                Console.WriteLine($"Nome: {especie.Name} - Especie: {especie.Species}");
            }

            Console.WriteLine("\nTotal de Animais\n");
            Console.WriteLine($"Cachorros: {countDogs}, Gatos: {countCats}, Peixes: {countFishs}");
            Console.ReadKey();

        }
    }
}
