using curso.LogicaProgramacao;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaCondicional;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitiva;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaRepetitivaFor;
using curso.LogicaProgramacao.ExerciciosPropostos.EstruturaSequencial;
using curso.POO;
using curso.POO.ExercicioFixacao;
using curso.POO.ExerciciosSecao05;
using curso.POO.ExerciciosSecao06;
using curso.POO.PrimeirosExercicios;

var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                #region "Lógica de Programação"
    
                //UNIDADE 1 - RECAPITULANDO LÓGICA DE PROGRAMAÇÃO
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
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - if/else - Exercício 1 - Número Negativo?", Exercicio01.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1044 - Exercício 3 - São Multiplos?", Exercicio03.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1046 - Exercício 4 - Duração do Jogo", Exercicio04.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1038 - Exercício 5 - minha versão", Exercicio05.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1037 - Exercício 6", Exercicio06.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1041 - Exercício 7", Exercicio07.Executar},
                {"- Estrutura Condicional - Exercícios Propostos Parte 2 - uri1051 - Exercício 8", Exercicio08.Executar},
                {"Exercício Funções - Exercício Qual Maior Número", Funcoes.Executar},
                {"Exercício Estrutura Repetitiva WHILE - Recapitulando Lógica de Programação - Exercício Raiz Quadrada", RaizQuadrada.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1114 - Exercício 1", Repetitiva01.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1115 - Exercício 2", Repetitiva02.Executar},
                {"- Estrutura Repetitiva WHILE - Exercícios Propostos Parte 3 - uri1134 - Exercício 3", Repetitiva03.Executar},
                {"Exercício Estrutura Repetitiva FOR - Recapitulando Lógica de Programação - Exercício Somar Inteiros", SomarInteiros.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1067 - Exercício 1", RepetitivaFor01.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1072 - Exercício 2", RepetitivaFor02.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1079 - Exercício 3", RepetitivaFor03.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1116 - Exercício 4", RepetitivaFor04.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1153 - Exercício 5", RepetitivaFor05.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1157 - Exercício 6", RepetitivaFor06.Executar},
                {"- Estrutura Repetitiva FOR - Exercícios Propostos Parte 4 - uri1143 - Exercício 7", RepetitivaFor07.Executar},

                #endregion
                                        
                #region "Intodução à Programação Orientada a Objetos"

                // INTRODUÇÃO À PROGRAMAÇÃO ORIENTADA A OBJETOS
                // Capítulo: Classe, atributos, métodos, membros, membros estáticos

                {"Exercício - Resolvendo um problema SEM orientação a objetos - Calcular área de um triângulo", ProblemaExemplo.Executar},
                {"Exercício - Resolvendo um problema COM orientação a objetos - Calcular área de um triângulo", Triangulo.Executar},
                {"Exercício - Primeiros Exercícios - Exercício 01 - Qual pessoa tem mais idade?", Pessoa.Executar},
                {"Exercício - Primeiros Exercícios - Exercício 02 - Media Salarial", Funcionario.Executar},
                {"Exercício - Criando um método p/ reaproveitamento e delegação - Calcular área de um triângulo", Triangulo02.Executar},
                {"Exercício - Segundo problema exemplo - Ler, mostrar, inserir e visualizar dados do Produto", Produto.Executar},
                {"Exercício de Fixação 01 - POO - Calcular Área, Perímetro e Diagonal", Retangulo.Executar}, 
                {"Exercício de Fixação 02 - POO - Ler e mostrar dados de um funcionário", Colaborador.Executar}, 
                {"Exercício de Fixação 03 - POO - Ler nome e notas e mostrar nota final de um Aluno", Aluno.Executar},
                {"Problema Exemplo - POO - Ler valor e mostrar circunferência e volume de uma esfera Versão01", CalculadoraEsfera.Executar},
                {"Problema Exemplo - POO - Ler valor e mostrar circunferência e volume de uma esfera Versão02", CalculadoraEsfera02.Executar}, 
                {"Problema Exemplo - POO - Ler valor e mostrar circunferência e volume de uma esfera Versão03", CalculadoraEsfera03.Executar},
                {"Exercício de Fixação - POO - ler a cotação do dólar e um valor a ser convertido em R$", ConversorDeMoedas.Executar},
                
                #endregion

                #region "Técnicas de Programação Orientada a Objetos e Estrutura de Dados"

                // INTRODUÇÃO À PROGRAMAÇÃO ORIENTADA A OBJETOS
                // Capítulo: Construtores, palavra this, sobrecarga, encapsulamento.

                {"Exercício - POO - Criar a classe Produto com construtor", Produto02.Executar},
                {"Exercício - POO - Criar a classe Produto com construtor opcional", Produto03.Executar},
                {"Sintaxe Alternativa p/ iniciar valores - Criar a classe Produto com construtor opcional", Produto04.Executar},
                {"Exercício - POO - Palavra this - Referência para o próprio objeto", Produto05.Executar},
                {"Exercício - POO - Encapsulamento - Exemplo utilizando a classe Produto06", Exemplo.Executar},
                {"Exercício - POO - Properties - Exemplo utilizando a classe Produto07", ExemploProperties.Executar},
                {"Exercício - POO - Auto Properties - Exemplo utilizando a classe Produto08", ExemploAutoProperties.Executar},
                {"Exercício - POO - Modificadores Acesso - Anotações", ModificadoresAcesso.Executar},
                {"Exercício - POO - Conta Bancária - Anotações", ContaBancaria02.Executar},
                
                #endregion
                
                #region "Programação Orientada a Objetos - Arrays / Listas"

                // INTRODUÇÃO À PROGRAMAÇÃO ORIENTADA A OBJETOS
                // Capítulo: Comportamento de memória, arrays, listas.

                {"Exercício - POO - Exercício Structs", ExercicioStruct.Executar},                

                #endregion
            });

central.SelecionarEExecutar();