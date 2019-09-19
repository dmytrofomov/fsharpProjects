module QueenAttack

let create (position: int * int) = 
        let checkCell x = x > 0 && x < 8
        checkCell (fst position) && checkCell (snd position)

let canAttack (queen1: int * int) (queen2: int * int) = 
        let getAbs t1 t2 = (abs (fst t1 - fst t2 ), abs (snd t1 - snd t2 ))
        let possitionResult = getAbs queen1 queen2
        fst queen1 = fst queen2 || snd queen1 = snd queen2 || fst possitionResult = snd possitionResult 