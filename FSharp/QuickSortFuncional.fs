module QuickSortFuncional

let rec ordenar (numeros: int array) =
    match numeros with
    | [||] -> [||]
    | _ ->
        let pivote = numeros.[numeros.Length - 1]

        let menores =
            numeros
            |> Array.filter (fun x -> x < pivote)
            |> ordenar

        let iguales =
            numeros
            |> Array.filter (fun x -> x = pivote)

        let mayores =
            numeros
            |> Array.filter (fun x -> x > pivote)
            |> ordenar

        Array.concat [| menores; iguales; mayores |]