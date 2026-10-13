using System.Linq;

public static class QuickSortFuncional
{
    public static int[] Ordenar(int[] array)
    {
        if (array.Length <= 1)
            return array;

        int pivote = array[array.Length - 1];

        int[] menores = array
            .Where(x => x < pivote)
            .ToArray();

        int[] iguales = array
            .Where(x => x == pivote)
            .ToArray();

        int[] mayores = array
            .Where(x => x > pivote)
            .ToArray();

        return Ordenar(menores)
            .Concat(iguales)
            .Concat(Ordenar(mayores))
            .ToArray();
    }
}