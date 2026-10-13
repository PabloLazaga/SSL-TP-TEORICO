module QuickSortImperativo

let intercambiar (array: int array) i j =
    let temporal = array.[i]
    array.[i] <- array.[j]
    array.[j] <- temporal


let particionar (array: int array) izquierda derecha =
    let pivote = array.[derecha]

    let mutable indiceMenor = izquierda

    for i in izquierda .. derecha - 1 do
        if array.[i] <= pivote then
            intercambiar array i indiceMenor
            indiceMenor <- indiceMenor + 1

    intercambiar array indiceMenor derecha

    indiceMenor


let rec ordenarInterno (array: int array) izquierda derecha =
    if izquierda < derecha then
        let indicePivote = particionar array izquierda derecha

        ordenarInterno array izquierda (indicePivote - 1)
        ordenarInterno array (indicePivote + 1) derecha


let ordenar (array: int array) =
    ordenarInterno array 0 (array.Length - 1)