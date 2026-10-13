module QuickSortTests

open System


let private verificarOrdenado (array: int array) nombre =
    for i in 0 .. array.Length - 2 do
        if array.[i] > array.[i + 1] then
            failwith $"Falló: {nombre}"


let ejecutar () =
    let numeros =
        [| 8; -3; 15; 2; 2; 10; -7; 0; 5; 1 |]

    printfn "Original:"
    printfn "%A" numeros


    let resultadoFuncional =
        QuickSortFuncional.ordenar numeros

    verificarOrdenado resultadoFuncional "QuickSort funcional"


    let copia =
        Array.copy numeros

    QuickSortImperativo.ordenar copia

    verificarOrdenado copia "QuickSort imperativo"


    printfn ""
    printfn "Resultado:"
    printfn "%A" resultadoFuncional

    printfn "Todos los tests pasaron."