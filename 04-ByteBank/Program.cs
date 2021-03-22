using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Henrique";
            conta.saldo = 1000.00;

            Console.WriteLine("Antes do saque: " + conta.saldo);
            conta.Sacar(50);
            Console.WriteLine("Após o saque: " + conta.saldo);

            conta.Depositar(1000.00);
            Console.WriteLine("Após o depósito: " + conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Henrique2";

            conta.Transferir(200, conta2);

            Console.WriteLine("Saldo conta 1: " + conta.saldo);
            Console.WriteLine("Saldo conta 2: " + conta2.saldo);

            Console.ReadLine();

        }
    }
}
