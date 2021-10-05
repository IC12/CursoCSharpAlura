using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(String senha)
        {
            return Senha == senha;
        }
    }
}
