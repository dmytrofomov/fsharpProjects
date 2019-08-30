module ReverseString

let reverse (input: string): string = 
    let rec rev arr out =
        match arr with
        |h::t -> rev t (h::out)
        |[] -> out

    let toList = input |> List.ofSeq
    rev toList [] |> System.String.Concat