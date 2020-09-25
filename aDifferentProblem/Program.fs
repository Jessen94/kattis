// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let rec absoluteNumber ac1 =
        function
            | "" | null ->
                let rec rev acc =
                    function
                        | [] ->
                            let rec print =
                                function
                                    | [] -> ()
                                    | a::ac -> printfn "%d" a
                                               print ac
                            print acc
                        | a::ac -> rev (a::acc) ac
                rev [] ac1
            | a -> let numbers = a.Split(" ")
                   absoluteNumber ((Math.Abs((numbers.[0] |> int64)-(numbers.[1] |> int64)))::ac1) (Console.ReadLine())
    absoluteNumber [] (Console.ReadLine())
    0 // return an integer exit code
