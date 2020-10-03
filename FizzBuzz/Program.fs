// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let numbers = Console.ReadLine().Split(" ")
    let x = numbers.[0] |> int
    let y = numbers.[1] |> int
    let n = numbers.[2] |> int
    let rec createList acc =
        function
            | 0 -> acc
            | a -> match (a%x=0,a%y=0) with
                        | (true,true) -> createList ("FizzBuzz"::acc) (a-1)
                        | (true, false) -> createList ("Fizz"::acc) (a-1)
                        | (false,true) -> createList ("Buzz"::acc) (a-1)
                        | _ -> createList (a.ToString()::acc) (a-1)
    let rec print =
        function
            | [] -> ()
            | a::ac -> printfn "%s" a
                       print ac
    print (createList [] n)
    0 // return an integer exit code
