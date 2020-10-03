 // Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int
    let rec createPrintList acc =
        function
            | 0 -> acc
            | a when a>0 ->
                let numbers = Console.ReadLine().Split(" ")
                let revenueForNotAd = (numbers.[0] |> int)
                let revenueForAd = (numbers.[1] |> int) - (numbers.[2] |> int)
                if revenueForAd = revenueForNotAd then createPrintList ("does not matter"::acc) (a-1)
                elif revenueForAd > revenueForNotAd then createPrintList ("advertise"::acc) (a-1)
                else createPrintList ("do not advertise"::acc) (a-1)
            | _ -> acc
    let rec print =
        function
            | [] -> ()
            | a::ac -> printfn "%s" a
                       print ac
    print (List.rev (createPrintList [] cases))
    
    0 // return an integer exit code
