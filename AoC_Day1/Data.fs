module AoC_Day1.Data

let parseData (strData : string) =
    strData.Split('\n')
    |> Array.map (fun p ->
        let pair = p.Split("   ")
        (pair[0] |> int32, pair[1] |> int32))
    |> Array.unzip
    |> function
        | (group1, group2) ->
            (LocationGroup.create group1, LocationGroup.create group2)
