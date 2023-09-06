    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração_e_Herança.Atividade_9
{
    public class Conta_Bancaria
    {
         
        public string nameHolder;
        public string nameBank;
        public double saldo;
        public int nHolder;
        public int nBank;
        private double payment;

        public void Depositar(double depositValue)
        {
            saldo = saldo + depositValue;
            Console.WriteLine($"Seu deposito de R$ {depositValue} foi realizado com sucesso, agora seu saldo atual é de R$ {saldo}.");
        }
        public void Sacar(double saqueValue)
        {
            if (saqueValue > saldo)
            {
                Console.WriteLine($"Seu saque de R$ {saqueValue} é maior do que o atual saldo da conta. (R$ {saldo})");
            }
            else if (saqueValue < saldo || saqueValue == saldo)
            {
                saldo = saldo - saqueValue;
                Console.WriteLine($"Seu saque de R$ {saqueValue} foi bem sucedido e agora o saldo atual de sua conta é de R$ {saldo}.");
            }
            else
            {
                Console.WriteLine("A operação falhou, favor tente novamente.");
            }
        }
    }
}
