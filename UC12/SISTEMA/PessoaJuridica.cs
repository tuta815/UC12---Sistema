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

        public bool validacaoCNPJ(string CNPJ)
        {
            int numCaracteres = CNPJ.Length;

            if (numCaracteres >= 14 && (CNPJ.Substring(numCaracteres - 4)) == "0001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}