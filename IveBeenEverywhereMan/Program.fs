// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int
    let rec countCities (ac2:Set<string>) =
        function
            | 0 -> ac2.Count
            | a -> countCities (ac2.Add(Console.ReadLine())) (a-1)
    let rec createLst acc =
        function
            | 0 -> acc
            | a -> createLst ((countCities Set.empty (Console.ReadLine() |> int))::acc) (a-1)
    let rec print =
        function
            | [] -> ()
            | a::ac -> printfn "%d" a
                       print ac
    print (List.rev (createLst [] cases))
    0 // return an integer exit code
