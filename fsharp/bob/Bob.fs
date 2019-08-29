module Bob
open System

let checkYell (input: string) = 
         (input.ToCharArray() |> Array.toList |> List.filter(Char.IsLetter) |> Seq.length > 1) && input.ToUpper() = input

let checkQuestion (input: string) = input.EndsWith("?")

let (|Question|Exclamation|Yell|Silence|Another|) (input: string) = 
    if checkYell input && checkQuestion input then Exclamation
    elif checkQuestion input then Question 
    elif checkYell input then Yell
    elif input = "" then Silence
    else Another

let response (input: string): string = 
    match input.Trim() with
    | Question -> "Sure."
    | Yell  -> "Whoa, chill out!"
    | Exclamation  -> "Calm down, I know what I'm doing!"
    | Silence -> "Fine. Be that way!"
    | Another -> "Whatever."

