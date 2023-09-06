using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_1
{
    class Senai: Escola
    {
        public override void CalcAverage()
        {
            Console.Write("Digite a primeira nota do aluno (de 0 a 100): ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno (de 0 a 100): ");
            double n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno (de 0 a 100): ");
            double n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quarta nota do aluno (de 0 a 100): ");
            double n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a frequência do aluno: ");
            double presence = Convert.ToInt32(Console.ReadLine());
            double averageGrade = (n1 + n2 + n3 + n4) / 4;
            if (presence >= 90 && averageGrade >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do SENAI.");
            }
            else if (presence >= 90 && averageGrade <= 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação.");
            }
            else if (presence < 90 && averageGrade >= 7)
            {
                Console.WriteLine("Você foi reprovado por faltas.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }
    }
}
