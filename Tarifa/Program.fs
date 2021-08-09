// Learn more about F# at http://fsharp.org

open System
[<EntryPoint>]
let main argv =
    let megaByteAMonth = Console.ReadLine() |> int
    let rec countMegaByte acc =
        function
            | 0 -> printfn "%i" acc
            | n -> countMegaByte (acc + (megaByteAMonth - (Console.ReadLine() |> int))) (n-1)
    countMegaByte megaByteAMonth (Console.ReadLine() |> int)
    0
    
        
            