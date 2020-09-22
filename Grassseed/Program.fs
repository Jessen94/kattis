// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let costPerSM = Console.ReadLine() |> float
    let lawns = Console.ReadLine() |> int
    let calculateLawns =
        let rec aux acc n =
            function
                | null | "" -> acc
                | a when n > 0 -> let lawn = a.Split(" ")
                                  let squareMetres = (lawn.[0] |> float) * (lawn.[1] |> float)
                                  let pricePerLawn = (costPerSM * squareMetres)
                                  aux (acc+pricePerLawn) (n-1) (Console.ReadLine())
                | _ -> acc
        aux 0.0 lawns (Console.ReadLine())
    Console.WriteLine(calculateLawns)
    0 // return an integer exit code
