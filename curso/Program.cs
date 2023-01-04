using curso.LogicaProgramacao;

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
                {"Estrutura Condicional - if/else - Recapitulando Lógica de Programação", EstruturaCondicional.Executar}
                                             

                // PROGRAMAÇÃO ORIENTADA A OBJETO
                //{"Membros - Classes e Métodos", Membros.Executar},
               
            });

central.SelecionarEExecutar();