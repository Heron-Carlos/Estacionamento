using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Model
{
    public class FluxoDeCaixa
    {
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public string PlacaVeiculo { get; set; }
        public string DataPagamento { get; set; }
        public string ValorPago { get; set; }
        public string FormaPagamento { get; set; }
    }
}
