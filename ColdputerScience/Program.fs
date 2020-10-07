// Learn more about F# at http://fsharp.org

open System

let CPS =
    let cases = Console.ReadLine() |> int
    let countNeg =
        let input = Console.ReadLine().Split(" ")
        (List.filter(fun e -> (e|>int )<0) (List.ofArray input)).Length
    printfn "%d" countNeg