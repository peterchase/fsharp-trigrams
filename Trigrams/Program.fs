// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Trigrams

[<EntryPoint>]
let main argv = 
    FileInput.getElements argv.[0] |> Seq.iter (string >> printfn "%s")
    0 // return an integer exit code
