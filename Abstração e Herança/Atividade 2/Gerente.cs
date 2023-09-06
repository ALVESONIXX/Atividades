using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_2_
{
    class GerenteTi : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras feitas no mês");
            double h = Convert.ToDouble(Console.ReadLine());

            if (h > 100)
            {
                double result = (h / 2) * 200 + 500;
                double result2 = (h / 2) / 8;

                Console.WriteLine("O total de horas foi de: " + result2);
            }
            else
            {
                double resulth = h * 400;
                Console.WriteLine("O total de horas foi de: " + resulth);
            }
        }
    }
}
