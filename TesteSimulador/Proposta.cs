using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TesteSimulador
{
    public class Proposta
    {
        // DADOS DO CLIENTE
        public string NomeCliente { get; set; }

        public decimal ValorBem { get; set; }

        public int Prazo { get; set; }

        public decimal TaxaAdmin { get; set; }

        public decimal TaxaAdesao { get; set; }

        public decimal TaxaReserva { get; set; }

        public string Administradora { get; set; }

        public decimal Lance { get; set; }

        public int TipoLance { get; set; }

        public int QuantidadeParcelasAdesao { get; set; }

        public Proposta()
        {
            NomeCliente = "";
            Administradora = "";

            ValorBem = 0;
            Prazo = 0;

            TaxaAdmin = 0;
            TaxaAdesao = 0;
            TaxaReserva = 0;

            Lance = 0;

            TipoLance = 1;

            QuantidadeParcelasAdesao = 2;
        }
    }
    
}
    
