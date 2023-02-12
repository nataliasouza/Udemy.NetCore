using curso.LogicaProgramacao;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaCondicional;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitiva;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial;

var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                //LÓGICA DE PROGRAMAÇÃO
                {"Exercício Conta Bancária - Recapitulando Lógica de Programação", ContaBancaria.Executar},               
                {"Exercício Placeholders, concatenação e interpolação - Recapitulando Lógica de Programação", Concatenacao.Executar},               
                {"Exercício de Fixação 01 - Recapitulando Lógica de Programação", ExeFixacao01.Executar},               
                {"Exercício Bhaskara - Recapitulando Lógica de Programação", Bhaskara.Executar},              
                {"Exercício Split - Recapitulando Lógica de Programação", SplitPalavras.Executar},             
                {"Exercício Split Parte 2 - Recapitulando Lógica de Programação", SplitParte2.Executar},
                {"- Estrutura Sequencial - Exercicio Fixacao", ExercicioFixacaoSequencial.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1003 - Exercício 1", Sequencial01.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1002 - Exercício 2", Sequencial02.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1007 - Exercício 3", Sequencial03.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1008 - Exercício 4", Sequencial04.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1010 - Exercício 5", Sequencial05.Executar},
                {"- Estrutura Sequencial - Exercícios Propostos Parte 1 - uri1012 - Exercício 6", Sequencial06.Executar},
                {"Exercício Ímpar ou par - Recapitulando Lógica de Programação", ImparPar.Executar},
                {"Exercício Operadores Comparativos - Recapitulando Lógica de Programação", OpComparativos.Executar},
                {"Exercício Operadores Lógicos - Recapitulando Lógica de Programação", OpLogicos.Executar},
                {"- Estrutura Condicional - if/else - Recapitulando Lógica de Programação", EstruturaCondicional.Executar},
                {"- Estrutura Condicional (ESCOPO) - if/else - Recapitulando Lógica de Programação", Desconto.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - if/else - Número Negativo?", Exercicio01.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1044 - São Multiplos?", Exercicio03.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1046 - Duração do Jogo", Exercicio04.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1038 - Exercício 5 - minha versão", Exercicio05.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1037 - Exercício 6", Exercicio06.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1041 - Exercício 7", Exercicio07.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1051 - Exercício 8", Exercicio08.Executar},
                {"Exercício Funcoes - Exercício Qual Maior Número", Funcoes.Executar},
                {"Exercício Estrutura Repetitiva WHILE - Recapitulando Lógica de Programação - Exercício Raiz Quadrada", RaizQuadrada.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1114 - Exercício 1", Repetitiva01.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1115 - Exercício 2", Repetitiva02.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1134 - Exercício 3", Repetitiva03.Executar},
                {"Exercício Estrutura Repetitiva FOR - Recapitulando Lógica de Programação - Exercício Somar Inteiros", SomarInteiros.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1067 - Exercício 1", RepetitivaFor01.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1072 - Exercício 2", RepetitivaFor02.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1079 - Exercício 3", RepetitivaFor03.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1116 - Exercício 4", RepetitivaFor04.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1153 - Exercício 4", RepetitivaFor05.Executar}
                                        

                // PROGRAMAÇÃO ORIENTADA A OBJETO
                //{"Membros - Classes e Métodos", Membros.Executar},
               
            });

central.SelecionarEExecutar();