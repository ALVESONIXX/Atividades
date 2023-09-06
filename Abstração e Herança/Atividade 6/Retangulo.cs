using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_6
{
    public class Retangulo : Formula
    {
        public override void CalcArea()
        {
            Console.Write("Para calcular a area de um retângulo comece por digitar o valor de o lado maior: ");
            double l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Agora insira o comprimento do lado menor: ");
            double l2 = Convert.ToDouble(Console.ReadLine());
            double retanguloArea = l1 * l2;

            Console.WriteLine($"A area de um retângulo de lados {l1} e {l2} tem como área {retanguloArea}.");
        }
    }
}
