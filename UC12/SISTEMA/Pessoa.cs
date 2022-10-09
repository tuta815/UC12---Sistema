using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        public Endereco endereco { get; set; }

        public bool enderecoComercial { get; set; }

        public abstract void PagarImposto(float rendimento);



    }
}