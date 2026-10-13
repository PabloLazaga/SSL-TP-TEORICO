module Benchmark

open System
open BenchmarkDotNet.Attributes

[<MemoryDiagnoser>]
type QuickSortBenchmark() =

    let mutable datos : int array = [||]
    let mutable copia : int array = [||]

    [<GlobalSetup>]
    member this.PrepararDatos() =
        let random = Random(42)

        datos <- Array.init 1000000 (fun _ -> random.Next())


    [<IterationSetup>]
    member this.PrepararCopia() =
        copia <- Array.copy datos


    [<Benchmark>]
    member this.QuickSortFuncional() =
        QuickSortFuncional.ordenar datos


    [<Benchmark>]
    member this.QuickSortImperativo() =
        QuickSortImperativo.ordenar copia
        copia