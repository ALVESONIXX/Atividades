using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_8
{
    class Midia
    {
        int codigo { get; set; }
        double preco { get; set; }
        string nome { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Digite o nome do seu Cantor Favorito");
            string cantor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome da sua Musica Favorita eo Ano de Lançamento dela");
            string musica = Convert.ToString(Console.ReadLine());

            Console.WriteLine(cantor);
            Console.WriteLine(musica);
        }

    }
}
