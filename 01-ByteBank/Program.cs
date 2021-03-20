using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Roberta";
            conta.agencia = 123;
            conta.numeroConta = 123456;
            conta.saldo = 123.50;

            Console.WriteLine(conta.titular);
            Console.WriteLine("Agência: "+conta.agencia);
            Console.WriteLine("Conta: " + conta.numeroConta);
            Console.WriteLine("Saldo: "+conta.saldo);

            Console.ReadLine();

        }
    }
}
