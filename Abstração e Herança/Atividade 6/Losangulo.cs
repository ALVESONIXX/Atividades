using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_6
{
    public class Losangulo : Formula

    {
        public override void CalcArea()
        {
            Console.Write("Para calcular a area de um losângulo comece por digitar o valor da diagonal maior: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Agora insira o comprimento da diagonal menor: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            double losanguloArea = (d1 * d2) / 2;

            Console.WriteLine($"A area de um losângulo de diagonais {d1} e {d2} tem como área {losanguloArea}.");
        }
    }
}
