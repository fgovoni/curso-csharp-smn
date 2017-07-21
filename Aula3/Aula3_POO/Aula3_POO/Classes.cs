using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_POO
{
    public class Eletronico : IEletronico
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Valor { get; set; }
        protected int Teste { get; set; }
        public virtual int Temperatura()
        {
            return 10;
        }
        public int Temperatura(int temperatura)
        {
            return 10 + temperatura;
        }
        public int Temperatura(int temperatura, bool ambienteQuente)
        {
            if (ambienteQuente)
                return 2 * (10 + temperatura);
            else
                return 10 - temperatura;
        }
        public string EmitirSom(string som)
        {
            return som;
        }

        public string RetornaDescricao(int temperatura)
        {
            return "as9asd8as78as";
        }
    }

    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public Moto Moto { get; set; }
    }

    public class Moto
    {
        public Rodas Rodas { set; get; }
    }
    public class Rodas
    {
        public Fornecedor Forncedor { get; set; }
    }
    public class Fornecedor
    {
        public Rodas Rodas { get; set; }
    }
    public class Operadores
    {
        public static void Somar(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Subtrair(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Dividir(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Multiplicar(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }

    public class Geladeira : Eletronico
    {
        public Geladeira(String marca, int valor)
        {
            Marca = marca;
            Valor = Valor;
        }
        public int QuantidadeLitros { get; set; }
        public bool LuzAcesa { get; set; }
        public override int Temperatura()
        {
            return base.Temperatura() + 2;
        }
        public void AcenderApagarLuz()
        {
            string auxiliar;
            if (LuzAcesa)
            {
                LuzAcesa = false;
                auxiliar = "apagada";
            }
            else
            {
                LuzAcesa = true;
                auxiliar = "acesa";
            }

            Console.WriteLine($"A luz da geladeira está {auxiliar}");
        }
        
    }

    public class Radio : Eletronico
    {
        public Radio(String marca, int valor)
        {
            Marca = marca;
            Valor = Valor;
        }
        public string[] Estacoes { get; set; }
        public override int Temperatura()
        {
            return base.Temperatura() - 5;
        }
    }
}