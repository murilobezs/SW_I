using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamentos
{
    public class FolhaDePagamentos
    {
        public string Nome { get; set; }
        public double SAL { get; set; }
        public int HED { get; set; }
        public int HEN { get; set; }
        public int NumDependentes { get; set; }   
        public int Faltas { get; set; }
        public double DescontosEv { get; set; }
        public double GastosRef { get; set; }
        public double Vales { get; set; }

        public double SalarioMin()
        {
            return 1412.0;
        }
        public void CalculoFolha()
        {
            double salarioF = NumDependentes * 0.05 * SalarioMin();
            double HoraExtra = (HED * SAL / 160) + (HEN * 1.2 * SAL / 160);
            double salarioB = SAL + HoraExtra + salarioF;

            double INAMPS = 0.08 * SAL;
            double faltas = Faltas * SAL / 160;
            double TotalDescontos = INAMPS + GastosRef + Vales + DescontosEv + faltas;
            double impostoRe = 0.08 * salarioB;
            double salarioLiquido = salarioB - TotalDescontos;

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: R${SAL}");
            Console.WriteLine($"Horas Extras: {HoraExtra}");
            Console.WriteLine($"Salário Família: R${salarioF}");
            Console.WriteLine($"Salário Bruto: {salarioB}");
            Console.WriteLine($"Descontos efetuados:");
            Console.WriteLine($"INAMPS: R${INAMPS}");
            Console.WriteLine($"Faltas: R${faltas}");
            Console.WriteLine($"Refeições: R${GastosRef}");
            Console.WriteLine($"Vales: R${Vales}");
            Console.WriteLine($"Descontos eventuais: R${DescontosEv}");
            Console.WriteLine($"Imposto de renda: R${impostoRe}");
            Console.WriteLine($"Salário Líquido: R${salarioLiquido}");

        }




    }
}
