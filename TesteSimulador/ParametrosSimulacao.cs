using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public class ParametrosSimulacao
    {
        public decimal ValorCarta { get; set; }
        public int Prazo { get; set; } // em meses
        public decimal TaxaAdministracao { get; set; } // em % (ex: 18 = 18%)
        public decimal FundoReserva { get; set; }       // em % (ex: 2 = 2%)
        public decimal ValorAdesao { get; set; }
        public int QuantidadeParcelasAdesao { get; set; } // 0 ou 1 = à vista (vem de rdbConvencional/rdbMaisPorMenos)
        // --- Lance (opcional, sempre em percentual) ---
        public bool InformouLance { get; set; }
        public decimal PercentualLance { get; set; }
        public bool LanceEmbutido { get; set; } // true = rdbLanceEmbutido, false = rdbLanceLivre
    }
}
