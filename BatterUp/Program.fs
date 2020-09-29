// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
     let cases = Console.ReadLine() |> int
     let numbers = Console.ReadLine().Split(" ") |> Array.toList
     let rec createAvg acc n =
            function
                | a::ac when n > 0 -> if a |> int >= 0 then createAvg ((a |> double)::acc) (n-1) ac
                                       else createAvg acc (n-1) ac
                | _ -> List.average acc
     printfn "%f" (createAvg [] cases numbers)
     0 // return an integer exit code
