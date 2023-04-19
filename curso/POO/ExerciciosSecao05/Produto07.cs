//• São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e
//não de métodos

//• Uma propriedade é um membro que oferece um mecanismo flexível para ler,
//gravar ou calcular o valor de um campo particular. As propriedades podem ser
//usadas como se fossem atributos públicos, mas na verdade elas são métodos
//especiais chamados "acessadores". Isso permite que os dados sejam
//acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
//dos métodos.

//Exercício Properties - Aula 56

using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class Produto07
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto07()
        {
        }
        public Produto07(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
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
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
