// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let numbers = Console.ReadLine().Split(" ")
    let order = Console.ReadLine().ToCharArray() |> List.ofArray
    let sortedNumbers = Seq.ofArray numbers |> Seq.sort |> Array.ofSeq
    let A = sortedNumbers.[0]
    let B = sortedNumbers.[1]
    let C = sortedNumbers.[2]
    let rec printOrder acc word =
         match word with
            | a::ac when a = 'A'  -> printOrder (A::acc) ac
            | a::ac when a = 'B'  -> printOrder (B::acc) ac
            | a::ac when a = 'C'  -> printOrder (C::acc) ac
            | _ -> let rec rev ac2 =
                        function
                            | [] -> ac2
                            | a::ac -> rev (a::ac2) ac
                   let correctOrder = rev [] acc
                   let rec print =
                       function
                           | [] -> ()
                           | a::ac -> Console.Write(a+" ")
                                      print ac
                   print correctOrder
    printOrder [] order
    0 // return an integer exit code
