using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimulador
{
    public static class LimitesConsorcio
    {
        private static readonly Dictionary<CategoriaConsorcio, (string Nome, decimal Min, decimal Max)> limites =
            new Dictionary<CategoriaConsorcio, (string Nome, decimal Min, decimal Max)>
        {
            { CategoriaConsorcio.Imovel,       ("Imóvel",          120000m, 1000000m) },
            { CategoriaConsorcio.Automovel,      ("Automóvel",       20000m, 300000m)  },
            { CategoriaConsorcio.Agro,         ("Agro",            120000m, 10000000m)  },
            { CategoriaConsorcio.CapitalDeGiro,("Capital de Giro", 120000m, 10000000m)  },
            { CategoriaConsorcio.Servicos,     ("Serviços",        5000m,  20000m)  },
            { CategoriaConsorcio.Personalizado,("Personalizado",   20000m,  1000000000m) },
        };

        // Retorna o nome de exibição e os limites min/max de uma categoria
        public static (string Nome, decimal Min, decimal Max) ObterDados(CategoriaConsorcio categoria)
        {
            return limites[categoria];
        }

        // Verifica se o valor informado está dentro do limite da categoria
        public static bool ValorDentroDoLimite(CategoriaConsorcio categoria, decimal valor, out string mensagemErro)
        {
            var (nome, min, max) = ObterDados(categoria);
            mensagemErro = string.Empty;

            if (valor < min || valor > max)
            {
                mensagemErro = $"Para {nome}, o valor deve estar entre {min:C2} e {max:C2}.";
                return false;
            }

            return true;
        }
    }
}
