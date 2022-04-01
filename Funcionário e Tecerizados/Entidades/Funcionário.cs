using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionário_e_Tecerizados.Entidades
{
    class Funcionário
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionário ()
        {

        }
        public Funcionário(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }
        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
