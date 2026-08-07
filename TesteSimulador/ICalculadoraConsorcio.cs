using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public interface ICalculadoraConsorcio
    {
        ResultadoSimulacao Calcular(ParametrosSimulacao p);
    }
}
