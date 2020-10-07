// Learn more about F# at http://fsharp.org

open System

let railroad =
    let input = Console.ReadLine().Split(" ")
    let x = 4 * (input.[0] |>int)
    let y = 3 * (input.[1] |>int)
    if (x+y)%2=0 then printfn "possible"
    else printfn "impossible"