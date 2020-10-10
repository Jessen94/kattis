// Learn more about F# at http://fsharp.org

open System

let LtL =
    let cases = Console.ReadLine() |> int
    let junk = Console.ReadLine().Split(" ") |> List.ofArray |> List.map(fun e -> (e|>int))
    let min = List.min(junk)
    let days = List.findIndex(fun e -> e=min) junk
    printfn "%d" days