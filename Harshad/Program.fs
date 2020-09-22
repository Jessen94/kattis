// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let iString              = Console.ReadLine()
    let iNumber              = iString |> int
    let iStringArray         = iString.ToCharArray()
    let rec sumNumber acc sa =
        match sa with
            | []    -> acc
            | a::ac -> sumNumber ((a|> string|>int)+acc) ac
    let rec calculateHarshad n divider number =
        match (number+n)%(divider+n) = 0 with
            | true ->  Console.WriteLine((number+n).ToString())
            | false -> calculateHarshad (n+1) divider number
                       
    calculateHarshad 0 (sumNumber 0 (iStringArray |> Array.toList)) iNumber        

    0 // return an integer exit code
