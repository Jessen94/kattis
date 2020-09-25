// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    
    let insert z lst =
        let rec aux (c:string) (lst2:string list) =
            match lst2 with
                | [] -> [c]
                | a::ac -> if c.Substring(0,2) < a.Substring(0,2) then c::a::ac       
                           else a::aux c ac
        aux z lst
        
    let sort b =
        let rec getNames acc =
            function
                | 0 -> acc
                | a -> getNames (insert (Console.ReadLine()) acc) (a-1)
        getNames [] b
        
    let rec makeOutPut acc =
        let cases = Console.ReadLine() |> int
        match cases with
            | 0 -> let rec print =
                       function
                           | []    -> ()
                           | a::ac -> printfn "%s" a
                                      print ac
                   print acc
            | a ->
                makeOutPut (acc@(sort a)@[" "])
    makeOutPut []
    0 // return an integer exit code
