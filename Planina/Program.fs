// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let planina x =
        let rec aux y =
            function
                | 0 -> y*y
                | a -> aux ((y-1)+y) (a-1) 
        aux 2 x
    Console.WriteLine(planina (Console.ReadLine() |> int))
    0 // return an integer exit code
