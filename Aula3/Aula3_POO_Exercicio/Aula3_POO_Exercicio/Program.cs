using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_POO_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var tecnico = new Tecnico();
            tecnico.BonusSalarial = 100;
            tecnico.ExibeDados("Joao");

            Console.WriteLine(tecnico.ExibeDados("Joao"));
            Console.ReadKey();
        }
    }
}
