module Accumulate

let accumulate func input = 
    let rec recursiveCall input func curRes =
        match input with
        | [] -> curRes
        | h::t ->  recursiveCall t func (func h :: curRes)
    recursiveCall input func []
    |> List.rev
     


