public static class QuickSortImperativo
{
    public static void Ordenar(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }

    private static void QuickSort(int[] array, int izquierda, int derecha)
    {
        if (izquierda >= derecha)
            return;

        int indicePivote = Particionar(array, izquierda, derecha);

        QuickSort(array, izquierda, indicePivote - 1);
        QuickSort(array, indicePivote + 1, derecha);
    }

    private static int Particionar(int[] array, int izquierda, int derecha)
    {
        int pivote = array[derecha];

        int indiceMenor = izquierda;

        for (int i = izquierda; i < derecha; i++)
        {
            if (array[i] <= pivote)
            {
                Intercambiar(array, i, indiceMenor);
                indiceMenor++;
            }
        }
        
        Intercambiar(array, indiceMenor, derecha);

        return indiceMenor;
    }

    private static void Intercambiar(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}