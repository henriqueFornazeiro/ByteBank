using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //abstract - não deve ser diretamente instanciado
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //protected - será publico apenas para a própria classe quanto para classes derivadas.

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário...");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        //virtual - classes derivadas que herdam a classe base podem mudar a implementação
        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

    }
}
