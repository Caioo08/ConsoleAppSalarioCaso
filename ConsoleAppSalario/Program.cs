using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a forma de contratação[A-Assalariado, C-Comissionado,H-Horista]: ");
            string contr = Console.ReadLine().ToLower();
            double sal_b = 0;
            switch (contr)
            {
                case "a":
                    Console.Write("Qual o a salário de funcionário: ");
                    double sal = double.Parse(Console.ReadLine());

                    Console.Write("Qual o desconto: ");
                    double desc = double.Parse(Console.ReadLine());

                    sal_b = sal - desc;
                    Console.WriteLine("O salário bruto é R$" + sal_b);
                    
                break;

                case "c":
                    Console.Write("Quantas peças o funcionário vendeu: ");
                    int q_pe = int.Parse(Console.ReadLine());
                    Console.Write("Qual o valor por peça: ");
                    double v_pe = double.Parse(Console.ReadLine());

                    sal_b = q_pe * v_pe;
                    Console.WriteLine("O salário bruto é R$" + sal_b);
                   
                break;

                case "h":

                Console.Write("Qual o valor por hora: ");
                double v_h = double.Parse(Console.ReadLine());

                Console.Write("Qual a quantidade de horas trabalhadas: ");
                int q_h = int.Parse(Console.ReadLine());

                sal_b = v_h * q_h;
                Console.WriteLine("O salário bruto é R$" + sal_b);
                    

                break;
                default: Console.WriteLine("Opção inválida.");
                break;
                    
            }
            if (sal_b <= 2.000)
            {
                double irf = sal_b * 0.075;
                double sal_l = sal_b - irf;
                Console.Write("O salário do funcionário será de R$ " + sal_l);
            }
            else if (sal_b <= 4.000)
            {
                double irf = sal_b * 0.12;
                double sal_l = sal_b - irf;
                Console.Write("O salário do funcionário será de R$ " + sal_l);
            }
            else
            {
                double irf = sal_b * 0.15;
                double sal_l = sal_b - irf;
                Console.Write("O salário do funcionário será de R$ " + sal_l);
            }
            Console.ReadKey();
        }
    }
}
