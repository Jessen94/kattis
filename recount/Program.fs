// Learn more about F# at http://fsharp.org

open System

let recount =
    let rec createlst acc =
        let input = Console.ReadLine()
        match input with
            | "" | null | "***" -> acc 
            | _ -> createlst (input::acc)
    let lst = createlst [] |> List.groupBy(fun e -> e) |> List.map(fun (x,y) -> (x,(List.length y)))
    let rec winner (b:(string*int)) (c:(string*int)list) =
        match c with
            | [] -> printfn "%s" (fst b)
            | a::ac -> if (snd b) < (snd a) then winner a ac
                       elif (snd b) = (snd a) then printfn "Runoff!"
                       else winner b ac
    winner ("",0) lst