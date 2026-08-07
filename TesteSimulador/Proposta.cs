using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class Proposta
    {
        public string NomeCliente { get; set; }
        public string Administradora { get; set; }
        public decimal ValorBem { get; set; }
        public int Prazo { get; set; }
        public int QuantidadeParcelasAdesao { get; set; }
        public int TipoLance { get; set; }
    }
}
