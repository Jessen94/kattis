// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let rec indRec acc cases hours =
        match cases with    
            | 0 ->
                acc
            | a ->
               let case = Console.ReadLine().Split(" ")
               let sl = (case.[0]|>int)*((case.[1]|>int)-hours)
               indRec (acc+sl) (a-1) (hours + ((case.[1]|>int)-hours))
    let rec mainRec (acc ) =
        let c = Console.ReadLine()
        match c with
            | "-1" | "" | null -> acc
            | a -> mainRec ((indRec 0 (a|>int) 0)::acc)
                            
    let rec print =
        function
            | [] -> ()
            | a::ac -> Console.WriteLine(a.ToString()+" miles") 
                       print ac
    print (List.rev (mainRec []))
    0 // return an integer exit code
