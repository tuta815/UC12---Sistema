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

        public override float PagarImposto(float rendimento)
        {
            float imposto = 0;

            if (rendimento <= 5000)
            {
                imposto = rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                imposto = rendimento * 8 / 100;
            }
            else if (rendimento > 10000)
            {
                imposto = rendimento * 10 / 100;
            }

            return imposto;
        }

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