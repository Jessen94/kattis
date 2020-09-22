// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let rec calculate acc input =
        match input with
        | null | "" -> acc
        | i when input.Length > 1 ->  let arr = input.ToCharArray()
                                      let lastDigit = arr.[input.Length-1] |> string |> int |> double
                                      let number = input.Remove(input.Length-1)  |> int |> double
                                      calculate (acc + Math.Pow(number, lastDigit |> int |> double)) (Console.ReadLine())
        | i ->  calculate (acc + (0 |> int |> double)) (Console.ReadLine())
    let input = Console.ReadLine()
    Console.WriteLine(calculate 0.0 input)
    0 // return an integer exit code

