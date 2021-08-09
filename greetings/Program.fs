

open System

[<EntryPoint>]
let main argv =
    let input = Console.ReadLine()
    let numberOfEs = (input.Length - 2)*2
    let rec aux x =
        function
        | 0 -> Console.WriteLine(x+"y")
        | y -> aux (x+"e") (y-1)
    aux "h" numberOfEs
    0