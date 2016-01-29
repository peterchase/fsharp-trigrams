namespace Trigrams

module MakeTrigrams =
    let rec private makeOneTrigram wordList =
        match wordList with
            | x :: y :: z :: tail -> (x, y, z) :: makeOneTrigram (y :: z :: tail)
            | [x; y] -> []
            | [x] -> []
            | [] -> []

    let toTrigrams wordSeq =
        Seq.toList wordSeq |> makeOneTrigram
