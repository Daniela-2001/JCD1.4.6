namespace JCD1._4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso
            int input = 5;
            long result = Factorial(input);

            Console.WriteLine($"O fatorial de {input} é: {result}");
        }

        static long Factorial(int n)
        {
            // Verifica se n é menor que 0 (fatorial não é definido para números negativos)
            if (n < 0)
            {
                throw new ArgumentException("O fatorial não é definido para números negativos.");
            }

            // Caso base: fatorial de 0 é 1
            if (n == 0)
            {
                return 1;
            }

            // Calcula o fatorial utilizando um loop
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}