using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Roberta";
            contaCorrente.agencia = 863;
            contaCorrente.numeroConta = 863452;
            contaCorrente.saldo = 100.50;

            ContaCorrente contaCorrente2 = new ContaCorrente();
            contaCorrente2.titular = "Roberta";
            contaCorrente2.agencia = 863;
            contaCorrente2.numeroConta = 863452;
            contaCorrente2.saldo = 100.50;

            Console.ReadLine();

        }
    }
}
