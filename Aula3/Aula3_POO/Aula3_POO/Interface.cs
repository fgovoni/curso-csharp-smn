using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_POO
{
    interface IEletronico
    {
        int Temperatura(int temperatura);
        string EmitirSom(string som);
        string RetornaDescricao(int temperatura);
    }
}
