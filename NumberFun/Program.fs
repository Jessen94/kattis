// Learn more about F# at http://fsharp.org

open System

let NB =
    let cases = Console.ReadLine() |> int
    let rec testNumber acc n =
        let Read = Console.ReadLine()
        match Read with
        | "" | null -> acc
        | _ ->
            let input = Read.Split(" ")
            let a = input.[0] |> float
            let b = input.[1] |> float
            let c = input.[2] |> float
            match n with
                | 0 -> acc
                | x when a-b = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when a+b = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when a*b = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when a/b = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when b-a = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when b+a = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when b*a = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x when b/a = c ->
                    testNumber ("Possible"::acc) (x-1)
                | x -> testNumber ("Impossible"::acc) (x-1)
        
    let rec print =
        function
            | [] -> ()
            | a::ac -> printfn "%s" a
                       print ac
    print (List.rev (testNumber [] cases))