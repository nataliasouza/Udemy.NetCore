
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
            {
                Console.WriteLine("\n==================== MENU DE OPÇÕES =========================\n");
                Console.WriteLine("1 - O que é Git e GitHub?");
                Console.WriteLine("2 - Configurar chave SSH para o Github");
                Console.WriteLine("3 - Configurar sua identificação no Git:");
                Console.WriteLine("4 - Salvar 1ª versão do projeto");
                Console.WriteLine("5 - Salvar nova versão");
                Console.WriteLine("6 - Clonar e modificar um projeto de um repositório");
                Console.WriteLine("7 - Ver o histórico de versões e mostrar a diferença entre arquivos");
                Console.WriteLine("8 - Como criar e mudar para outra branch existente");
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
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        TextoExplicativoGitGithub();
                        break;

                    case 2:
                        ConfigurarIdentificacaoGit();
                        break;

                    case 3:
                        ConfigurarChaveSSHGithub();
                        break;

                    case 4:
                        SalvarPrimeiraVersao();
                        break;

                    case 5:
                        SalvarNovaVersao();
                        break;

                    case 6:
                        ClonarModificarProjeto();
                        break;

                    case 7:
                        VerHistoricoOuMostrarDiferenca();
                        break;
                    case 8:
                        CriarBranchOuIrParaOutra();
                        break;

                    case 9:
                        ComoDesfazerModificaçõesNaoSalvas();
                        break;

                    case 10:
                        ComoUsarEditorVIM();
                        break;

                    case 11:
                        ComoDesfazerUltimoCommit();
                        break;

                    case 12:
                        Console.WriteLine("Criar opção");
                        break;

                    case 13:
                        Console.WriteLine("Criar opção");
                        break;

                    case 14:
                        Console.WriteLine("Criar opção");
                        break;

                    case 15:
                        Console.WriteLine("Criar opção");
                        break;
                    case 16:
                        Console.Write("\n\n\tSaindo do sistema...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("\nDigite uma opção válida!");
                        break;
                }
            }
        }
        //case1
        public static void TextoExplicativoGitGithub()
        {
            Console.Clear();            
            ExibirTituloDaOpcao("O que é Git e GitHub?");
            Console.WriteLine("\n=> GIT - é um sistema de versionamento: " +
                "\n\nVocê controla as modificações de um projeto por meio de versões chamadas \"commits\".");            
            Console.WriteLine("\n=> Github - É um serviço online de hospedagem de repositórios Git remotos.");
            Console.WriteLine("\n Possui uma interface gráfica web: github.com");
            Console.WriteLine("\t * É uma plataforma social (usuários, página de perfil, seguidores, colaboração, etc.). Dica: currículo!");
            Console.WriteLine("\t * Maior serviço do mundo de hospedagem de projetos de código aberto.");
            Console.WriteLine("\t * Modelo de cobrança: gratuito para projetos de código aberto e para projetos privados.");
            Console.WriteLine("\t * Alternativas: BitBucket, GitLab, etc.\n");
            
            LimparTela();
            ExibirMenu();
        }
        //case2
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
        //case3
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
        //case4
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
            LimparTela();
            ExibirMenu();
        }
        //case5
        public static void SalvarNovaVersao()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("git status");//exibe todas modificações
            Console.WriteLine("git add .");
            Console.WriteLine("git commit -m \"Mensagem explicativa\"");
            Console.WriteLine("git push");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }
        //case6
        public static void ClonarModificarProjeto()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("git clone git@github.com:seuusuario/seurepositorio.git");
            Console.WriteLine("git add .");
            Console.WriteLine("git commit -m \"Mensagem explicativa\"");
            Console.WriteLine("git push");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();

        }
        //case7
        public static void VerHistoricoOuMostrarDiferenca()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Histórico de versões e ver a diferença entre arquivos");
            Console.WriteLine("Verificando o histórico de versões: \n\n\tgit log");            
            Console.WriteLine("\n\nListagem resumida: \n\n\tgit log --oneline");
            Console.WriteLine("\n\nComando que mostra a diferença entre arquivos modificados: \n\n\tgit diff");
            Console.WriteLine("\n\nMostra com detalhes todas as mudanças realizadas: \n\n\tgit show");
            LimparTela();
            ExibirMenu();
        }
        //case8
        public static void CriarBranchOuIrParaOutra()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("\nCom o git checkout você pode mudar de branch");
            Console.WriteLine("\tgit checkout \"nome_da_branch\"");            
            Console.WriteLine("\n\nCaso a branch ainda não exista você poderá passar o parâmetro -b para criar.");
            Console.WriteLine("\tgit checkout -b \"nome_da_branch\"");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }
        //case9
        public static void ComoDesfazerModificaçõesNaoSalvas()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("git status");
            Console.WriteLine("git reset");
            Console.WriteLine("git clean -df");
            Console.WriteLine("git checkout --");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }
        //case10
        public static void ComoUsarEditorVIM()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("\nHabilitar o modo de edição: \t i ");
            Console.WriteLine("\nSair do VIM, salvando as alterações:");
            Console.WriteLine("\t<ESC> :wq <ENTER> ");
            Console.WriteLine("\n\nSair do VIM, descartando as alterações: ");
            Console.WriteLine("\t<ESC> :q! <ENTER>");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }
        //case11
        public static void ComoDesfazerUltimoCommit()
        {
            Console.Clear();
            Console.WriteLine("\n====================================================================================================================");
            Console.WriteLine("\nDesfazer último commit sem desfazer as modificações nos arquivos:\n");          
            Console.WriteLine("\tgit status");            
            Console.WriteLine("\tgit reset --soft HEAD~1");
            Console.WriteLine("\n====================================================================================================================");
            LimparTela();
            ExibirMenu();
        }

        public static void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras * 2, '*');
            Console.WriteLine($"{asteriscos}");
            Console.WriteLine($"\n\t{titulo}\n");
            Console.WriteLine($"{asteriscos}\n");
        }
        public static void LimparTela()
        {
            Console.Write("\n\nAperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
