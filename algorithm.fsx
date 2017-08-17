// Algoritmo Quicksort
> let rec qsort = function
    | [] -> []
    | x :: xs ->
        let (smaller, larger) = xs |> List.partition (fun y -> y <= x)
        qsort smaller @ [x] @ qsort larger;;
val qsort : _arg1:'a list -> 'a list when 'a : comparison


[3; 3; 1; 6; 5; 4] |> qsort;;