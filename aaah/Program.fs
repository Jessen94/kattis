// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let jon = Console.ReadLine()
    let doctor = Console.ReadLine()
    let print =
        if jon.Length < doctor.Length then printfn "no"
        else printfn "go"
    print 
    0 // return an integer exit code
