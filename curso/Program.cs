using curso.LogicaProgramacao;
using curso.LogicaProgramacao.ExerciciosPropostos;

var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                //LÓGICA DE PROGRAMAÇÃO
                {"Conta Bancária - Recapitulando Lógica de Programação", ContaBancaria.Executar},               
                {"Placeholders, concatenação e interpolação - Recapitulando Lógica de Programação", Concatenacao.Executar},               
                {"Exercício de Fixação 01 - Recapitulando Lógica de Programação", ExeFixacao01.Executar},               
                {"Bhaskara - Recapitulando Lógica de Programação", Bhaskara.Executar},              
                {"Split - Recapitulando Lógica de Programação", SplitPalavras.Executar},             
                {"Split Parte 2 - Recapitulando Lógica de Programação", SplitParte2.Executar},            
                {"Ímpar ou par - Recapitulando Lógica de Programação", ImparPar.Executar},
                {"Operadores Comparativos - Recapitulando Lógica de Programação", OpComparativos.Executar},
                {"Operadores Lógicos - Recapitulando Lógica de Programação", OpLogicos.Executar},
                {"Estrutura Condicional - if/else - Recapitulando Lógica de Programação", EstruturaCondicional.Executar},
                {"Estrutura Condicional (ESCOPO) - if/else - Recapitulando Lógica de Programação", Desconto.Executar},
                {"Exercícios Propostos Parte 2 - if/else - Número Negativo?", Exercicio01.Executar},
                {"Exercícios Propostos Parte 2 - uri1044 - São Multiplos?", Exercicio03.Executar},
                {"Exercícios Propostos Parte 2 - uri1046 - Duração do Jogo", Exercicio04.Executar},
                {"Exercícios Propostos Parte 2 - uri1038 - Exercício 5 - minha versão", Exercicio05.Executar},
                {"Exercícios Propostos Parte 2 - uri1037 - Exercício 6", Exercicio06.Executar},
                {"Exercícios Propostos Parte 2 - uri1041 - Exercício 7", Exercicio07.Executar},
                {"Exercícios Propostos Parte 2 - uri1051 - Exercício 8", Exercicio08.Executar}
                                             

                // PROGRAMAÇÃO ORIENTADA A OBJETO
                //{"Membros - Classes e Métodos", Membros.Executar},
               
            });

central.SelecionarEExecutar();