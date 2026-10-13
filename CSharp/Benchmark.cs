using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class QuickSortBenchmark
{
    private int[] numeros = [];
    private int[] copia = [];

    [GlobalSetup]
    public void Setup()
    {
        Random random = new(42);

        numeros = Enumerable
            .Range(0, 1000000)
            .Select(_ => random.Next())
            .ToArray();
    }

    [IterationSetup]
    public void PrepararCopia()
    {
        copia = (int[])numeros.Clone();
    }

    [Benchmark]
    public int[] BenchmarkQuickSortFuncional()
    {
        return QuickSortFuncional.Ordenar(numeros);
    }

    [Benchmark]
    public int[] BenchmarkQuickSortImperativo()
    {
        QuickSortImperativo.Ordenar(copia);

        return copia;
    }
}