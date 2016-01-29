namespace Trigrams

module TrigramLookup =

    let private third (_, _, c) = c

    let toTwoWordLookup trigramList =
        System.Linq.Enumerable.ToLookup( trigramList, (fun (x, y, _) -> (x, y)), third)

