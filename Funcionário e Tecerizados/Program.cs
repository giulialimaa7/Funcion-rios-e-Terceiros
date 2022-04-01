using System;
using System.Globalization;
using System.Collections.Generic;
using Funcionário_e_Tecerizados.Entidades;

namespace Funcionário_e_Tecerizados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionário> lista = new List<Funcionário>();  

            Console.Write("Entre com o número de funcionários: ");
            int f = int.Parse(Console.ReadLine());

            for (int i=1; i<=f; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}: ");
                Console.Write("Terceirizado? (s/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());

                if (ch == 's')
                {
                    Console.Write("Carga adicional: ");
                    double cargaAd = double.Parse(Console.ReadLine());
                    lista.Add(new Terceiros(nome, horas, valorPorHora, cargaAd));
                }
                else
                {
                    lista.Add(new Funcionário(nome, horas, valorPorHora));
                }
            }

            foreach (Funcionário func in lista)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento().ToString("f2"));
            }
        }
    }
}
