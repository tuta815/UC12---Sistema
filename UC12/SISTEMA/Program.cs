

namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {

            // PessoaFisica pf = new PessoaFisica();
            // pf.endereco = end;
            // pf.nome = "Arthur";
            // pf.CPF = "1541861431";
            // pf.dataNascimento = new DateTime(1994, 07, 24);

            // //interpolação
            // Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro}, número {pf.endereco.numero}, {pf.endereco.complemento}");
            // //concatenação
            // Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + ", número " + pf.endereco.numero + ", " + pf.endereco.complemento);

            // bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

            // if (idadeValida == true)
            // {
            //     Console.WriteLine("Cadastro Aprovado");
            // }
            // else
            // {
            //     Console.WriteLine("Cadastro Reprovado");
            // };

            // Endereco end = new Endereco();
            // end.logradouro = "Rua X";
            // end.numero = 100;
            // end.complemento = "Qualquer coisa";
            // end.endercoComercial = false;

            // PessoaJuridica pj = new PessoaJuridica();
            // pj.endereco = end;
            // pj.CNPJ = "12345678990001";
            // pj.razaoSocial = "Pessoa Jurídica";

            // Console.WriteLine(pj.validacaoCNPJ(pj.CNPJ));

            Console.ForegroundColor = ConsoleColor.Green;
            // Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"                     
=========================================
|                                       |
|                                       | 
|    Seja bem vindo ao nosso Sistema    |
|    de cadastro de Pessoa Física e     |
|             Pessoa Jurídica           |
|                                       | 
|                                       |
=========================================                      
");

            Console.Write("iniciando ");
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(500);
            }
            Console.Clear();


            string? opcao;
            do
            {
                Console.WriteLine(@$"
=========================================            
|   Escolha uma das opções abaixo       | 
=========================================
|                                       |
|           1 - Pessoa Física           |
|           2 - Pessoa Jurídica         | 
|                                       |
|           0 - Sair                    | 
|                                       |
=========================================
            
            
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas");
                        break;
                }
            } while (opcao != "0");



            Console.ResetColor();
        }
    }
}
