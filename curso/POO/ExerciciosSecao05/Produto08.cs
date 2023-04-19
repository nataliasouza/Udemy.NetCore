//Propriedades autoimplementadas
//• É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares
//para as operações get e set. 

//Exemplo: public double Preco { get; private set; }

using System.Globalization;

namespace curso.POO.ExerciciosSecao05
{
    public class Produto08
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; set; }

        public Produto08()
        {
        }

        public Produto08(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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

        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }

        public double AlterarPreco(double novoPreco)
        {
            Preco = novoPreco;
            return Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

