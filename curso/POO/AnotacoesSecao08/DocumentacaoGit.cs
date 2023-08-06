
//Documentação Git e GitHub
//Anotações para consulta dos comandos
// Doc Oficial: https://comandosgit.github.io/

namespace curso.POO.AnotacoesSecao08
{
    internal class DocumentacaoGit
    {
        public static void Executar()
        {        
            ExibirMenu();            
        }

        public static void ExibirMenu()
        {
            string opcao = "0";

            while (opcao != "16")
            {
                Console.WriteLine("\n==================== MENU DE OPÇÕES =========================\n");
                Console.WriteLine("1 - O que é Git e GitHub?");
                Console.WriteLine("2 - Configurar chave SSH para o Github");
                Console.WriteLine("3 - Configurar sua identificação no Git:");
                Console.WriteLine("4 - Salvar 1ª versão do projeto");
                Console.WriteLine("5 - Salvar nova versão");
                Console.WriteLine("6 - Clonar e modificar um projeto de um repositório");
                Console.WriteLine("8 - Como remover arquivos da área de stage");
                Console.WriteLine("9 - Como desfazer modificações não salvas");
                Console.WriteLine("10 - O que fazer quando abre o editor VIM");
                Console.WriteLine("11 - Como desfazer o último commit");
                Console.WriteLine("12 - Como deletar commits e também modificações nos arquivos");
                Console.WriteLine("13 - Como atualizar o repositório local em relação ao remoto");
                Console.WriteLine("14 - Como resolver push rejeitado");
                Console.WriteLine("15 - Como apontar o projeto para outro repositório remoto");
                Console.WriteLine("16 - Sair");
                Console.WriteLine("\n=============================================================");

                Console.Write("\n\tDigite sua opção para ler as informações: ");
                opcao = Console.ReadLine();

                if (opcao != "16")
                {
                    switch (opcao)
                    {
                        case "1":
                            TextoExplicativoGitGithub();
                            break;

                        case "2":
                            ConfigurarIdentificacaoGit();
                            break;

                        case "3":                            
                            ConfigurarChaveSSHGithub();
                            break;

                        case "4":
                            SalvarPrimeiraVersao();
                            break;

                        case "5":
                            SalvarNovaVersao();
                            break;

                        case "6":
                            Console.WriteLine("Criar opção");
                            break;

                        case "7":
                            Console.WriteLine("Criar opção");
                            break;
                        case "8":
                            ConfigurarIdentificacaoGit();
                            break;

                        case "9":
                            ConfigurarChaveSSHGithub();
                            break;

                        case "10":
                            Console.WriteLine("Criar opção");
                            break;

                        case "11":
                            Console.WriteLine("Criar opção");
                            break;

                        case "12":
                            Console.WriteLine("Criar opção");
                            break;

                        case "13":
                            Console.WriteLine("Criar opção");
                            break;

                        case "14":
                            Console.WriteLine("Criar opção");
                            break;

                        case "15":
                            Console.WriteLine("Criar opção");
                            break;

                        default: Console.WriteLine("\nDigite uma opção válida!");
                            break;
                    }
                }
            }
        }

        public static void TextoExplicativoGitGithub()
        {
            Console.Clear();
            Console.WriteLine("\n\n====================================================================================================================");
            Console.WriteLine("\n=> GIT - é um sistema de versionamento: " +
                "\n\nVocê controla as modificações de um projeto por meio de versões chamadas \"commits\".");
            Console.WriteLine("\n====================================================================================================================\n");

            Console.WriteLine("\n=> Github - É um serviço online de hospedagem de repositórios Git remotos.");
            Console.WriteLine("\n Possui uma interface gráfica web: github.com");
            Console.WriteLine("\t * É uma plataforma social (usuários, página de perfil, seguidores, colaboração, etc.). Dica: currículo!");
            Console.WriteLine("\t * Maior serviço do mundo de hospedagem de projetos de código aberto.");
            Console.WriteLine("\t * Modelo de cobrança: gratuito para projetos de código aberto e para projetos privados.");
            Console.WriteLine("\t * Alternativas: BitBucket, GitLab, etc.");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }

        public static void ConfigurarIdentificacaoGit()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("\nConfigurando sua identificação no Git:\n");
            Console.WriteLine("git config --global user.name \"Seu nome\"");
            Console.WriteLine("git config --global user.email \"Seu email de cadastro do GitHub\"");
            Console.WriteLine("git config --list");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }

        public static void ConfigurarChaveSSHGithub()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("\nConfigurar chave SSH para o Github:\n");
            Console.WriteLine("\t * SSH é um protocolo para comunicação de dados com segurança.");
            Console.WriteLine("\t * O Github aboliu a autenticação somente com usuário e senha.");
            Console.WriteLine("\t * A ideia básica é cadastrar previamente quais computadores podem acessar o Github em seu nome. \n" +
                "\t Outros computadores não conseguem acessar.\n");
            Console.WriteLine("Para isto você deve:\n\n(1) Gerar uma chave SSH no seu computador.\n(2) Cadastrar essa chave no seu Github.");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }

        public static void SalvarPrimeiraVersao()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("git init"); //inicializa o git no repositório local
            Console.WriteLine("git add ."); // adiciona todos os arquivos criados ou alterados.
            Console.WriteLine("git commit -m \"Mensagem explicativa\""); //Armazena o conteúdo atual do índice em um novo commit, juntamente com uma mensagem de registro do usuário que descreve as mudanças
            Console.WriteLine("git branch -M main"); //Define a branch a ser usada
            Console.WriteLine("git remote add origin git@github.com:seuusuario/seurepositorio.git");// adiciona o repositorio remoto
            Console.WriteLine("git push -u origin main");//envia as modificações para o repositório remoto
            Console.WriteLine("\n====================================================================================================================");
        }

        public static void SalvarNovaVersao()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("git status");//exibe todas modificações
            Console.WriteLine("git add .");
            Console.WriteLine("git commit -m \"Mensagem explicativa\"");
            Console.WriteLine("git push");
            Console.WriteLine("\n====================================================================================================================");
        }

        public static void LimparTela()
        {
            Console.Write("\n\nAperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
