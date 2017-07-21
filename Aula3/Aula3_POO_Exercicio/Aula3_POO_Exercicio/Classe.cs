using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_POO_Exercicio
{
    class Funcionario
    {
        public virtual string ExibeDados(string dados)
        {
            return dados;
        }
    }

    class Gerente : Funcionario
    {
       
    }

    class Assistente : Funcionario
    {
        public int NumMatricula { get; set; }
    }

    class Tecnico : Assistente
    {
        public decimal BonusSalarial { get; set;}
        public override string ExibeDados(string dados)
        {
            return $"Dados: {dados} \n Bonus Salarial: {BonusSalarial}";
        }
    }

    class Administrativo : Assistente
    {
        public string Turno { set; get; }
        public decimal AdNoturno { set; get; }
        
    }
}
