module AoC_Day1.Prog

open System.IO

[<EntryPoint>]
let main args =
    async {
        use fileStream = new FileStream(args[0], FileMode.Open)
        use fileStreamReader = new StreamReader(fileStream)
        let! fileData = fileStreamReader.ReadToEndAsync() |> Async.AwaitTask

        Data.parseData fileData ||> LocationGroup.findDistance |> printfn "Answer: %d"

        return 0
    } |> Async.RunSynchronously
