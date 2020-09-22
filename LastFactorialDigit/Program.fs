// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let factorial x =
        let rec aux acc =
            function
                | 0 -> 0
                | 1 -> acc
                | a -> aux (acc*a) (a-1)
                
        let rec inputList acc b =
            function
                | "" | null -> acc
                | a when b > 0 -> inputList ((aux 1 (a |> int))::acc) (b-1) (Console.ReadLine())
                | _ -> acc
        let rec listRev acc =
            function
                | [] -> acc
                | a::ac -> listRev (a::acc) ac
                
        let rec print (u:int list) =
            match u with
                | [] ->    ()
                | [a] ->   Console.WriteLine(a.ToString().Substring(a.ToString().Length-1))
                           print []
                | a::ac -> Console.WriteLine(a.ToString().Substring(a.ToString().Length-1))
                           print ac
        print (listRev [] (inputList [] ((x |> int)) (Console.ReadLine())))
    factorial (Console.ReadLine())

    0 // return an integer exit code
