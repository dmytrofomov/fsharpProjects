module Bob
open System

let checkSign (input: string) = input.EndsWith("!")

let checkYell (input: string, num ) = 
        input.ToCharArray() |> Array.toList |> List.filter(Char.IsUpper) |> Seq.length > num 

let checkQuestion (input: string) = input.EndsWith("?")

let (|Questio|Sighn|Yell|Silence|Any|) (input: string) = 
    if checkQuestion input && not (checkYell (input, 6)) then Questio 
    elif not(checkQuestion input) && (checkYell (input, 1) && checkSign input || checkYell (input, 6)) then Yell
    elif checkYell (input, 6) && checkQuestion input then Sighn
    elif input = "" then Silence
    else Any

let response (input: string): string = 
    match input.Trim() with
    | Questio -> "Sure."
    | Yell  -> "Whoa, chill out!"
    | Sighn  -> "Calm down, I know what I'm doing!"
    | Silence -> "Fine. Be that way!"
    | _ -> "Whatever."

    
    


