﻿//Estrutura Condicional - if / else - ESCOPO e INICIALIZAÇÃO

namespace curso.LogicaProgramacao
{
    public class Desconto
    {
        public static void Executar()
        {
            Console.Write("Digite o preço R$: ");
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
