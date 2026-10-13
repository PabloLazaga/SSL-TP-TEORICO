```

BenchmarkDotNet v0.15.8, Linux Debian GNU/Linux 12 (bookworm) (container)
Intel Core i3-6100 CPU 3.70GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.316
  [Host]     : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 DEBUG
  Job-CNUJVU : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3

InvocationCount=1  UnrollFactor=1  

```
| Method              | Mean      | Error     | StdDev    | Gen0        | Gen1       | Gen2      | Allocated   |
|-------------------- |----------:|----------:|----------:|------------:|-----------:|----------:|------------:|
| QuickSortFuncional  | 644.11 ms | 12.738 ms | 28.753 ms | 169000.0000 | 38000.0000 | 5000.0000 | 409959912 B |
| QuickSortImperativo |  77.49 ms |  1.457 ms |  1.363 ms |           - |          - |         - |           - |
