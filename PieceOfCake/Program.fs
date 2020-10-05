// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let input = Console.ReadLine().Split(" ")
    let orgSides = input.[0] |>int
    let h = input.[1] |>int
    let v = input.[2] |>int
    let h1 = orgSides-h
    let v1 = orgSides-v
    let lst = [(h*v*4); (h1*v*4); (h*v1*4); (h1*v1*4)]
    printfn "%d" (List.max lst)
    0 // return an integer exit code
