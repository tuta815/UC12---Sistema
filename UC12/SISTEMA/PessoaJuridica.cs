using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public string razaoSocial { get; set; }

        public override void PagarImposto(float rendimento) { }

    }
}