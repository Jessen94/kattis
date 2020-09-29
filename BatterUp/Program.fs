// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
     let cases = Console.ReadLine() |> double
     let numbers = Console.ReadLine().Split(" ")
     let rec createAvg acc n (lst:string list)=
         match lst with
             | [] -> List.average acc
             | a::ac when n > 0.0 -> createAvg ((a|>double)::acc) (n-1.0) ac
             | _ -> List.average acc
     printfn "%f" (createAvg [] cases (Array.toList numbers))
     0 // return an integer exit code
