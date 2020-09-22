// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let heightAndAngle = Console.ReadLine().Split(" ")
    let actualHeight = Math.Ceiling((heightAndAngle.[0] |> float) / ((Math.Sin((Math.PI/180.0)*(heightAndAngle.[1]|> float))))) |> int
    Console.WriteLine(actualHeight)
    0 // return an integer exit code
