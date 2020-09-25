// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

[<EntryPoint>]
let main argv =
    let rec createMap acc =
        function
            | "" | null -> acc
            | a -> let splitArray = a.Split(" ")
                   let (x,z) = (splitArray.[0],splitArray.[1])
                   createMap ((z,x)::acc) (Console.ReadLine())
                   
    let map = createMap [] (Console.ReadLine()) |> Map.ofList
    let rec printMap acc =
        function
            | "" | null ->
                let rec revPrint ac1 =
                    function
                        | [] -> ac1 |> List.iter (fun e -> printfn "%s" e)
                        | a::ac -> revPrint (a::ac1) ac
                revPrint [] acc
            | a -> let res =
                       match Map.tryFind a map with
                            | Some a -> printMap (a::acc) (Console.ReadLine())
                            | None -> printMap ("eh"::acc) (Console.ReadLine())
                   res
    printMap [] (Console.ReadLine())              
    0 // return an integer exit code
