using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionário_e_Tecerizados.Entidades
{
    class Terceiros : Funcionário
    {
        public double CargaAd { get; set; }

        public Terceiros()
        {

        }
        public Terceiros (string nome, int horas, double valorPorHora, double cargaAd) 
            : base (nome, horas, valorPorHora)
        {
            CargaAd = cargaAd;
        }
        public override double Pagamento ()
        {
            return base.Pagamento() + 1.1 * CargaAd;
        }
    }
}
