module Program

open BenchmarkDotNet.Running

[<EntryPoint>]
let main _ =
    BenchmarkRunner.Run<Benchmark.QuickSortBenchmark>() |> ignore
    0