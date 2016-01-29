// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

namespace Trigrams

module App =
    [<EntryPoint>]
    let main argv = 
        Trigrams.FileInput.getElements argv.[0] |> Trigrams.MakeTrigrams.toTrigrams |> List.iter (string >> printfn "%s")
        0 // return an integer exit code
