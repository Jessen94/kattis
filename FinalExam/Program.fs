// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let answers = Console.ReadLine() |> int
    let ignoredAnswer = Console.ReadLine()
    let rec aux acc a =
        match a with 
            | 0 -> acc
            | _ -> match (Console.ReadLine().Equals("A")) with
                    | true -> aux (acc+1) (a-1)
                    | false -> aux acc (a-1)
    printfn "%d" (aux 0 answers)
    0 // return an integer exit code
