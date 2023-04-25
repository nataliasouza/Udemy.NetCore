//Garbage collector é um processo que automatiza o gerenciamento de memória de um programa em execução, que monitora
//os objetos alocados dinamicamente pelo programa(no heap), desalocando aqueles que não estão mais sendo utilizados.

// ***Valor "null"

//Tipos de referência aceitam o valor "null", que indica que a variável aponta pra ninguém.

//Product prod1, prod2;
//prod1 = new Product("TV", 900.00, 0);
//prod2 = null;


namespace curso.POO.ExerciciosSecao06
{
    public class Desalocacao
    {

        public static void Executar()
        {
            //Desalocação por Garbage collector

            Product p1, p2;
            p1 = new Product("TV", 900.00, 0);
            p2 = new Product("Mouse", 30.00, 0);

            //P1 agora aponta para a referência de memória heap de p2
            p1 = p2;

            Console.WriteLine(p1.ToString());

            //Desalocação por escopo 

            int valor = method();

            Console.WriteLine(valor);
        }

        static int method()
        {
            int x = 10;
            if (x > 0)
            {
                //y só pertence ao escopo local
                int y = 20;
            }
            return x;
        }
    }

    public class Product
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Product(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Titular: "
                + Valor
                + ", Quantidade: "
                + Quantidade;
        }

        //Outro exemplo 

        //static void method1()
        //{
        //    Product p = method2();
        //    Console.WriteLine(p.Nome);             
        //}

        //static Product method2()
        //{
        //    Product prod = new Product("TV", 900.0, 0); 
        //    return prod;
        //}
    }
}
