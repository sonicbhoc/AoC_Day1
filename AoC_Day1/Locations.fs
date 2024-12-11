namespace AoC_Day1

[<Struct>]
[<RequireQualifiedAccess>]
type Location =
    | Id of int32

type LocationGroup =
    private
    | Locations of Location list

module LocationGroup =
    let create locations =
        locations
        |> Seq.toList
        |> List.sort
        |> List.map Location.Id
        |> Locations

    let findDistance (Locations group1) (Locations group2) =
        (group1, group2)
        ||> List.map2 (fun (Location.Id locId1) (Location.Id locId2) -> locId2 - locId1 |> abs)
        |> List.sum
