// Learn more about F# at http://fsharp.org

open System
let ss =
    let cases = Console.ReadLine() |> int
    let rec createList (acc: string list) n =
        let str = Console.ReadLine()
        let l = (String.length str)
        match str with
            | "" | null -> acc
            | _  when n > 0 ->
                if (str.StartsWith("Simon says")) then
                    createList (str.[10..(l-1)]::acc) (n-1)
                else createList (acc) (n-1)
            | _ -> acc
    let rec print =
        function
            | [] -> ()
            | a::ac -> printfn "%s" a
                       print ac
    print (List.rev (createList [] cases))