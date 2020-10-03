// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let numbers = Console.ReadLine().Split(" ")
    let order = Console.ReadLine().Trim().ToCharArray() |> List.ofArray
    let rec printOrder acc  =
         let sortedArray = Array.map(fun e -> (e|>int)) numbers |> Array.sortDescending
         function
            | a::ac when a = 'A'  -> printOrder (sortedArray.[2]::acc) ac
            | a::ac when a = 'B'  -> printOrder (sortedArray.[1]::acc) ac
            | a::ac when a = 'C'  -> printOrder (sortedArray.[0]::acc) ac
            | _ -> let rec print =
                       function
                           | [] -> ()
                           | z::ac -> Console.Write(z.ToString()+" ")
                                      print ac
                   print (List.rev acc)
    printOrder [] order
    0 // return an integer exit code
