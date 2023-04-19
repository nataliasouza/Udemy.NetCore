﻿
//É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas
//operações seguras e que o mantenha em um estado consistente.

//• Todo atributo é definido como private
//• Implementa - se métodos Get e Set para cada atributo, conforme regras de negócio
//• Nota: não é usual na plataforma C#

//Opção 1: implementação manual
//Um atributo private não pode ser acessado diretamente por outra classe.

using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class Produto06
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto06()
        {
        }
        public Produto06(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }       

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
