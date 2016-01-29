namespace Trigrams

module FileInput =

    let getElements fileName =
        seq { use sr = System.IO.File.OpenText(fileName)
              while not sr.EndOfStream do
                 let line = sr.ReadLine() 
                 let words = line.Split ' '
                 yield! words }
