using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_1
{
    abstract class Escola
    {

        public abstract void CalcAverage();
        public static void GetName()
        {
            Console.Write("Digite o nome da sua escola: ");
            string schoolName = Console.ReadLine().ToLower();
            Console.Write("Digite o nome da sua cidade: ");
            string cityName = Console.ReadLine().ToLower();
            Console.Write("Digite o nome da sua escola: ");
            string stateName = Console.ReadLine().ToLower();
            Console.Write("Digite o nome da sua escola: ");
            int classGrade = Convert.ToInt32(Console.ReadLine());

            if (schoolName == "sesi" || schoolName == "senai" && cityName == "garca" || cityName == "garça")
            {
                Console.WriteLine($"Você é um aluno {schoolName}.");
            }
            else
            {
                Console.WriteLine($"A escola que você estuda é {schoolName} na cidade {cityName}.");
            }
        }
    }
}
