// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stringList = Console.ReadLine().Split(" ") |> Array.toList
    let rec checkDup =
        function
            | []    -> Console.WriteLine("yes")
            | a::ac -> let b = ac |> List.toSeq
                       if (b |> Seq.contains a) then Console.WriteLine("no")
                       else checkDup ac
    checkDup stringList
            
    0 // return an integer exit code
