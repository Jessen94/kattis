// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let word = Console.ReadLine()
    printfn "%s %s %s" word word word
    0 // return an integer exit code
