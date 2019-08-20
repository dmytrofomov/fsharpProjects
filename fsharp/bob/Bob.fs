module Bob
open System

let response (input: string): string = 
    let checkSign (input: string) = input.EndsWith("!")
    let checkYell (input: string, num ) = 
        input.ToCharArray() |> Array.toList |> List.filter(Char.IsUpper) |> Seq.length > num 
    let checkQuestion (input: string) = input.EndsWith("?")

    match input.Trim() with
    | input when not (checkYell (input, 6)) && checkQuestion input -> "Sure."
    | input when not(checkQuestion input) && (checkYell (input, 1) && checkSign input || checkYell (input, 6)) -> "Whoa, chill out!"
    | input when checkYell (input, 6) && checkQuestion input -> "Calm down, I know what I'm doing!"
    | input when input = "" -> "Fine. Be that way!"
    | _ -> "Whatever."

    
    


