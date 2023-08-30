internal class Program
{
    private static void Main(string[] args)
    {
        var listaNumeros = new List<int> { 7, 5, 3, 9, 6, 4, 1 };

        Console.WriteLine("Tarefa 1");

        Console.WriteLine("Lista original:");
        ImprimirLista(listaNumeros);

        for (int i = 0; i < listaNumeros.Count(); i++)
        {
            if (listaNumeros[i] == 9)
                listaNumeros[i] = 5;
        }

        listaNumeros.Remove(4);

        Console.WriteLine("Nova lista:");
        ImprimirLista(listaNumeros);

        Console.WriteLine($"Soma dos valores da nova lista: {listaNumeros.Sum()}");

        static void ImprimirLista(List<int> listaNumeros)
        {
            foreach (var numero in listaNumeros)
            {
                Console.Write($"{numero}, ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Tarefa 2");
        Console.WriteLine("Dado o resulado acima, qual será o resultado do SQL abaixo?");
        Console.WriteLine("O resultado será 85");

        Console.WriteLine();

        Console.WriteLine("Tarefa 3");

        int[] numeros = { 2, 7, 11, 15 };
        var valorDesejado = 9;
        int primeiroValor = numeros.First();

        foreach (var numero in numeros)
        {
            var soma = numero + primeiroValor;
            if (soma.Equals(valorDesejado))
            {
                Console.WriteLine($"Soma da entrada: {valorDesejado}");
                Console.WriteLine($"{valorDesejado} é a soma de {primeiroValor} + {numero}");
            }
        }
    }
}