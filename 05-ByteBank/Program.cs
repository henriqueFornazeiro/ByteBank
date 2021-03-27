using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            cliente.nome = "Henrique";
            cliente.cpf = "123456789-01";
            cliente.profissao = "Programador";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = cliente;
            conta.saldo = 500;
            conta.agencia = 123;
            conta.numeroConta = 123456;

            Console.WriteLine(cliente.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();

        }
    }
}
