module QueenAttack

let create (first, second) = 
        let checkCell x = x > 0 && x < 8
        checkCell first && checkCell second

let canAttack (row1, column1) (row2, column2) = 
        let checkAbsDistanse = abs (row1 - row2) = abs (column1 - column2 )
        row1 = row2 || column1 = column2 || checkAbsDistanse