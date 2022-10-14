

namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PessoaFisica> listaPf = new List<PessoaFisica>();

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
            // BarraCarregamento("Iniciando ");

            string? opcao;
            do
            {
                Console.WriteLine(@$"
===================================================            
|        Escolha uma das opções abaixo            |
===================================================
|                  PESSOA FÍSICA                  |
|           1-Cadastrar Pessoa Física             |
|           2-Listar Pessoa Física                |
|           3-Remover Pessoa Física               |
|                                                 |
|                 PESSOA JURÍDICA                 |
|           4-Cadastrar Pessoa  Jurídica          |
|           5-Listar Pessoa Jurídica              |
|           6-Remover Pessoa Jurídica             |                 
|                                                 |
|                    0 - Sair                     | 
|                                                 |
===================================================
            
            
            ");
                Console.ForegroundColor = ConsoleColor.Green;
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Cadastrar Pessoa Física
                        Endereco endPf = new Endereco();

                        Console.WriteLine("Digite seu logradouro: ");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Número: ");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Complemento: ");
                        endPf.complemento = Console.ReadLine();

                        string endComercial;
                        do
                        {
                            Console.WriteLine("Este endereço é comercial? (S = Sim, N = Não)");
                            endComercial = Console.ReadLine().ToUpper();


                            if (endComercial == "S")
                            {
                                endPf.enderecoComercial = true;
                                break;
                            }
                            else if (endComercial == "N")
                            {
                                endPf.enderecoComercial = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Comando inválido, por favor digite apenas as teclas s ou n");
                            }
                        } while (endComercial != "S" || endComercial != "N");



                        PessoaFisica pf = new PessoaFisica();
                        pf.endereco = endPf;

                        Console.WriteLine("Digite seu nome: ");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF (apenas números):");
                        pf.CPF = Console.ReadLine();

                        Console.WriteLine("Digite o valor do seu salário:");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite sua data de nascimento [AAAA, MM, DD]");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
                        if (idadeValida)
                        {
                            Console.WriteLine("CADASTRO APROVADO");
                            listaPf.Add(pf);
                            Console.WriteLine(pf.PagarImposto(pf.salario));
                        }
                        else
                        {
                            Console.WriteLine("CADASTRO REJEITADO");
                        }


                        break;
                    case "2":
                        // Listar Pessoa Física
                        foreach (var usuarios in listaPf)
                        {
                            Console.WriteLine(@$"{usuarios.nome}, 
{usuarios.CPF}");
                        }
                        break;
                    case "3":
                        // Remover Pessoa Física
                        Console.WriteLine("Digite o CPF do meliante que deseja remover:");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaProcurada = listaPf.Find(usuarios => usuarios.CPF == cpfProcurado);

                        if (pessoaProcurada != null)
                        {
                            listaPf.Remove(pessoaProcurada);
                            Console.WriteLine("Meliante removido");
                        }
                        else
                        {
                            Console.WriteLine("Meliante não encontrado");
                        }
                        break;
                    case "4":
                        // Cadastrar Pessoa Jurídica
                        break;
                    case "5":
                        // Listar Pessoa Jurídica
                        break;
                    case "6":
                        // Remover Pessoa Jurídica
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
