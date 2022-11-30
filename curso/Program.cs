
using curso.LogicaProgramacao;

var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                //LÓGICA DE PROGRAMAÇÃO
                {"Conta Bancária - Recapitulando Lógica de Programação", ContaBancaria.Executar},               
                {"Placeholders, concatenação e interpolação - Recapitulando Lógica de Programação", Concatenacao.Executar},               
                {"Exercício de Fixação 01 - Recapitulando Lógica de Programação", ExeFixacao01.Executar},               
                                             

                // PROGRAMAÇÃO ORIENTADA A OBJETO
                //{"Membros - Classes e Métodos", Membros.Executar},
               
            });

central.SelecionarEExecutar();