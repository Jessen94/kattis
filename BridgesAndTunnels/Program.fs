// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int
    let rec createSet (acc:Set<string>) x n =
        function
            | "" | null -> x
            | a when n>0 -> let buildings = a.Split(" ")
                            let firstAcc = acc.Add(buildings.[0])
                            let secondAcc = firstAcc.Add(buildings.[1])
                            createSet (secondAcc) ((secondAcc.Count)::x) (n-1) (Console.ReadLine())
            | _ -> x
    let printlist = List.rev (createSet (Set.empty) [] cases (Console.ReadLine()))
    let rec print =
        function
          | [] -> ()
          | a::ac -> printfn "%d" a
                     print ac
    print printlist
    0 // return an integer exit code
