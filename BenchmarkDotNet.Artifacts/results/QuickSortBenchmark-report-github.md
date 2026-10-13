```

BenchmarkDotNet v0.15.8, Linux Debian GNU/Linux 12 (bookworm) (container)
Intel Core i3-6100 CPU 3.70GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.316
  [Host]     : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3
  Job-CNUJVU : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3

InvocationCount=1  UnrollFactor=1  

```
| Method                       | Mean      | Error     | StdDev    | Gen0        | Gen1       | Gen2      | Allocated   |
|----------------------------- |----------:|----------:|----------:|------------:|-----------:|----------:|------------:|
| BenchmarkQuickSortFuncional  | 550.12 ms | 10.922 ms | 29.529 ms | 299000.0000 | 16000.0000 | 2000.0000 | 570965480 B |
| BenchmarkQuickSortImperativo |  94.19 ms |  1.460 ms |  2.047 ms |           - |          - |         - |           - |
