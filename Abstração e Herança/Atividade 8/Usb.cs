using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_8
{
    class Usb
    {
        public int musicas;
        public string CapacidadeArmazenamento;

        public void LerMusicas()
        {
            Console.WriteLine("Digite o nome de 5 musicas contendo o nome do autor");
            string musica1 = Convert.ToString(Console.ReadLine());
            string musica2 = Convert.ToString(Console.ReadLine());
            string musica3 = Convert.ToString(Console.ReadLine());
            string musica4 = Convert.ToString(Console.ReadLine());
            string musica5 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(musica1);
            Console.WriteLine(musica2);
            Console.WriteLine(musica3);
            Console.WriteLine(musica4);
            Console.WriteLine(musica5);
        }
    }
}
