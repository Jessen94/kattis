// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let events = Console.ReadLine()|>int
    let rec createArray acc e =
        function
            | "" | null -> Set.count acc
            | a when e < events -> let newEvent = a.Split(" ")
                                   let numberOfNewDays = (newEvent.[1] |> int) - (newEvent.[0] |> int)
                                   let rec appendToAcc (ac1:Set<int> ) n =
                                       function
                                            | 0 -> ac1.Add (n)
                                            | a -> appendToAcc (ac1.Add (a+n)) n (a-1)
                                   createArray (appendToAcc acc (newEvent.[0] |> int) numberOfNewDays) (e+1) (Console.ReadLine())
            | _ -> Set.count acc
    printfn "%d" (createArray Set.empty 0 (Console.ReadLine()))
    0 // return an integer exit code
