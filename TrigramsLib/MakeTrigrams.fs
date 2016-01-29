namespace Trigrams

module MakeTrigrams =
    let rec private makeOneTrigramRecursive wordList result = 
        match wordList with
            | x :: y :: z :: tail -> makeOneTrigramRecursive (y :: z :: tail) ((x, y, z) :: result)
            | [x; y] -> result
            | [x] -> result
            | [] -> result
    
    let private makeOneTrigram wordList = makeOneTrigramRecursive wordList []

    let toTrigrams wordSeq =
        Seq.toList wordSeq |> makeOneTrigram

    
