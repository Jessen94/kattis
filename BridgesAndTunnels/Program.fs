// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int
    
    let rec searchSets (acc:Set<string>) building (setLst:List<Set<string>>) =
        match setLst with
            | []  -> if acc.IsEmpty then acc.Add(building)
                     else acc
                     
            | a::ac -> if a.Contains(building) then searchSets (Set.union a acc) building ac 
                       else searchSets acc building ac


    let rec createLstSet (acc:List<Set<string>>) countLst n =
        function
            | [] | [""] -> countLst
            | a when n > 0 -> let b1 = searchSets Set.empty a.[0] acc 
                              let b2 = searchSets Set.empty a.[1] acc
                              createLstSet ((Set.union b1 b2)::acc) (((Set.union b1 b2).Count)::countLst) (n-1) (Console.ReadLine().Split(" ") |> List.ofArray)
            | _ -> countLst
    
    
    let rec print =
        function
          | [] -> ()
          | a::ac -> printfn "%d" a
                     print ac
                     
    let first = Console.ReadLine().Split(" ") |> List.ofArray 
    let firstSet = first |> Set.ofList
    print (List.rev (createLstSet [firstSet] [] cases (first)))
    0 // return an integer exit code
