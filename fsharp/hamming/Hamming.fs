module Hamming



let distance (strand1: string) (strand2: string): int option =
    match (strand1.Length, strand2.Length) with
    | (0,0) -> Some 0
    | (x,y) when x <> y -> None
    | _ ->
        Seq.zip strand1 strand2
        |> Seq.filter (fun (a,b) -> a <> b)
        |> Seq.length 
        |> Some