using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
