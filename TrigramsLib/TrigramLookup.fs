namespace Trigrams

module TrigramLookup =

    let private third (_, _, c) = c

    let toTwoWordLookup trigramList =
        trigramList |> List.groupBy (fun (x, y, _) -> (x, y))
    
