module Accumulate

let accumulate func input = 
    let rec recursiveCall input func accumulatedList =
        match input with
        | [] -> accumulatedList
        | head::tail ->  recursiveCall tail func (func head :: accumulatedList)

    recursiveCall input func []
    |> List.rev
     


