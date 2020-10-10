// Learn more about F# at http://fsharp.org

open System

let pet =
    let rec calculateWinner acc =
        function
            | "" | null -> List.rev acc   
            | a -> 
                let inputArray = a.Split(" ") |> List.ofArray
                let rec sum acc =
                    function
                        | [] -> acc
                        | b::ac -> sum ((b|>int)+acc) ac
                
                calculateWinner ((sum 0 inputArray)::acc) (Console.ReadLine())
    let winner = (calculateWinner [] (Console.ReadLine()))
    printfn "%d %d" ((List.findIndex(fun e -> e=(List.max winner)) winner)+1) (List.max winner)