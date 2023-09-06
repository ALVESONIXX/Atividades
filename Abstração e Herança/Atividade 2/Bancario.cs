using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_2_
{
    class Bancario : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras que você possui");
            double h = Convert.ToDouble(Console.ReadLine());

            double result = h * 250;

            if (result > 500)
            {
                double r = result * 0.1;
                Console.WriteLine("O novo valor das horas extras foi de: " + r);
            }
            else if (result > 1000)
            {
                double r2 = result * 0.15;
                Console.WriteLine("Novo valor de horas extras foi de: " + r2);
            }
            else
            {
                Console.WriteLine("O valor final das horas extras que o colaborador ira receber é de: " + result);
            }
        }
    }
}
