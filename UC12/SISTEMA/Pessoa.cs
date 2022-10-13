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

        public abstract float PagarImposto(float rendimento);



    }
}

// Criar método pagar imposto para pessoa física e pessoa jurídica que calcule a porcentagem de desconto conforme o rendimento

// Pessoa Física
// Para rendimentos até R$ 1.500,00 - isento(desconto 0)
// Para rendimentos entre R$1.501,00 a R$5.000,00 - desconto de 3%
// Para rendimentos acima de R$5.000,01 - desconto de 5%

// Pessoa Jurídica
// Para rendimentos até R$ 5.000,00 - desconto de 6%
// Para rendimentos entre R$5.001,00 a R$10.000,00 - desconto de 8%
// Para rendimentos acima de R$10.000,01 - desconto de 10%

// OBS. o método deve retornar o valor do desconto e não mostrar direto na tela
