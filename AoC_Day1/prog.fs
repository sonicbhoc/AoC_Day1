module AoC_Day1.Prog

open System.IO

[<EntryPoint>]
let main args =
    async {
        use fileStream = new FileStream(args[0], FileMode.Open)
        use fileStreamReader = new StreamReader(fileStream)
        let! fileData = fileStreamReader.ReadToEndAsync() |> Async.AwaitTask
        let strData = Data.parseData fileData

        strData ||> LocationGroup.findDistance |> printfn "Distance: %d"
        strData ||> LocationGroup.findSimilarity |> printfn "Similarity: %d"

        return 0
    }
    |> Async.RunSynchronously
