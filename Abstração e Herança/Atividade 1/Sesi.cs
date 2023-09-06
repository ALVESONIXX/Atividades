using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_1
{
     class Sesi : Escola
     {
        public override void CalcAverage()
        {
            Console.Write("Digite a primeira nota do aluno: ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            double n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno: ");
            double n3 = Convert.ToInt32(Console.ReadLine());
            double averageGrade = (n1 + n2 + n3) / 3;
            if (averageGrade >= 7)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else if (averageGrade <= 5)
            {
                Console.WriteLine("O aluno esta em recuperação.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }
    }
}
