//Campos de banco de dados que podem valer nulo (data de nascimento,algum valor numérico, etc.).
//Dados e parâmetros opcionais.

//Métodos:
// GetValueOrDefault
// HasValue
// Value (lança uma exceção se não houver valor)

//Operador de coalescência nula
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

//Exemplo
//double? x = null;
//double y = x ?? 0.0;

namespace curso.POO.ExerciciosSecao06
{
    public class ValoresNulos
    {
        public static void Executar()
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}
