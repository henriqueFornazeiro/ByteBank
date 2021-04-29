using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //interface nunca poderá ter a implementação de um método.
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);

    }
}
