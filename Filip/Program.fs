// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let inputArray = Console.ReadLine().Split(" ")
    let fromlisttostring cl =
        String.concat "" <| List.map string cl
    let a = List.rev (List.ofArray (inputArray.[0].ToCharArray())) |> fromlisttostring |> int
    let b = List.rev (List.ofArray (inputArray.[1].ToCharArray())) |> fromlisttostring |> int
    let print = if a>b then printfn "%d" a else printfn "%d" b
    print
    0 // return an integer exit code
