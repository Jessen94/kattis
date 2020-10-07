// Learn more about F# at http://fsharp.org

open System

let DiceCup =
    let input = Console.ReadLine().Split(" ")
    let a = input.[0] |> int
    let b = input.[1] |> int
    let print =
        match (a  = b, a > b, a < b) with
            | (true,false,false) -> printfn "%d" ((a)+1) 
            | (false,true,false) -> for i in (b+1) .. (a+1) do
                                    printfn "%d" i
            | (false,false,true) -> for i in (a+1) .. (b+1) do
                                    printfn "%d" i
    print 


