using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_LogicaDeProgramacao_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            var nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            var nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            var nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            var nota4 = int.Parse(Console.ReadLine());

            int resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado > 60)
            	Console.WriteLine("Aluno foi aprovado. Sua nota foi " + resultado);
            else
            	Console.WriteLine("O aluno foi reprovado. Sua nota foi " + resultado);
            Console.ReadKey();
        }
    }
}
