// Learn more about F# at http://fsharp.org

open System

let QALY =
    let cases = Console.ReadLine() |> int
    let rec createQALY acc n =
        let input = Console.ReadLine().Split(" ")
        match n with
            | 1 -> printfn "%.3f" (acc+((input.[0]|>float)*(input.[1]|>float)))
            | a -> createQALY (acc+((input.[0]|>float)*(input.[1]|>float))) (a-1)
    createQALY 0.0 cases
