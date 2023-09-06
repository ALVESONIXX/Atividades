using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_2_
{
    class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a sua modalidade de trabalho, sendo: A - Presencial, B - Híbrido e C - Remoto");
            string modalidade = Convert.ToString(Console.ReadLine());

            if (modalidade == "a")
            {
                Console.WriteLine("Digite a quantidade de horas extras que você possui");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Você possui: " + h * 100);
            }
            else if (modalidade == "b")
            {
                Console.WriteLine("Digite a quantidade de horas extras que voc^possui");
                double h1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Voc^possui: " + h1 * 50);
            }
            else if (modalidade == "c")
            {
                Console.WriteLine("O seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então não contempla horas extras ");
            }
            else
            {
                Console.WriteLine("Você digitou uma opção inválida");
            }
        }
    }
}
