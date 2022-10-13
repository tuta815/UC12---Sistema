

namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {

            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(texto);
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("♠");
                    Thread.Sleep(500);
                }
            }

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

            // Console.ForegroundColor = ConsoleColor.Green;
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
            // BarraCarregamento("Iniciando ");

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
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua Niteroi";
                        endPf.numero = 180;
                        endPf.complemento = "Escola SENAI Paulo Skaf";
                        endPf.endercoComercial = false;

                        PessoaFisica Lucas = new PessoaFisica();

                        Lucas.nome = "Lucas Rodriguez Sinni";
                        Lucas.CPF = "31354654331";
                        Lucas.dataNascimento = new DateTime(2004, 08, 21);
                        Lucas.endereco = endPf;
                        float impostoapagar = Lucas.PagarImposto(1500);
                        Console.WriteLine(@$"Imposto a pagar: {impostoapagar}
Nome: {Lucas.nome}                        
CPF: {Lucas.CPF}
Nascido em {Lucas.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPf.logradouro}, {endPf.numero} - {endPf.complemento}");
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Niteroi";
                        endPj.numero = 180;
                        endPj.complemento = "Escola SENAI Paulo Skaf";
                        endPj.endercoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.CNPJ = "001215612312";
                        pj.endereco = endPj;
                        pj.razaoSocial = "Pessoa Juridica";
                        pj.nome = "Jequiti";
                        float impostopj = pj.PagarImposto(5000);

                        Console.WriteLine(pj.CNPJ);
                        Console.WriteLine(impostopj);
                        Console.ResetColor();
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        // BarraCarregamento("Finalizando ");

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
