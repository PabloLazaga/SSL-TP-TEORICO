using System;

public static class QuickSortTests
{
    public static void Ejecutar()
    {
        int[] numeros =
        [
            8, -3, 15, 2, 2, 10, -7, 0, 5, 1
        ];

        Console.WriteLine("Original:");
        Console.WriteLine(string.Join(", ", numeros));


        int[] resultadoFuncional = QuickSortFuncional.Ordenar(numeros);

        VerificarOrdenado(resultadoFuncional, "QuickSort funcional");

        int[] copia = (int[])numeros.Clone();

        QuickSortImperativo.Ordenar(copia);

        VerificarOrdenado(copia, "QuickSort imperativo");


        Console.WriteLine();
        Console.WriteLine("Resultado:");
        Console.WriteLine(string.Join(", ", resultadoFuncional));

        Console.WriteLine("Todos los tests pasaron.");
    }


    private static void VerificarOrdenado(int[] array, string nombre)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                throw new Exception($"Falló: {nombre}");
            }
        }
    }
}