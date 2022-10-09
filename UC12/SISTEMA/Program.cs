

namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.endercoComercial = false;

            PessoaFisica pf = new PessoaFisica();
            pf.endereco = end;
            pf.nome = "Arthur";
            pf.CPF = "1541861431";
            pf.dataNascimento = new DateTime(1994, 07, 24);

            //interpolação
            Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro}, número {pf.endereco.numero}, {pf.endereco.complemento}");
            //concatenação
            Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + ", número " + pf.endereco.numero + ", " + pf.endereco.complemento);

            bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

            if (idadeValida == true)
            {
                Console.WriteLine("Cadastro Aprovado");
            }
            else
            {
                Console.WriteLine("Cadastro Reprovado");
            };
        }
    }
}
