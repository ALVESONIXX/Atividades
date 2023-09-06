using Abstração_e_Herança.Atividade_1;
using Abstração_e_Herança.Atividade_2_;
using Abstração_e_Herança.Atividade_3;
using Abstração_e_Herança.Atividade_4;
using Abstração_e_Herança.Atividade_5;
using Abstração_e_Herança.Atividade_6;
using Abstração_e_Herança.Atividade_7;
using Abstração_e_Herança.Atividade_8;
using Abstração_e_Herança.Atividade_9;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abstração_e_Herança
{
    class Program
    {

        static void Main(string[] args)
        {
            //Atividade 01

            Sesi sesi = new Sesi(); 
            Senai senai = new Senai();
            Escola.GetName();
            sesi.CalcAverage();
            senai.CalcAverage();


            //Atividade 02

            Desenvolvedor desenvolvedor = new Desenvolvedor();
            desenvolvedor.CalcularHorasExtras();

            Bancario bancario = new Bancario();
            bancario.CalcularHorasExtras();

            GerenteTi gerenteTi = new GerenteTi();
            gerenteTi.CalcularHorasExtras();

            //Atividade 03

            Estudantes estudante = new Estudantes();
            estudante.Nome = "Kaique";
            estudante.Idade = 16;
            estudante.Cidade = "Garça/Sp";
            estudante.Estado = "São Paulo";

            Console.WriteLine(estudante.Nome);
            Console.WriteLine(estudante.Idade);
            Console.WriteLine(estudante.Cidade);
            Console.WriteLine(estudante.Estado);

            Projeto_3 projeto = new Projeto_3();
            projeto.EscolherProfissão();



            //Atividade 04

            DigitarInformacaoes();


            //Atividade 05

            Empresario empresario = new Empresario();

            empresario.nome = "Kaique";
            empresario.cnpj = "00007";
            empresario.endereco = "Rua Juan Nachbar";
            empresario.cidade = "Garça";
            empresario.nomeEmpresa = "Doyona";

            Json();

            //Atividade 06

            Losangulo losangulo = new Losangulo();
            Retangulo retangulo = new Retangulo();
            losangulo.CalcArea();
            retangulo.CalcArea();




            //Atividade 07

            Animal();




            //Atividade 08


            Midia midia = new Midia();

            midia.ImprimirDados();

            Dvd dvd = new Dvd();

            dvd.Filme = 4;
            dvd.VerFilmes();

            Console.WriteLine(dvd.Filme);

            Usb usb = new Usb();

            usb.musicas = 2;
            usb.CapacidadeArmazenamento = "Caben 1000 musicas em 2 dvd de 9GB";
            usb.LerMusicas();

            Console.WriteLine(usb.musicas);
            Console.WriteLine(usb.CapacidadeArmazenamento);


            // Atividade9

            Console.Write("Digite o valor a ser depositado: ");
            double depositValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor a ser sacado: ");
            double saqueValue = Convert.ToDouble(Console.ReadLine());

            Conta_Bancaria contaBancaria = new Conta_Bancaria();
            contaBancaria.Depositar(depositValue);
            contaBancaria.Sacar(saqueValue);
        }
        public static void DigitarInformacaoes()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua cidade");
            string Cidade = Console.ReadLine();
            Console.WriteLine("Digite o seu rg");
            string rg = Console.ReadLine();
            Console.WriteLine("Digite a sua área");
            string area = Console.ReadLine();
            Programador programador = new Programador();
            programador.nome = nome;
            programador.idade = Idade;
            programador.cidade = Cidade;
            programador.rg = rg;
            programador.area = area;

            string JsonString = JsonConvert.SerializeObject(programador, Newtonsoft.Json.Formatting.Indented);
            dynamic stringJson = JsonConvert.DeserializeObject(JsonString);

            File.WriteAllText("text.json", JsonString);
            string text = File.ReadAllText("atividade_4.json");
            Console.WriteLine(text);
        }
        public void Definir()
        {

        }

        public static void Json()
        {
            Empresario empresario = new Empresario();
            empresario.nome = "Juan";
            empresario.idade = 16;
            empresario.nomeEmpresa = "Garena";
            empresario.cidade = "Corredeira";

            Empresario empresario1 = new Empresario
            {
                nome = "Nachbar",
                idade = 40,
                nomeEmpresa = "Rockstar",
                cidade = "Japao",
            };

            Empresario empresario2 = new Empresario
            {
                nome = "Matheus",
                idade = 37,
                nomeEmpresa = "Java",
                cidade = "Bauru",
            };

            Empresario empresario3 = new Empresario
            {
                nome = "Neymar",
                idade = 55,
                nomeEmpresa = "Havaianas",
                cidade = "Tokyo",
            };


            string Jsonstring = JsonConvert.SerializeObject(empresario);
            string Jsonstring1 = JsonConvert.SerializeObject(empresario1);
            string Jsonstring2 = JsonConvert.SerializeObject(empresario2);
            string jsonString3 = JsonConvert.SerializeObject(empresario3);

            Console.WriteLine(empresario.nome);
            Console.WriteLine(empresario.idade);
            Console.WriteLine(empresario.nomeEmpresa);
            Console.WriteLine(empresario.cidade);

            Console.WriteLine(empresario1.nome);
            Console.WriteLine(empresario1.idade);
            Console.WriteLine(empresario1.nomeEmpresa);
            Console.WriteLine(empresario1.cidade);

            Console.WriteLine(empresario2.nome);
            Console.WriteLine(empresario2.idade);
            Console.WriteLine(empresario2.nomeEmpresa);
            Console.WriteLine(empresario2.cidade);

            Console.WriteLine(empresario3.nome);
            Console.WriteLine(empresario3.idade);
            Console.WriteLine(empresario3.nomeEmpresa);
            Console.WriteLine(empresario3.cidade);

            File.WriteAllText("Kaique_7.json", Jsonstring + Jsonstring1 + Jsonstring2 + jsonString3);
            string text = File.ReadAllText("text.json");
            Console.WriteLine(text);


        }
        public static void Animal()
        {
            Console.WriteLine("Digite o nome do seu pet");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do seu pet");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome + " " + idade);
            Animal animal = new Animal();
            animal.Nome = nome;
            animal.Idade = idade;


            string JsonString = JsonConvert.SerializeObject(animal, Newtonsoft.Json.Formatting.Indented);
            dynamic stringJson = JsonConvert.DeserializeObject(JsonString);

            File.WriteAllText("animal.test", JsonString);
            string text = File.ReadAllText("animal.test");
            Console.WriteLine(text);
        }
    }
}
