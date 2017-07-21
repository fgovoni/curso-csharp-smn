using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];

            Eletronico eletronico1 = new Eletronico();
            eletronico1.Marca = "LG";

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Govoni";
            pessoa1.idade = 33;
            pessoas[0] = pessoa1;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "Sandra";
            pessoa2.idade = 30;
            pessoas[1] = pessoa2;

            Pessoa pessoa3 = new Pessoa
            {
                nome = "Jhonny",
                idade = 23
            };
            pessoas[2] = pessoa3;

            //foreach (var pessoa in pessoas)
            //{
            //    Console.WriteLine("Meu nome é: " + pessoa.nome);
            //}

            Eletronico eletronico2 = new Eletronico();
            //Console.WriteLine(eletronico2.Temperatura(10, true));

            //Operadores.Somar(3, 5);
            //Operadores.Subtrair(3, 5);
            //Operadores.Dividir(3, 5);
            //Operadores.Multiplicar(3, 5);


            var geladeira1 = new Geladeira("Consul", 2000);
            var radio1 = new Radio("Pioner", 340);
            geladeira1.Temperatura(10, false);

            //geladeira1.AcenderApagarLuz();
            //geladeira1.AcenderApagarLuz();

            Eletronico[] eletronicos = new Eletronico[2];

            eletronicos[0] = radio1;
            eletronicos[1] = geladeira1;

            //foreach (var eletronico in eletronicos)
            // {
            //    Console.WriteLine(eletronico.Temperatura());
            //}
            foreach (var eletronico in eletronicos)
            {
                Console.WriteLine($"Minha marca é {eletronico.Marca} e custo R$ {eletronico.Valor}");
            }

            //Console.WriteLine(geladeira1.EmitirSom("Zuuuuuuuuuu"));
            //Console.WriteLine(radio1.EmitirSom("Xiiiiiiii"));



            Console.ReadKey();
        }
    }
}
