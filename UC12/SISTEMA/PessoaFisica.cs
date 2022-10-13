using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class PessoaFisica : Pessoa

    {
        public string CPF { get; set; }

        public DateTime dataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 5000)
            {
                return rendimento * 3 / 100;
            }
            else if (rendimento > 5000)
            {
                return rendimento * 5 / 100;
            }
            else
            {
                return 0;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18)
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